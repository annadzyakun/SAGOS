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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;


namespace практика
{
    public partial class Chim : Form
    {
        public Chim()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""САГОС"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFrmyslyga()
        {
            Con.Open();
            string query = "Select*From Материалы ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            DgView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtcol.Text == "")
            {
                MessageBox.Show("введите данные");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Материалы (id_химии,Химия, количество_материала) values(@EN, @EF,@EA) ", Con);
                    cmd.Parameters.AddWithValue("@EN", txtid.Text);
                    cmd.Parameters.AddWithValue("@EF", txtname.Text);
                    cmd.Parameters.AddWithValue("@EA", txtcol.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Материалы добавлены");
                    Con.Close();
                    DisplayFrmyslyga();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DgView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgView.SelectedRows[0];
                string id_химии = row.Cells["id_химии"].Value.ToString();
                string Химия = row.Cells["Химия"].Value.ToString();
                string количество = row.Cells["количество_материала"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Выберите услугу для обновления");
            }
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtid.Text))
                {
                    MessageBox.Show("Введите номер услуги");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("delete from Услуга where id_химии=@EN", Con);
                        cmd.Parameters.AddWithValue("@EN", txtid.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Услуга удалена");
                        Con.Close();

                        DisplayFrmyslyga();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DgView.Columns["количество_материала"].Index && e.Value != null)
            {
                int количество;
                if (int.TryParse(e.Value.ToString(), out количество) && количество < 100000)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }
        private void DgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DgView.CellFormatting += dataGridView1_CellFormatting;
        }

        private void btnzakaz_Click(object sender, EventArgs e)
        {
            zakaz form = new zakaz();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yslyga form = new Yslyga();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chim form = new Chim();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sotr form = new sotr();
            this.Hide();
            form.Show();
        }

        private void btnotchet_Click(object sender, EventArgs e)
        {
            gr form = new gr();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otchet form = new otchet();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zp form = new zp();
            this.Hide();
            form.Show();
        }
    }
}
