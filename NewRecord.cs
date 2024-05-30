using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace FinalyDemoEx
{
    public partial class NewRecord : Form
    {

        DataBase database = new DataBase();
        public NewRecord()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NR_CLOSE_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NR_SAVE_BTN_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var TYPE = NR_TYPEOF_TB.Text;
            var COUNT = NR_COUNT_TB.Text;
            if (Convert.ToInt32(COUNT) != 0)
            {
                var query = $"insert into items (typeOf, CountOf) values ('{TYPE}', '{COUNT}')";

                var sqlCommand = new SqlCommand(query, database.getConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не добавлена", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.closeConnection();
        }
    }
}
