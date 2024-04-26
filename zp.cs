using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;


namespace практика
{
    public partial class zp : Form
    {

        public zp()
        {
            InitializeComponent();

            DisplayFrmotchet();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""САГОС"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFrmotchet()
        {
            Con.Open();
            string Query = "Select * from Зарплата";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            // Создаем новый DataTable и заполняем его данными из DataSet
            System.Data.DataTable dataTable = ds.Tables[0];

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
            totalRow["Цена"] = sum; // Присваиваем сумму без форматирования как денежное значение
            dataTable.Rows.Add(totalRow);

            // Обновляем DataSet данными из DataTable
            ds.Tables[0].Merge(dataTable);

            // Присваиваем DataSet к DataSource DataGridView
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void UpdateFilteredDataView(string filter)
        {
            System.Data.DataTable originalDataTable = (dataGridView1.DataSource as System.Data.DataTable);

            // Создаем новый DataTable с примененным фильтром
            DataView filteredView = originalDataTable.DefaultView;
            filteredView.RowFilter = filter;
            System.Data.DataTable filteredDataTable = filteredView.ToTable();

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

            // Обновляем DataGridView с новым DataTable
            dataGridView1.DataSource = filteredDataTable;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Получаем ставку оплаты за услугу из TextBox
            decimal serviceRate = Convert.ToDecimal(textBox4.Text);
            decimal totalSalary = 0;
            // Проходим по каждой строке в DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Пропускаем заголовочную строку
                if (!row.IsNewRow)
                {
                    // Получаем сумму оплаты за услугу из соответствующей ячейки
                    decimal servicePayment = Convert.ToDecimal(row.Cells["Цена"].Value);
                    // Рассчитываем зарплату для сотрудника, умножая ставку на сумму оплаты за услугу
                    decimal salary = serviceRate * servicePayment;
                    // Накапливаем общую сумму зарплаты
                    totalSalary += salary;
                    // Выводим результат расчета зарплаты для каждого сотрудника в DataGridView
                    row.Cells["Зарплата"].Value = salary;
                }
            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // получение выбранной строки
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // получение значений ячеек выбранной строки
            string номерЗаказа = row.Cells["Номер_заказа"].Value.ToString();
            string датареализации = row.Cells["Дата_реализации"].Value.ToString();
            string название = row.Cells["Название"].Value.ToString();
            string цена = row.Cells["Цена"].Value.ToString();

            string Фамилия = row.Cells["Фамилия"].Value.ToString();
            string Зарплата = row.Cells["Зарплата"].Value.ToString();


        }


        private void zp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сАГОСDataSet.Зарплата". При необходимости она может быть перемещена или удалена.
            this.зарплатаTableAdapter.Fill(this.сАГОСDataSet.Зарплата);

        }

        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateFilteredDataView($"Фамилия LIKE '%{textBox1.Text}%'");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            MExcel.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            // Обработка случая, когда значение ячейки равно null
                            MExcel.Cells[i + 2, j + 1] = string.Empty; // Можно присвоить пустую строку или другое значение по умолчанию
                        }
                    }
                }
                MExcel.Range[MExcel.Cells[1, 1], MExcel.Cells[1, dataGridView1.Columns.Count]].Interior.Color = System.Drawing.Color.LightBlue.ToArgb();
                MExcel.Range[MExcel.Cells[1, 1], MExcel.Cells[dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chimia frm=new Chimia();
            this.Hide();
            frm.Show();
        }

        private void btnzakaz_Click(object sender, EventArgs e)
        {
            zakaz form = new zakaz();
            this.Hide();
            form.Show();
        }

        

        private void btnsotr_Click(object sender, EventArgs e)
        {
            Chim form = new Chim();
            this.Hide();
            form.Show();
        }

       

       

       
        private void button5_Click(object sender, EventArgs e)
        {
            zp form = new zp();
            this.Hide();
            form.Show();
        }

        private void btnotch_Click(object sender, EventArgs e)
        {
            otchet form=new otchet();
            this.Hide();
            form.Show();
        }

        private void btnyslyga_Click_1(object sender, EventArgs e)
        {
            Yslyga form = new Yslyga();
            this.Hide();
            form.Show();
        }

        private void btnsotrudniki_Click_1(object sender, EventArgs e)
        {
            sotr form = new sotr();
            this.Hide();
            form.Show();
        }

        private void btngr_Click_1(object sender, EventArgs e)
        {
            gr form = new gr();
            this.Hide();
            form.Show();
        }

        private void btnotchet_Click(object sender, EventArgs e)
        {

        }
    }
}

  