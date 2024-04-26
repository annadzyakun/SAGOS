namespace практика
{
    partial class sotr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sotr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OtchTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IMTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.faTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomTb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сАГОСDataSet2 = new практика.САГОСDataSet2();
            this.btnzp = new System.Windows.Forms.Button();
            this.btnotch = new System.Windows.Forms.Button();
            this.btngr = new System.Windows.Forms.Button();
            this.btnsotrudniki = new System.Windows.Forms.Button();
            this.btnchim = new System.Windows.Forms.Button();
            this.btnyslyga = new System.Windows.Forms.Button();
            this.btnzakaz = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.сотрудникTableAdapter = new практика.САГОСDataSet2TableAdapters.СотрудникTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сАГОСDataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.OtchTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IMTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.faTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nomTb);
            this.panel1.Location = new System.Drawing.Point(187, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 176);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(682, 99);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 23);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Удалить";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(682, 68);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(100, 23);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Изменить";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(682, 39);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 23);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество";
            // 
            // OtchTb
            // 
            this.OtchTb.Location = new System.Drawing.Point(388, 100);
            this.OtchTb.Name = "OtchTb";
            this.OtchTb.Size = new System.Drawing.Size(100, 22);
            this.OtchTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя";
            // 
            // IMTB
            // 
            this.IMTB.Location = new System.Drawing.Point(282, 100);
            this.IMTB.Name = "IMTB";
            this.IMTB.Size = new System.Drawing.Size(100, 22);
            this.IMTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // faTb
            // 
            this.faTb.Location = new System.Drawing.Point(176, 99);
            this.faTb.Name = "faTb";
            this.faTb.Size = new System.Drawing.Size(100, 22);
            this.faTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "id_сотр";
            // 
            // nomTb
            // 
            this.nomTb.Location = new System.Drawing.Point(110, 100);
            this.nomTb.Name = "nomTb";
            this.nomTb.Size = new System.Drawing.Size(50, 22);
            this.nomTb.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idсотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.сотрудникBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 367);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idсотрудникаDataGridViewTextBoxColumn
            // 
            this.idсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.HeaderText = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idсотрудникаDataGridViewTextBoxColumn.Name = "idсотрудникаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.фотоDataGridViewImageColumn.MinimumWidth = 6;
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.сАГОСDataSet2;
            // 
            // сАГОСDataSet2
            // 
            this.сАГОСDataSet2.DataSetName = "САГОСDataSet2";
            this.сАГОСDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnzp
            // 
            this.btnzp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnzp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnzp.FlatAppearance.BorderSize = 0;
            this.btnzp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnzp.ForeColor = System.Drawing.Color.Navy;
            this.btnzp.Image = ((System.Drawing.Image)(resources.GetObject("btnzp.Image")));
            this.btnzp.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnzp.Location = new System.Drawing.Point(0, 357);
            this.btnzp.Name = "btnzp";
            this.btnzp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnzp.Size = new System.Drawing.Size(187, 53);
            this.btnzp.TabIndex = 12;
            this.btnzp.Text = "Зарплата";
            this.btnzp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnzp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnzp.UseVisualStyleBackColor = false;
            this.btnzp.Click += new System.EventHandler(this.btnzp_Click);
            // 
            // btnotch
            // 
            this.btnotch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnotch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnotch.FlatAppearance.BorderSize = 0;
            this.btnotch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnotch.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnotch.ForeColor = System.Drawing.Color.Navy;
            this.btnotch.Image = ((System.Drawing.Image)(resources.GetObject("btnotch.Image")));
            this.btnotch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnotch.Location = new System.Drawing.Point(0, 304);
            this.btnotch.Name = "btnotch";
            this.btnotch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnotch.Size = new System.Drawing.Size(187, 53);
            this.btnotch.TabIndex = 11;
            this.btnotch.Text = "Отчет";
            this.btnotch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnotch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnotch.UseVisualStyleBackColor = false;
            this.btnotch.Click += new System.EventHandler(this.btnotch_Click);
            // 
            // btngr
            // 
            this.btngr.BackColor = System.Drawing.Color.SkyBlue;
            this.btngr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngr.FlatAppearance.BorderSize = 0;
            this.btngr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngr.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btngr.ForeColor = System.Drawing.Color.Navy;
            this.btngr.Image = ((System.Drawing.Image)(resources.GetObject("btngr.Image")));
            this.btngr.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btngr.Location = new System.Drawing.Point(0, 251);
            this.btngr.Name = "btngr";
            this.btngr.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btngr.Size = new System.Drawing.Size(187, 53);
            this.btngr.TabIndex = 10;
            this.btngr.Text = "  График";
            this.btngr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngr.UseVisualStyleBackColor = false;
            this.btngr.Click += new System.EventHandler(this.btngr_Click);
            // 
            // btnsotrudniki
            // 
            this.btnsotrudniki.BackColor = System.Drawing.Color.SkyBlue;
            this.btnsotrudniki.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsotrudniki.FlatAppearance.BorderSize = 0;
            this.btnsotrudniki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsotrudniki.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnsotrudniki.ForeColor = System.Drawing.Color.Navy;
            this.btnsotrudniki.Image = ((System.Drawing.Image)(resources.GetObject("btnsotrudniki.Image")));
            this.btnsotrudniki.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnsotrudniki.Location = new System.Drawing.Point(0, 198);
            this.btnsotrudniki.Name = "btnsotrudniki";
            this.btnsotrudniki.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnsotrudniki.Size = new System.Drawing.Size(187, 53);
            this.btnsotrudniki.TabIndex = 9;
            this.btnsotrudniki.Text = "  Сотрудники";
            this.btnsotrudniki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsotrudniki.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsotrudniki.UseVisualStyleBackColor = false;
            this.btnsotrudniki.Click += new System.EventHandler(this.btnsotrudniki_Click);
            // 
            // btnchim
            // 
            this.btnchim.BackColor = System.Drawing.Color.SkyBlue;
            this.btnchim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnchim.FlatAppearance.BorderSize = 0;
            this.btnchim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchim.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnchim.ForeColor = System.Drawing.Color.Navy;
            this.btnchim.Image = ((System.Drawing.Image)(resources.GetObject("btnchim.Image")));
            this.btnchim.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnchim.Location = new System.Drawing.Point(0, 145);
            this.btnchim.Name = "btnchim";
            this.btnchim.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnchim.Size = new System.Drawing.Size(187, 53);
            this.btnchim.TabIndex = 8;
            this.btnchim.Text = "  Химия";
            this.btnchim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnchim.UseVisualStyleBackColor = false;
            this.btnchim.Click += new System.EventHandler(this.btnsotr_Click);
            // 
            // btnyslyga
            // 
            this.btnyslyga.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyslyga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnyslyga.FlatAppearance.BorderSize = 0;
            this.btnyslyga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyslyga.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnyslyga.ForeColor = System.Drawing.Color.Navy;
            this.btnyslyga.Image = ((System.Drawing.Image)(resources.GetObject("btnyslyga.Image")));
            this.btnyslyga.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnyslyga.Location = new System.Drawing.Point(0, 92);
            this.btnyslyga.Name = "btnyslyga";
            this.btnyslyga.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnyslyga.Size = new System.Drawing.Size(187, 53);
            this.btnyslyga.TabIndex = 7;
            this.btnyslyga.Text = "  Услуга";
            this.btnyslyga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyslyga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnyslyga.UseVisualStyleBackColor = false;
            this.btnyslyga.Click += new System.EventHandler(this.btnyslyga_Click);
            // 
            // btnzakaz
            // 
            this.btnzakaz.BackColor = System.Drawing.Color.SkyBlue;
            this.btnzakaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnzakaz.FlatAppearance.BorderSize = 0;
            this.btnzakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzakaz.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnzakaz.ForeColor = System.Drawing.Color.Navy;
            this.btnzakaz.Image = ((System.Drawing.Image)(resources.GetObject("btnzakaz.Image")));
            this.btnzakaz.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnzakaz.Location = new System.Drawing.Point(0, 39);
            this.btnzakaz.Name = "btnzakaz";
            this.btnzakaz.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnzakaz.Size = new System.Drawing.Size(187, 53);
            this.btnzakaz.TabIndex = 6;
            this.btnzakaz.Text = "  Заказчик";
            this.btnzakaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnzakaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnzakaz.UseVisualStyleBackColor = false;
            this.btnzakaz.Click += new System.EventHandler(this.btnzakaz_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(187, 39);
            this.panelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(187, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 39);
            this.panel2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(357, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "ООО \"САГОС\"";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.btnzp);
            this.panelMenu.Controls.Add(this.btnotch);
            this.panelMenu.Controls.Add(this.btngr);
            this.panelMenu.Controls.Add(this.btnsotrudniki);
            this.panelMenu.Controls.Add(this.btnchim);
            this.panelMenu.Controls.Add(this.btnyslyga);
            this.panelMenu.Controls.Add(this.btnzakaz);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(187, 581);
            this.panelMenu.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(187, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sotr";
            this.Load += new System.EventHandler(this.sotr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сАГОСDataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OtchTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IMTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox faTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomTb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnzp;
        private System.Windows.Forms.Button btnotch;
        private System.Windows.Forms.Button btngr;
        private System.Windows.Forms.Button btnsotrudniki;
        private System.Windows.Forms.Button btnchim;
        private System.Windows.Forms.Button btnyslyga;
        private System.Windows.Forms.Button btnzakaz;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private САГОСDataSet2 сАГОСDataSet2;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private САГОСDataSet2TableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
    }
}