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
    public partial class Yslyga : Form
    {
        public Yslyga()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""САГОС"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFrmyslyga()
        {
            Con.Open();
            string query = "Select*From Услуги ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            DgView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nomTb.Text == "" || txtname.Text == "" || txtmat.Text == "" || txthim.Text == "" || txtobor.Text == "" || txtcen.Text == ""
                || textid.Text == "" || textcol.Text == "")
            {
                MessageBox.Show("введите данные");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Услуги (Услуга_id,Название, Материалы,Химия, количество, id_химии,Оборудование,Цена)" +
                        " values(@EN, @EF,@EA, @ENt, @EI, @EC,@EP,@EK) ", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.Parameters.AddWithValue("@EF", txtname.Text);
                    cmd.Parameters.AddWithValue("@EA", txtmat.Text);
                    cmd.Parameters.AddWithValue("@ENt", txthim.Text);
                    cmd.Parameters.AddWithValue("@EI", textid.Text);
                    cmd.Parameters.AddWithValue("@EC", textcol.Text);
                    cmd.Parameters.AddWithValue("@EP", txtobor.Text);
                    cmd.Parameters.AddWithValue("@EK", txtcen.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Услуга добавлена");
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
                string номер = row.Cells["Услуга_id"].Value.ToString();
                string название = row.Cells["Название"].Value.ToString();
                string материалы = row.Cells["Материалы"].Value.ToString();
                string химия = row.Cells["Химия"].Value.ToString();
                string количество = row.Cells["количество"].Value.ToString();
                string id = row.Cells["id_химии"].Value.ToString();             
                string оборудование = row.Cells["Оборудование"].Value.ToString();
                string цена = row.Cells["Цена"].Value.ToString();
                nomTb.Text = номер; txtname.Text = название;
                txtmat.Text = материалы; txthim.Text = химия;
                txtobor.Text = оборудование;txtcen.Text = цена;
            }
            else
            {
                MessageBox.Show("Выберите услугу для обновления");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(nomTb.Text))
                {
                    MessageBox.Show("Введите номер услуги");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("delete from Услуга where Услуга_id=@EN", Con);
                        cmd.Parameters.AddWithValue("@EN", nomTb.Text);
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Yslyga_Load(object sender, EventArgs e)
        {

        }

        private void btnsotr_Click(object sender, EventArgs e)
        {
            Chim frm=new Chim();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zp form = new zp();
            this.Hide();
            form.Show();
        }

        private void btnyslyga_Click(object sender, EventArgs e)
        {
            Yslyga yslyga= new Yslyga();
            this.Hide();
            yslyga.Show();
        }

        private void btngraf_Click(object sender, EventArgs e)
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

        private void btnzakaz_Click(object sender, EventArgs e)
        {
            zakaz zakaz= new zakaz();   
            this.Hide();
            zakaz.Show();
        }
    }
}
      