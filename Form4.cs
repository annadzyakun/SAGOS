using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExcelDataReader;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace практика
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""САГОС"";Integrated Security=True;Connect Timeout=30;");

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сАГОСDataSet1.Зарплата". При необходимости она может быть перемещена или удалена.
            this.зарплатаTableAdapter.Fill(this.сАГОСDataSet1.Зарплата);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateChart2(gridd, "Зарплата", "Зарплата");
        }
        private void CreateChart2(DataGridView grid, string nameTitle, string seriesName)
        {
            try
            {
                chart.Series.Clear();
                chart.Series.Add(seriesName);

                for (int i = 0; i < grid.RowCount; i++)
                {
                    var name = gridd.Rows[i].Cells[4].Value?.ToString() ?? "";
                    var value = gridd.Rows[i].Cells[5].Value?.ToString() ?? "";
                    chart.Series[seriesName].Points.AddXY(name, value);
                }
                chart.Titles.Clear();
                chart.Titles.Add(nameTitle);
                chart.ChartAreas[0].AxisX.Title = grid.Columns[4].HeaderText;
                chart.ChartAreas[0].AxisY.Title = grid.Columns[5].HeaderText;
                MessageBox.Show("График сформирован", "Успех");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ошибка: Недостаточно столбцов в DataGridView", "Ошибка");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: недопустимые данные в DataGridView", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series[0].ChartType = SeriesChartType.Column;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series[0].ChartType = SeriesChartType.Bar;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series[0].ChartType = SeriesChartType.Pie;
        }
        public void UpdateData(DataGridViewRowCollection rows)
        {


        }
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // получение выбранной строки
            DataGridViewRow row = gridd.Rows[e.RowIndex];

            // получение значений ячеек выбранной строки
            string номерЗаказа = row.Cells["Номер_заказа"].Value.ToString();
            string датареализации = row.Cells["Дата_реализации"].Value.ToString();
            string название = row.Cells["Название"].Value.ToString();
            string цена = row.Cells["Цена"].Value.ToString();

            string Фамилия = row.Cells["Фамилия"].Value.ToString();
            string Зарплата = row.Cells["Зарплата"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Select an Excel File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.ActiveSheet; // Явное приведение типа

                Excel.Range range = excelWorksheet.UsedRange;
                int rowCount = range.Rows.Count;
                int columnCount = range.Columns.Count;

                for (int col = 1; col <= columnCount; col++)
                {
                    gridd.Columns.Add("", ""); // Добавление пустого столбца
                }
                // Добавление строк
                for (int row = 1; row <= rowCount; row++)
                {
                    gridd.Rows.Add(); // Добавление строки

                    for (int col = 1; col <= columnCount; col++)
                    {
                        // Явное приведение типа к Excel.Range и получение значения ячейки
                        gridd.Rows[row - 1].Cells[col - 1].Value = (range.Cells[row, col] as Excel.Range)?.Value;
                    }
                }
            }
        }

    }
}
    