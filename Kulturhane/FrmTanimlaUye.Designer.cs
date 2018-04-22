namespace Kulturhane
{
    partial class FrmTanimlaUye
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
            this.cmbUyeTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colUyeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUyeTipi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUyeAktifMi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUyeTar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFotograf = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbUyeTipi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAdi);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnResimSec);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 114);
            this.panel1.TabIndex = 0;
            // 
            // cmbUyeTipi
            // 
            this.cmbUyeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyeTipi.FormattingEnabled = true;
            this.cmbUyeTipi.Items.AddRange(new object[] {
            "Dernek",
            "Kültürhane"});
            this.cmbUyeTipi.Location = new System.Drawing.Point(86, 54);
            this.cmbUyeTipi.Name = "cmbUyeTipi";
            this.cmbUyeTipi.Size = new System.Drawing.Size(185, 21);
            this.cmbUyeTipi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Üye Tipi";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(86, 6);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(185, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(86, 30);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 20);
            this.txtTel.TabIndex = 1;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(391, 88);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(277, 88);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(108, 23);
            this.btnResimSec.TabIndex = 4;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(277, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(86, 79);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(185, 33);
            this.txtAdres.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı Soyadı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUyeID,
            this.colAdiSoyadi,
            this.colTel,
            this.colUyeTipi,
            this.colAdres,
            this.colUyeAktifMi,
            this.colUyeTar,
            this.colFotograf});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 483);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.resmiSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // resmiSilToolStripMenuItem
            // 
            this.resmiSilToolStripMenuItem.Name = "resmiSilToolStripMenuItem";
            this.resmiSilToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.resmiSilToolStripMenuItem.Text = "Resmi Sil";
            this.resmiSilToolStripMenuItem.Click += new System.EventHandler(this.resmiSilToolStripMenuItem_Click);
            // 
            // colUyeID
            // 
            this.colUyeID.HeaderText = "colUyeID";
            this.colUyeID.Name = "colUyeID";
            this.colUyeID.Visible = false;
            // 
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.HeaderText = "Adı Soyadı";
            this.colAdiSoyadi.Name = "colAdiSoyadi";
            this.colAdiSoyadi.Width = 150;
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Telefon";
            this.colTel.Name = "colTel";
            // 
            // colUyeTipi
            // 
            this.colUyeTipi.HeaderText = "Üye Tipi";
            this.colUyeTipi.Items.AddRange(new object[] {
            "Dernek",
            "Kültürhane"});
            this.colUyeTipi.Name = "colUyeTipi";
            // 
            // colAdres
            // 
            this.colAdres.HeaderText = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Width = 300;
            // 
            // colUyeAktifMi
            // 
            this.colUyeAktifMi.HeaderText = "Aktif Mi";
            this.colUyeAktifMi.Name = "colUyeAktifMi";
            // 
            // colUyeTar
            // 
            this.colUyeTar.HeaderText = "Üyelik Tarihi";
            this.colUyeTar.Name = "colUyeTar";
            this.colUyeTar.ReadOnly = true;
            this.colUyeTar.Width = 150;
            // 
            // colFotograf
            // 
            this.colFotograf.HeaderText = "Resim";
            this.colFotograf.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colFotograf.Name = "colFotograf";
            // 
            // FrmTanimlaUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 597);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTanimlaUye";
            this.Text = "Üye Tanımla";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.ComboBox cmbUyeTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem resmiSilToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUyeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUyeTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdres;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUyeAktifMi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUyeTar;
        private System.Windows.Forms.DataGridViewImageColumn colFotograf;
    }
}