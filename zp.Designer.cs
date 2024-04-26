namespace практика
{
    partial class zp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zp));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnzp = new System.Windows.Forms.Button();
            this.btnotchet = new System.Windows.Forms.Button();
            this.btngr = new System.Windows.Forms.Button();
            this.btnsotrudniki = new System.Windows.Forms.Button();
            this.btnchim = new System.Windows.Forms.Button();
            this.btnyslyga = new System.Windows.Forms.Button();
            this.btnzakaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сАГОСDataSet = new практика.САГОСDataSet();
            this.зарплатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зарплатаTableAdapter = new практика.САГОСDataSetTableAdapters.ЗарплатаTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTitlebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сАГОСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зарплатаBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitlebar.Controls.Add(this.lblTitle);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(187, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(867, 39);
            this.panelTitlebar.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(352, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ООО \"САГОС\"";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.btnzp);
            this.panelMenu.Controls.Add(this.btnotchet);
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
            this.panelMenu.TabIndex = 12;
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
            this.btnzp.TabIndex = 19;
            this.btnzp.Text = "Зарплата";
            this.btnzp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnzp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnzp.UseVisualStyleBackColor = false;
            this.btnzp.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnotchet
            // 
            this.btnotchet.BackColor = System.Drawing.Color.SkyBlue;
            this.btnotchet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnotchet.FlatAppearance.BorderSize = 0;
            this.btnotchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnotchet.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnotchet.ForeColor = System.Drawing.Color.Navy;
            this.btnotchet.Image = ((System.Drawing.Image)(resources.GetObject("btnotchet.Image")));
            this.btnotchet.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnotchet.Location = new System.Drawing.Point(0, 304);
            this.btnotchet.Name = "btnotchet";
            this.btnotchet.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnotchet.Size = new System.Drawing.Size(187, 53);
            this.btnotchet.TabIndex = 17;
            this.btnotchet.Text = "Отчет";
            this.btnotchet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnotchet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnotchet.UseVisualStyleBackColor = false;
            this.btnotchet.Click += new System.EventHandler(this.btnotchet_Click);
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
            this.btngr.TabIndex = 16;
            this.btngr.Text = "  График";
            this.btngr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngr.UseVisualStyleBackColor = false;
            this.btngr.Click += new System.EventHandler(this.btngr_Click_1);
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
            this.btnsotrudniki.TabIndex = 15;
            this.btnsotrudniki.Text = "  Сотрудники";
            this.btnsotrudniki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsotrudniki.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsotrudniki.UseVisualStyleBackColor = false;
            this.btnsotrudniki.Click += new System.EventHandler(this.btnsotrudniki_Click_1);
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
            this.btnchim.TabIndex = 14;
            this.btnchim.Text = "  Химия";
            this.btnchim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnchim.UseVisualStyleBackColor = false;
            this.btnchim.Click += new System.EventHandler(this.button3_Click);
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
            this.btnyslyga.TabIndex = 13;
            this.btnyslyga.Text = "  Услуга";
            this.btnyslyga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyslyga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnyslyga.UseVisualStyleBackColor = false;
            this.btnyslyga.Click += new System.EventHandler(this.btnyslyga_Click_1);
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
            this.btnzakaz.TabIndex = 12;
            this.btnzakaz.Text = "  Заказчик";
            this.btnzakaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnzakaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnzakaz.UseVisualStyleBackColor = false;
            this.btnzakaz.Click += new System.EventHandler(this.btnzakaz_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Location = new System.Drawing.Point(187, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 198);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Location = new System.Drawing.Point(816, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 46);
            this.button7.TabIndex = 27;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SpringGreen;
            this.button6.Location = new System.Drawing.Point(589, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 35);
            this.button6.TabIndex = 26;
            this.button6.Text = "посмотреть статистику";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "по сотруднику:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(161, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Сделать расчет";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 22);
            this.textBox4.TabIndex = 20;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Yellow;
            this.btnCalculate.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCalculate.Location = new System.Drawing.Point(371, 90);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(212, 35);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Рассичтать зарплату";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 366);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // сАГОСDataSet
            // 
            this.сАГОСDataSet.DataSetName = "САГОСDataSet";
            this.сАГОСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // зарплатаBindingSource
            // 
            this.зарплатаBindingSource.DataMember = "Зарплата";
            this.зарплатаBindingSource.DataSource = this.сАГОСDataSet;
            // 
            // зарплатаTableAdapter
            // 
            this.зарплатаTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "ставки";
            // 
            // zp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 581);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "zp";
            this.Text = "zp";
            this.Load += new System.EventHandler(this.zp_Load);
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сАГОСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зарплатаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnotchet;
        private System.Windows.Forms.Button btngr;
        private System.Windows.Forms.Button btnsotrudniki;
        private System.Windows.Forms.Button btnchim;
        private System.Windows.Forms.Button btnyslyga;
        private System.Windows.Forms.Button btnzakaz;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private САГОСDataSet сАГОСDataSet;
        private System.Windows.Forms.BindingSource зарплатаBindingSource;
        private САГОСDataSetTableAdapters.ЗарплатаTableAdapter зарплатаTableAdapter;
        private System.Windows.Forms.Button btnzp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
    }
}