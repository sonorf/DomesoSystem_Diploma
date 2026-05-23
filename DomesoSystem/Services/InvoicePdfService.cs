using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using DomesoSystem.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DomesoSystem.Services
{
    public class InvoicePdfService
    {
        public string GenerateInvoicePdf(int saleId)
        {
            DataTable saleTable = GetSaleData(saleId);
            DataTable itemsTable = GetSaleItems(saleId);

            if (saleTable.Rows.Count == 0)
            {
                throw new InvalidOperationException("Продажа не найдена.");
            }

            DataRow sale = saleTable.Rows[0];

            string folderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "DomesoSystem",
                "Invoices"
            );

            Directory.CreateDirectory(folderPath);

            string fileName = "Invoice_Sale_" + saleId + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
            string filePath = Path.Combine(folderPath, fileName);

            CreatePdfDocument(filePath, sale, itemsTable);

            return filePath;
        }

        public void OpenPdf(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("PDF-файл не найден.", filePath);
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }

        private DataTable GetSaleData(int saleId)
        {
            string query = @"
                SELECT
                    SaleId,
                    SaleDate,
                    ClientName,
                    TotalAmount,
                    SaleStatusName,
                    CreatedByUser,
                    CreatedAt,
                    CancelReason
                FROM dbo.vSales
                WHERE SaleId = @SaleId";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@SaleId", SqlDbType.Int).Value = saleId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        private DataTable GetSaleItems(int saleId)
        {
            string query = @"
                SELECT
                    ProductName,
                    Quantity,
                    UnitPrice,
                    LineTotal
                FROM dbo.vSaleItemsGrouped
                WHERE SaleId = @SaleId
                ORDER BY ProductName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@SaleId", SqlDbType.Int).Value = saleId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        private void CreatePdfDocument(string filePath, DataRow sale, DataTable itemsTable)
        {
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Fonts", "arial.ttf");

            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            Font titleFont = new Font(baseFont, 16, Font.BOLD);
            Font headerFont = new Font(baseFont, 11, Font.BOLD);
            Font normalFont = new Font(baseFont, 10, Font.NORMAL);
            Font smallFont = new Font(baseFont, 9, Font.NORMAL);
            Font tableHeaderFont = new Font(baseFont, 9, Font.BOLD);
            Font tableFont = new Font(baseFont, 9, Font.NORMAL);

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(document, stream);

                document.Open();

                AddTitle(document, sale, titleFont, normalFont);
                AddSaleInfo(document, sale, headerFont, normalFont);
                AddItemsTable(document, itemsTable, tableHeaderFont, tableFont);
                AddTotal(document, sale, headerFont);
                AddFooter(document, smallFont);

                document.Close();
            }
        }

        private void AddTitle(Document document, DataRow sale, Font titleFont, Font normalFont)
        {
            Paragraph title = new Paragraph("Счет по продаже № " + sale["SaleId"], titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 10f;
            document.Add(title);

            Paragraph date = new Paragraph(
                "Дата формирования документа: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                normalFont
            );
            date.Alignment = Element.ALIGN_RIGHT;
            date.SpacingAfter = 15f;
            document.Add(date);
        }

        private void AddSaleInfo(Document document, DataRow sale, Font headerFont, Font normalFont)
        {
            PdfPTable infoTable = new PdfPTable(2);
            infoTable.WidthPercentage = 100;
            infoTable.SetWidths(new float[] { 35f, 65f });
            infoTable.SpacingAfter = 15f;

            AddInfoRow(infoTable, "Дата продажи:", Convert.ToDateTime(sale["SaleDate"]).ToString("dd.MM.yyyy"), headerFont, normalFont);
            AddInfoRow(infoTable, "Клиент:", sale["ClientName"].ToString(), headerFont, normalFont);
            AddInfoRow(infoTable, "Оформил:", sale["CreatedByUser"].ToString(), headerFont, normalFont);
            AddInfoRow(infoTable, "Статус:", sale["SaleStatusName"].ToString(), headerFont, normalFont);

            if (sale["CancelReason"] != DBNull.Value && !string.IsNullOrWhiteSpace(sale["CancelReason"].ToString()))
            {
                AddInfoRow(infoTable, "Причина отмены:", sale["CancelReason"].ToString(), headerFont, normalFont);
            }

            document.Add(infoTable);
        }

        private void AddInfoRow(PdfPTable table, string label, string value, Font labelFont, Font valueFont)
        {
            PdfPCell labelCell = new PdfPCell(new Phrase(label, labelFont));
            labelCell.Border = Rectangle.NO_BORDER;
            labelCell.PaddingBottom = 5f;

            PdfPCell valueCell = new PdfPCell(new Phrase(value, valueFont));
            valueCell.Border = Rectangle.NO_BORDER;
            valueCell.PaddingBottom = 5f;

            table.AddCell(labelCell);
            table.AddCell(valueCell);
        }

        private void AddItemsTable(Document document, DataTable itemsTable, Font tableHeaderFont, Font tableFont)
        {
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 8f, 42f, 15f, 15f, 20f });
            table.SpacingAfter = 15f;

            AddHeaderCell(table, "№", tableHeaderFont);
            AddHeaderCell(table, "Товар", tableHeaderFont);
            AddHeaderCell(table, "Кол-во", tableHeaderFont);
            AddHeaderCell(table, "Цена", tableHeaderFont);
            AddHeaderCell(table, "Сумма", tableHeaderFont);

            int number = 1;

            foreach (DataRow row in itemsTable.Rows)
            {
                AddBodyCell(table, number.ToString(), tableFont, Element.ALIGN_CENTER);
                AddBodyCell(table, row["ProductName"].ToString(), tableFont, Element.ALIGN_LEFT);
                AddBodyCell(table, Convert.ToInt32(row["Quantity"]).ToString(), tableFont, Element.ALIGN_CENTER);
                AddBodyCell(table, Convert.ToDecimal(row["UnitPrice"]).ToString("N2"), tableFont, Element.ALIGN_RIGHT);
                AddBodyCell(table, Convert.ToDecimal(row["LineTotal"]).ToString("N2"), tableFont, Element.ALIGN_RIGHT);

                number++;
            }

            document.Add(table);
        }

        private void AddHeaderCell(PdfPTable table, string text, Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Padding = 6f;
            cell.BackgroundColor = new BaseColor(230, 230, 230);
            table.AddCell(cell);
        }

        private void AddBodyCell(PdfPTable table, string text, Font font, int alignment)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = alignment;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Padding = 5f;
            table.AddCell(cell);
        }

        private void AddTotal(Document document, DataRow sale, Font headerFont)
        {
            decimal totalAmount = Convert.ToDecimal(sale["TotalAmount"]);

            Paragraph total = new Paragraph("Итого: " + totalAmount.ToString("N2") + " руб.", headerFont);
            total.Alignment = Element.ALIGN_RIGHT;
            total.SpacingAfter = 25f;

            document.Add(total);
        }

        private void AddFooter(Document document, Font smallFont)
        {
            Paragraph footer = new Paragraph(
                "Документ сформирован автоматически в АИС учета и реализации бытовой химической продукции DomesoSystem.",
                smallFont
            );
            footer.Alignment = Element.ALIGN_CENTER;
            footer.SpacingBefore = 20f;

            document.Add(footer);
        }
    }
}
