using Microsoft.Office.Interop.Word;
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
using Application = Microsoft.Office.Interop.Word.Application;
using Document= Microsoft.Office.Interop.Word.Document;

namespace практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""курсовая работа"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFormMaimMenu()
        {
            Con.Open();
            string Query = "Select*from Заказчик ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputFilePath = $@"{System.Windows.Forms.Application.StartupPath}\Reseipt\ex.docx";
            string outputFilePath = $@"{System.Windows.Forms.Application.StartupPath}\Reseipt\receipt {DateTime.Now.ToString("dd-mm-yyyy hh-mm-ss")}.pdf";

           
            var replacemects = new System.Collections.Generic.Dictionary<string, string>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string key = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                replacemects.Add(key, value);
            }

            if (ReplaceTags(inputFilePath, outputFilePath, replacemects) == true)
            {
                MessageBox.Show("Success.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static bool ReplaceTags(string inputFilePath,string  outputFilePath, System.Collections.Generic.Dictionary<string,string> replacemects)
        {
            Application wordApp = new Application();

            try
            {
                Document doc = wordApp.Documents.Open(inputFilePath, ReadOnly: true);

                Range range = doc.Content;
                Document newDoc = wordApp.Documents.Add();
                range.Copy();
                newDoc.Range().Paste();

                foreach(var replacement in replacemects)
                {
                    newDoc.Content.Find.Execute(FindText: replacement.Key, ReplaceWith: replacement.Value, Replace: WdReplace.wdReplaceAll);
                }

                newDoc.SaveAs2(outputFilePath, WdSaveFormat.wdFormatPDF);
                newDoc.Close(SaveChanges: false);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ошибка:" + ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                wordApp.Quit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // получение выбранной строки
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


            // получение значений ячеек выбранной строки
            string номерЗаказа = row.Cells["Номер_заказа"].Value.ToString();
            string фио = row.Cells["ФИО"].Value.ToString();
            string адрес = row.Cells["Адрес"].Value.ToString();
            string датаРеализации = row.Cells["Дата_реализации"].Value.ToString();
            string номерТелефона = row.Cells["Номер_телефона"].Value.ToString();
            string услуга = row.Cells["Услуга"].Value.ToString();
            string площадь = row.Cells["Площадь"].Value.ToString();
            string комментарий = row.Cells["Комментарий"].Value.ToString();

          
        }
    }
}
