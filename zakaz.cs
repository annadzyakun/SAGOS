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

namespace практика
{
    public partial class zakaz : Form
    {
        public zakaz()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""курсовая работа"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFormMaimMenu()
        {
            Con.Open();
            string Query = "Select*from Заказчик ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);var ds = new DataSet();  sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            nomTb.Text = "";  ФИОTb.Text = "";   АдресTB.Text = "";Дата_реализацииTb.Text = "";  Номер_телефонаTb.Text = "";   УслугаCb.SelectedIndex = -1; ПлощадьTb.Text = "";Комментарийtb.Text = "";
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nomTb.Text == "" || ФИОTb.Text == "" || АдресTB.Text == "" || Номер_телефонаTb.Text == "" || УслугаCb.SelectedIndex == -1 || ПлощадьTb.Text == "" || Комментарийtb.Text == "")
            {
                MessageBox.Show("введите данные");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Заказчик (Номер_заказа, ФИО, Адрес,Дата_реализации,Номер_телефона,Услуга, Площадь,Комментарий) values(@EN, @EF,@EA,@ED, @ENt,@EY,@EP,@EK) ", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.Parameters.AddWithValue("@EF", ФИОTb.Text);
                    cmd.Parameters.AddWithValue("@EA", АдресTB.Text);
                    cmd.Parameters.AddWithValue("@ED", Дата_реализацииTb.Value.Date);
                    cmd.Parameters.AddWithValue("@ENt", Номер_телефонаTb.Text);
                    cmd.Parameters.AddWithValue("@EY", УслугаCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EP", ПлощадьTb.Text);
                    cmd.Parameters.AddWithValue("@EK", Комментарийtb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заказчик добавлен");
                    Con.Close();
                    DisplayFormMaimMenu(); Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string номерЗаказа = row.Cells["Номер_заказа"].Value.ToString();
                string фио = row.Cells["ФИО"].Value.ToString();
                string адрес = row.Cells["Адрес"].Value.ToString();
                string датаРеализации = row.Cells["Дата_реализации"].Value.ToString();
                string номерТелефона = row.Cells["Номер_телефона"].Value.ToString();
                string услуга = row.Cells["Услуга"].Value.ToString();
                string площадь = row.Cells["Площадь"].Value.ToString();
                string комментарий = row.Cells["Комментарий"].Value.ToString();
                nomTb.Text = номерЗаказа;
                ФИОTb.Text = фио;
                АдресTB.Text = адрес;
                Дата_реализацииTb.Text = датаРеализации;
                Номер_телефонаTb.Text = номерТелефона;
                УслугаCb.SelectedItem = услуга;
                ПлощадьTb.Text = площадь;
                Комментарийtb.Text = комментарий;
            }
            else
            {
                MessageBox.Show("Выберите заказчика для обновления");
            }
        }
        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomTb.Text))
            {
                MessageBox.Show("Введите номер заказа");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Заказчик where Номер_заказа=@EN", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заказчик удален");
                    Con.Close();   Clear();
                    DisplayFormMaimMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

            nomTb.Text = номерЗаказа;
            ФИОTb.Text = фио;
            АдресTB.Text = адрес;
            Дата_реализацииTb.Text = датаРеализации;
            Номер_телефонаTb.Text = номерТелефона;
            УслугаCb.SelectedItem = услуга;
            ПлощадьTb.Text = площадь;
            Комментарийtb.Text = комментарий;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            zp form = new zp();
            this.Hide();
            form.Show();
        }

        private void btnsotr_Click(object sender, EventArgs e)
        {
            Chim form = new Chim();
            this.Hide();
            form.Show();
        }

        private void btnyslyga_Click(object sender, EventArgs e)
        {
            Yslyga frm = new Yslyga();
            this.Hide();
            frm.Show();
        }

        private void btngraf_Click(object sender, EventArgs e)
        {
            sotr sotr = new sotr();
            this.Hide();
            sotr.Show();
        }

        private void btngr_Click(object sender, EventArgs e)
        {
            gr gr = new gr();
            this.Hide();
            gr.Show();
        }

        private void btnotch_Click(object sender, EventArgs e)
        {
            otchet otchet = new otchet();
            this.Hide();
            otchet.Show();
        }

        private void btnzakaz_Click(object sender, EventArgs e)
        {
            zakaz form = new zakaz();
            this.Hide();
            form.Show();
        }


    }
}





