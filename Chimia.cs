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
    public partial class Chimia : Form
    {
        public Chimia()
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
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click_1(object sender, EventArgs e)
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

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            if (DgView.SelectedRows.Count > 0)
            {
                // получение выбранной строки
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

        private void deletebtn_Click_1(object sender, EventArgs e)
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            zp form = new zp();
            this.Hide();
            form.Show();
        }

        private void btnzakaz_Click(object sender, EventArgs e)
        {

        }
    }
}
