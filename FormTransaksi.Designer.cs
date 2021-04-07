namespace fmTransaksiBarang
{
    partial class FormTransaksi
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
            this.label_Id_Barang = new System.Windows.Forms.Label();
            this.label_Jumlah = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.textBoxIdBarang = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.buttonMulai = new System.Windows.Forms.Button();
            this.buttonSelesai = new System.Windows.Forms.Button();
            this.textBoxBayar = new System.Windows.Forms.TextBox();
            this.buttonBayar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Id_Barang
            // 
            this.label_Id_Barang.AutoSize = true;
            this.label_Id_Barang.Location = new System.Drawing.Point(33, 35);
            this.label_Id_Barang.Name = "label_Id_Barang";
            this.label_Id_Barang.Size = new System.Drawing.Size(51, 13);
            this.label_Id_Barang.TabIndex = 0;
            this.label_Id_Barang.Text = "id barang";
            // 
            // label_Jumlah
            // 
            this.label_Jumlah.AutoSize = true;
            this.label_Jumlah.Location = new System.Drawing.Point(33, 65);
            this.label_Jumlah.Name = "label_Jumlah";
            this.label_Jumlah.Size = new System.Drawing.Size(37, 13);
            this.label_Jumlah.TabIndex = 1;
            this.label_Jumlah.Text = "jumlah";
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(22, 288);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(75, 23);
            this.buttonTambah.TabIndex = 3;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.ButtonSimpan_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(115, 288);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 4;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(208, 288);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 23);
            this.buttonBatal.TabIndex = 5;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // textBoxIdBarang
            // 
            this.textBoxIdBarang.Location = new System.Drawing.Point(90, 35);
            this.textBoxIdBarang.Name = "textBoxIdBarang";
            this.textBoxIdBarang.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdBarang.TabIndex = 1;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(90, 65);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(100, 20);
            this.textBoxJumlah.TabIndex = 2;
            // 
            // dataGridViewTransaksi
            // 
            this.dataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(22, 91);
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(547, 191);
            this.dataGridViewTransaksi.TabIndex = 7;
            this.dataGridViewTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransaksi_CellContentClick);
            // 
            // buttonMulai
            // 
            this.buttonMulai.Location = new System.Drawing.Point(236, 46);
            this.buttonMulai.Name = "buttonMulai";
            this.buttonMulai.Size = new System.Drawing.Size(75, 23);
            this.buttonMulai.TabIndex = 0;
            this.buttonMulai.Text = "Mulai";
            this.buttonMulai.UseVisualStyleBackColor = true;
            this.buttonMulai.Click += new System.EventHandler(this.buttonMulai_Click);
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Location = new System.Drawing.Point(328, 46);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(75, 23);
            this.buttonSelesai.TabIndex = 6;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            this.buttonSelesai.Click += new System.EventHandler(this.buttonSelesai_Click);
            // 
            // textBoxBayar
            // 
            this.textBoxBayar.Location = new System.Drawing.Point(353, 291);
            this.textBoxBayar.Name = "textBoxBayar";
            this.textBoxBayar.Size = new System.Drawing.Size(100, 20);
            this.textBoxBayar.TabIndex = 8;
            // 
            // buttonBayar
            // 
            this.buttonBayar.Location = new System.Drawing.Point(473, 291);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(75, 23);
            this.buttonBayar.TabIndex = 9;
            this.buttonBayar.Text = "Bayar";
            this.buttonBayar.UseVisualStyleBackColor = true;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 323);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.textBoxBayar);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.buttonMulai);
            this.Controls.Add(this.dataGridViewTransaksi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxIdBarang);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label_Jumlah);
            this.Controls.Add(this.label_Id_Barang);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Id_Barang;
        private System.Windows.Forms.Label label_Jumlah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.TextBox textBoxIdBarang;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.DataGridView dataGridViewTransaksi;
        private System.Windows.Forms.Button buttonMulai;
        private System.Windows.Forms.Button buttonSelesai;
        private System.Windows.Forms.TextBox textBoxBayar;
        private System.Windows.Forms.Button buttonBayar;
    }
}