namespace Kulturhane
{
    partial class FrmEmanetKitapVer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTanimlaUye = new System.Windows.Forms.Button();
            this.dateVermeTar = new System.Windows.Forms.DateTimePicker();
            this.dateAlmaTar = new System.Windows.Forms.DateTimePicker();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.cmbUye = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimEdildiOlarakİşaretleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTanimlaUye);
            this.panel1.Controls.Add(this.dateVermeTar);
            this.panel1.Controls.Add(this.dateAlmaTar);
            this.panel1.Controls.Add(this.cmbKitap);
            this.panel1.Controls.Add(this.cmbUye);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnTanimlaUye
            // 
            this.btnTanimlaUye.Location = new System.Drawing.Point(204, 5);
            this.btnTanimlaUye.Name = "btnTanimlaUye";
            this.btnTanimlaUye.Size = new System.Drawing.Size(25, 23);
            this.btnTanimlaUye.TabIndex = 1;
            this.btnTanimlaUye.Text = "+";
            this.btnTanimlaUye.UseVisualStyleBackColor = true;
            this.btnTanimlaUye.Click += new System.EventHandler(this.btnTanimlaUye_Click);
            // 
            // dateVermeTar
            // 
            this.dateVermeTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVermeTar.Location = new System.Drawing.Point(309, 34);
            this.dateVermeTar.Name = "dateVermeTar";
            this.dateVermeTar.Size = new System.Drawing.Size(132, 20);
            this.dateVermeTar.TabIndex = 4;
            // 
            // dateAlmaTar
            // 
            this.dateAlmaTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAlmaTar.Location = new System.Drawing.Point(309, 8);
            this.dateAlmaTar.Name = "dateAlmaTar";
            this.dateAlmaTar.Size = new System.Drawing.Size(132, 20);
            this.dateAlmaTar.TabIndex = 3;
            // 
            // cmbKitap
            // 
            this.cmbKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(44, 31);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(185, 21);
            this.cmbKitap.TabIndex = 2;
            // 
            // cmbUye
            // 
            this.cmbUye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUye.FormattingEnabled = true;
            this.cmbUye.Location = new System.Drawing.Point(44, 6);
            this.cmbUye.Name = "cmbUye";
            this.cmbUye.Size = new System.Drawing.Size(157, 21);
            this.cmbUye.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Alma Tarihi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(447, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vereceği Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 368);
            this.dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.teslimEdildiOlarakİşaretleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 70);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // teslimEdildiOlarakİşaretleToolStripMenuItem
            // 
            this.teslimEdildiOlarakİşaretleToolStripMenuItem.Name = "teslimEdildiOlarakİşaretleToolStripMenuItem";
            this.teslimEdildiOlarakİşaretleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.teslimEdildiOlarakİşaretleToolStripMenuItem.Text = "Teslim Edildi Olarak İşaretle";
            this.teslimEdildiOlarakİşaretleToolStripMenuItem.Click += new System.EventHandler(this.teslimEdildiOlarakİşaretleToolStripMenuItem_Click);
            // 
            // FrmEmanetKitapVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmanetKitapVer";
            this.Text = "Emanet Kitap Ver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbUye;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateVermeTar;
        private System.Windows.Forms.DateTimePicker dateAlmaTar;
        private System.Windows.Forms.Button btnTanimlaUye;
        private System.Windows.Forms.ToolStripMenuItem teslimEdildiOlarakİşaretleToolStripMenuItem;
    }
}