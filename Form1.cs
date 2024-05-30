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

namespace FinalyDemoEx
{
    public partial class Auth : Form
    {
        DataBase database = new DataBase();

        public Auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PassTB.PasswordChar = '*';
            PassTB.MaxLength = 50;
            LoginTB.MaxLength = 50;
        }

        private void Auth_BTN_Click(object sender, EventArgs e)
        {
            var login = LoginTB.Text;
            var password = PassTB.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string query = $"select ID, Login, Password, Role from logindata where Login = '{login}' and Password = '{password}'";

            SqlCommand command = new SqlCommand(query, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                var checkrole = dataTable.Rows[0][3].ToString();

                MessageBox.Show("Вы успешно вошли!");
                MainForm mainForm = new MainForm(checkrole); 
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка входа!");
            }
        }
    }
}
