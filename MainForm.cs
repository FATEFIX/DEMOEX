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
using FinalyDemoEx;
using System.Reflection;
using System.Globalization;

namespace FinalyDemoEx
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {

        private readonly string role_user;
        DataBase database = new DataBase();

        int selectedRow;
        public MainForm(string role)
        {
            InitializeComponent();
            role_user = role;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("typeOf", "Тип товара");
            dataGridView1.Columns.Add("countOf", "Количество");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string query = $"select * from items";

            SqlCommand command = new SqlCommand(query, database.getConnection());
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader(); 

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();

           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DeleteBTN.Enabled = Convert.ToBoolean(role_user);
            ChangeBTN.Enabled = Convert.ToBoolean(role_user);
            AddBTN.Enabled = Convert.ToBoolean(role_user);
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void deleteRow(int requestId)
        {
            database.openConnection();
            string query = "DELETE FROM items WHERE ID = @RequestId";
            SqlCommand command = new SqlCommand(query, database.getConnection());
            command.Parameters.AddWithValue("@RequestId", requestId);
            command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int requestId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                deleteRow(requestId);
                RefreshDataGrid(dataGridView1);
                MessageBox.Show("Запись успешно удаленна!");
            }
            else
            {
                MessageBox.Show("Выберите заявку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                ID_TB.Text = row.Cells[0].Value.ToString();
                TYPEOF_TB.Text = row.Cells[1].Value.ToString();
                COUNT_TB.Text = row.Cells[2].Value.ToString();
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewRecord newRecord = new NewRecord();
            newRecord.Show();
        }

        private void search(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();

            string searchString = $"select * from items where concat (id, typeOf, countOf) like '%" + Search_TB.Text +"%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());

            database.openConnection();
            SqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dataGridView1, read);
            }

            read.Close();   
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(dataGridView1);
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            
            var id = ID_TB.Text;
            var type = TYPEOF_TB.Text;
            var count = COUNT_TB.Text;

            if (dataGridView1.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
            {
                if (Convert.ToInt32(id) != 0)
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, type, count);
                    dataGridView1.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Поле ID некорректно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Update()
        {
            database.openConnection();
            
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                int indexx = dataGridView1.CurrentCell.RowIndex;
                var rowState = (RowState)dataGridView1.Rows[indexx].Cells[3].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Modified)
                {
                    var _id = dataGridView1.Rows[indexx].Cells[0].Value.ToString();
                    var _type = dataGridView1.Rows[indexx].Cells[1].Value.ToString();
                    var _count = dataGridView1.Rows[indexx].Cells[2].Value.ToString();

                    var changequery = $"UPDATE items SET typeOf = '{_type}', countOf = '{_count}' WHERE ID = '{_id}' ";

                    var command = new SqlCommand(changequery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            
            database.closeConnection();
            
        }

        private void ChangeBTN_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void ID_TB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Update();
        }
    }
}
