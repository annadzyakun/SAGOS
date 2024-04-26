namespace практика
{
    partial class gr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gr));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnzp = new System.Windows.Forms.Button();
            this.btnotch = new System.Windows.Forms.Button();
            this.btngr = new System.Windows.Forms.Button();
            this.btnsotrudniki = new System.Windows.Forms.Button();
            this.btnchim = new System.Windows.Forms.Button();
            this.btnyslyga = new System.Windows.Forms.Button();
            this.btnzakaz = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnCreateReport);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(187, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 159);
            this.panel2.TabIndex = 15;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(535, 83);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(75, 23);
            this.btnCreateReport.TabIndex = 3;
            this.btnCreateReport.Text = "Печать";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Поиск по дате:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 383);
            this.dataGridView1.TabIndex = 14;
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
            this.btnchim.Click += new System.EventHandler(this.btnchim_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(187, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 39);
            this.panel1.TabIndex = 17;
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
            this.panelMenu.TabIndex = 16;
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
            // gr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gr";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnzp;
        private System.Windows.Forms.Button btnotch;
        private System.Windows.Forms.Button btngr;
        private System.Windows.Forms.Button btnsotrudniki;
        private System.Windows.Forms.Button btnchim;
        private System.Windows.Forms.Button btnyslyga;
        private System.Windows.Forms.Button btnzakaz;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}