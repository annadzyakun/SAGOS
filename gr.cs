using DGVPrinterHelper;
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
    public partial class gr : Form
    {
        public gr()
        {
            InitializeComponent();
            DisplayFrmgraf();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""САГОС"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFrmgraf()
        {
            Con.Open();
            string Query = "Select*from График ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"CONVERT(Дата_реализации, 'System.String') LIKE '%{textBox2.Text}%'";
        }



        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            var dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("График работы ООО АБСОЛЮТ", dataGridView1);
        }
        private void btnzakaz_Click(object sender, EventArgs e)
        {
            zakaz form= new zakaz();
            this.Hide();
            form.Show();
        }

        private void btngr_Click(object sender, EventArgs e)
        {
            gr gr = new gr();
            this.Hide();
            gr.Show();
        }

        private void btnyslyga_Click(object sender, EventArgs e)
        {
            Yslyga form = new Yslyga();
            this.Hide();
            form.Show();
        }

        private void btnchim_Click(object sender, EventArgs e)
        {
            Chim form = new Chim();
            this.Hide();
            form.Show();
        }

        private void btnsotrudniki_Click(object sender, EventArgs e)
        {
            sotr form = new sotr();
            this.Hide();
            form.Show();
        }

        private void btnotch_Click(object sender, EventArgs e)
        {
            otchet form = new otchet();
            this.Hide();
            form.Show();
        }

        private void btnzp_Click(object sender, EventArgs e)
        {
            zp form = new zp();
            this.Hide();
            form.Show();

        }
    }
}
