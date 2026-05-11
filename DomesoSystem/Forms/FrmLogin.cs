using DomesoSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomesoSystem.Models;

namespace DomesoSystem.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private bool TryLogin(string login, string password)
        {
            string query = @"
        SELECT UserId, Login, FullName, UserRole
        FROM dbo.Users
        WHERE Login = @Login
          AND Password = @Password
          AND IsActive = 1";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@Login", SqlDbType.NVarChar, 50).Value = login;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = password;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CurrentUser.UserId = Convert.ToInt32(reader["UserId"]);
                        CurrentUser.Login = reader["Login"].ToString();
                        CurrentUser.FullName = reader["FullName"].ToString();
                        CurrentUser.UserRole = reader["UserRole"].ToString();

                        return true;
                    }
                }
            }

            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DbConnectionFactory.CreateConnection())
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось подключиться к базе данных.\n\n" + ex.Message,
                    "Ошибка подключения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show(
                    "Введите логин.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Введите пароль.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();
                return;
            }

            try
            {
                bool isSuccess = TryLogin(login, password);

                if (!isSuccess)
                {
                    MessageBox.Show(
                        "Неверный логин или пароль.",
                        "Ошибка авторизации",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                FrmMain mainForm = new FrmMain();
                mainForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при входе в систему.\n\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
    
}
