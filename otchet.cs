using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace практика
{
    public partial class otchet : Form
    {
        public otchet()
        {
            InitializeComponent();
            DisplayFrmotchet();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""САГОС"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFrmotchet()
        {
            Con.Open();
            string Query = "Select * from Отчет";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); 
            sda.Fill(ds);
            DataTable dataTable = ds.Tables[0];
            // Вычисляем сумму значений в колонке "Цена"
            decimal sum = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                decimal price;
                if (decimal.TryParse(row["Цена"].ToString(), out price))
                {
                    sum += price;
                }
                else
                {
                    Console.WriteLine("Ошибка при парсинге цены: " + row["Цена"].ToString());
                }
            }
            // Добавляем новую строку "Итого" в DataTable
            DataRow totalRow = dataTable.NewRow();
            totalRow["Название"] = "Итого"; 
            totalRow["Цена"] = sum; 
            dataTable.Rows.Add(totalRow);
            ds.Tables[0].Merge(dataTable);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void UpdateFilteredDataView(string filter)
        {
            DataTable originalDataTable = (dataGridView1.DataSource as DataTable);
            DataView filteredView = originalDataTable.DefaultView;
            filteredView.RowFilter = filter;
            DataTable filteredDataTable = filteredView.ToTable();
            // Добавляем строку "Итого" в новый DataTable
            DataRow totalRow = filteredDataTable.NewRow();
            totalRow["Название"] = "Итого";
            // Пересчитываем сумму значений в колонке "Цена" для отфильтрованных данных
            decimal sum = 0;
            foreach (DataRow row in filteredDataTable.Rows)
            {
                decimal price;
                if (decimal.TryParse(row["Цена"].ToString(), out price))
                {
                    sum += price;
                }
            }
            totalRow["Цена"] = sum;
            filteredDataTable.Rows.Add(totalRow);
            dataGridView1.DataSource = filteredDataTable;
        }






        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateFilteredDataView($"Фамилия LIKE '%{textBox1.Text}%'");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateFilteredDataView($"CONVERT(Дата_реализации, 'System.String') LIKE '%{textBox2.Text}%'");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView filteredView = (dataGridView1.DataSource as DataTable).DefaultView;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    filteredView.RowFilter = $"Цена <=2000";
                    break;
                case 1:
                    filteredView.RowFilter = $"Цена >=2000 AND Цена <=10000";
                    break;
                case 2:
                    filteredView.RowFilter = $"Цена >=10000";
                    break;
                case 3:
                    filteredView.RowFilter = "";
                    break;
            }
            DataTable filteredDataTable = filteredView.ToTable();
            // Добавляем строку "Итого" в новый DataTable 
            DataRow totalRow = filteredDataTable.NewRow();
            totalRow["Название"] = "Итого";
            // Пересчитываем сумму значений в колонке "Цена" для отфильтрованных данных 
            decimal sum = 0;
            foreach (DataRow row in filteredDataTable.Rows)
            {
                decimal price;
                if (decimal.TryParse(row["Цена"].ToString(), out price))
                {
                    sum += price;
                }
            }
            totalRow["Цена"] = sum;
            filteredDataTable.Rows.Add(totalRow);       
            dataGridView1.DataSource = filteredDataTable;
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            var dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Отчет по работе компании ООО АБСОЛЮТ", dataGridView1);
        }
    }
}
