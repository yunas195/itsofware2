namespace fmTransaksiBarang
{
    partial class FormBarang
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
            this.labelid = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelStok = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(12, 34);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(15, 13);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "id";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(12, 61);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(12, 87);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(36, 13);
            this.labelHarga.TabIndex = 2;
            this.labelHarga.Text = "Harga";
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Location = new System.Drawing.Point(12, 113);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(29, 13);
            this.labelStok.TabIndex = 3;
            this.labelStok.Text = "Stok";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(76, 31);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 0;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(76, 61);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 1;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(76, 87);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarga.TabIndex = 2;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(76, 113);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(100, 20);
            this.textBoxStok.TabIndex = 3;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(15, 182);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(75, 23);
            this.buttonTambah.TabIndex = 8;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Location = new System.Drawing.Point(15, 211);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(75, 23);
            this.buttonUbah.TabIndex = 9;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(15, 240);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 10;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(15, 269);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 23);
            this.buttonBatal.TabIndex = 11;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(203, 31);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.Size = new System.Drawing.Size(524, 280);
            this.dataGridViewBarang.TabIndex = 12;
            this.dataGridViewBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 351);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.textBoxStok);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.labelStok);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelid);
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}