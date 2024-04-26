using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class sotr : Form
    {
        public sotr()
        {
            InitializeComponent();
        }

        
            private void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Сотрудник ORDER BY id_сотрудника DESC", Con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[4];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void sotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сАГОСDataSet2.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.сАГОСDataSet2.Сотрудник);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String sFileName = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(sFileName);
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""САГОС"";Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd;
        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Сотрудник (id_сотрудника, Фамилия, Имя, Отчество, Фото) " +
                "VALUES (@id_сотрудника, @Фамилия, @Имя, @Отчество, @Фото);", Con);
            cmd.Parameters.AddWithValue("@id_сотрудника", nomTb.Text);
            cmd.Parameters.AddWithValue("@Фамилия", faTb.Text);
            cmd.Parameters.AddWithValue("@Имя", IMTB.Text);
            cmd.Parameters.AddWithValue("@Отчество", OtchTb.Text);
            MemoryStream memorystream = new MemoryStream();
            pictureBox1.Image.Save(memorystream, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("@Фото", memorystream.ToArray());
            Con.Open();  cmd.ExecuteNonQuery(); Con.Close();
            MessageBox.Show("Данные успешно добавлены");
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Сотрудник Set Фамилия=@Фамилия, Имя=@Имя, Отчество=@Отчество," +
                " Фото=@Фото Where id_сотрудника=@id_сотрудника", Con);
            cmd.Parameters.AddWithValue("@Фамилия", faTb.Text);
            cmd.Parameters.AddWithValue("@Имя", IMTB.Text);
            cmd.Parameters.AddWithValue("@Отчество", OtchTb.Text);
            MemoryStream memorysteam = new MemoryStream();
            pictureBox1.Image.Save(memorysteam, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("Фото", memorysteam.ToArray()); cmd.Parameters.AddWithValue("id_сотрудника", nomTb.Text);
            Con.Open();cmd.ExecuteNonQuery();
            Con.Close();load_data();
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE  Сотрудник Where id_Сотрудника=@id_Сотрудника", Con);
            cmd.Parameters.AddWithValue("id_Сотрудника", nomTb.Text);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            load_data();
            pictureBox1.Image = null;
            faTb.Text = ""; IMTB.Text = "";
            OtchTb.Text = ""; nomTb.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomTb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            faTb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); IMTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            OtchTb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[4].Value);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void btnzakaz_Click(object sender, EventArgs e)
        {
            zakaz form = new zakaz();
            this.Hide();
            form.Show();
        }

        private void btnyslyga_Click(object sender, EventArgs e)
        {
            Yslyga form = new Yslyga();
            this.Hide();
            form.Show();
        }

        private void btnsotr_Click(object sender, EventArgs e)
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

        private void btngr_Click(object sender, EventArgs e)
        {
            gr form = new gr();
            this.Hide();
            form.Show();
        }

        private void btnzp_Click(object sender, EventArgs e)
        {
            zp form = new zp();
            this.Hide();
            form.Show();
        }

        private void btnotch_Click(object sender, EventArgs e)
        {

        }
    }
}
