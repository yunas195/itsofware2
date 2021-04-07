using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmTransaksiBarang
{
    public partial class FormTransaksi : Form
    {
        string idpembelian;
        public FormTransaksi()
        {
            InitializeComponent();
        }
        void clearInput()
        {
            textBoxIdBarang.Clear();
            textBoxJumlah.Clear();
        }

        void startInput()
        {
            buttonMulai.Enabled = false;
            buttonSelesai.Enabled = true;
            textBoxIdBarang.Enabled = true;
            textBoxJumlah.Enabled = true;
            buttonTambah.Enabled = true;
            dataGridViewTransaksi.Enabled = true;

        }
        void endInput()
        {
            buttonMulai.Enabled = true;
            buttonSelesai.Enabled = false;
            textBoxIdBarang.Enabled = false;
            textBoxJumlah.Enabled = false;
            buttonTambah.Enabled = false;
            dataGridViewTransaksi.Enabled = false;
            textBoxBayar.Enabled = false;
            buttonBayar.Enabled = false;
            label_Jumlah.Text = string.Empty;
            label_Id_Barang.Text = string.Empty;
            textBoxBayar.Clear();
            idpembelian = string.Empty;
        }

        void selectInput()
        {
            textBoxIdBarang.Enabled = false;
            textBoxJumlah.Enabled = false;
            textBoxBayar.Enabled = false;
            buttonTambah.Enabled = false;
            buttonHapus.Enabled = true;
            buttonBatal.Enabled = true;
            buttonBayar.Enabled = false;
        }
        void unselectInput()
        {
            textBoxIdBarang.Enabled = true;
            textBoxJumlah.Enabled = true;
            textBoxBayar.Enabled = true;
            buttonTambah.Enabled = true;
            buttonHapus.Enabled = false;
            buttonBatal.Enabled = false;
            buttonBayar.Enabled = true;
        }
        void countTotal()
        {
            label_Jumlah.Text = MyUtility.MyDataSet.Tables["transaksi"].Compute("SUM(total)", $"id_pembelian = '{idpembelian}'").ToString();
        }

        private void buttonMulai_Click(object sender, EventArgs e)
        {
            int number = MyUtility.GetLastNumber("SELECT ISNULL(MAX(CONVERT(INT<SUBSTRING(id,3,3)))+1,1) FROM pembelian");

            idpembelian = $"PB{number.ToString("000")}";
            MyUtility.ExecuteCommand($"INSERT INTO pembelian VALUES('{idpembelian}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',0)");
            MyUtility.MyDataSet.Tables["pembelian"].Clear();
            MyUtility.SelectTable("SELECT *FORM pembelian", "pembelian");



            startInput();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            DataView dv = MyUtility.MyDataSet.Tables["transaksi"].DefaultView;
            dv.RowFilter = $"id_pembelian='{idpembelian}'";
            dataGridViewTransaksi.DataSource = dv;
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            DataRow dr = MyUtility.MyDataSet.Tables["barang"].Rows.Find(textBoxIdBarang.Text);
            int harga = Convert.ToInt32(dr["harga"]);
            MyUtility.ExecuteCommand($"insert into transaksi values('{textBoxIdBarang.Text}','{idpembelian}',{textBoxJumlah.Text},{harga})");
            MyUtility.MyDataSet.Tables["transaksi"].Clear();
            MyUtility.SelectTable("SELECT*FROM transaksi", "transaksi");

            DataView dv = MyUtility.MyDataSet.Tables["transaksi"].DefaultView;
            dv.RowFilter = $"id_pembelian'{idpembelian}'";
        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            DialogResult result = MyUtility.MultipleConfirmationResult("Apakah Anda ingin menyimpan transaksi ini?", "Konfirmasi Selesai Transaksi");

            if (result == DialogResult.Yes)
            {
                MyUtility.ExecuteCommand($"UPDATE pembelian SET total = {label_Id_Barang.Text} WHERE id = '{idpembelian}'");
                MyUtility.MyDataSet.Tables["pembelian"].Clear();
                MyUtility.SelectTable("SELECT * FROM pembelian", "pembelian");
            }
            else if (result == DialogResult.No)
            {
                DataRow[] rows = MyUtility.MyDataSet.Tables["transaksi"].Select($"id_pembelian = '{idpembelian}'");

                if (rows.Length != 0)
                {
                    foreach (DataRow row in rows)
                    {
                        MyUtility.ExecuteCommand($"UPDATE barang SET stok = stok + {row["jumlah"].ToString()} WHERE id = '{row["id_barang"].ToString()}'");
                        MyUtility.ExecuteCommand($"DELETE FROM transaksi WHERE id_barang = '{row["id_barang"]}' AND id_pembelian = '{row["id_pembelian"]}'");
                    }
                }

                MyUtility.ExecuteCommand($"DELETE FROM pembelian WHERE id = '{idpembelian}'");
                MyUtility.MyDataSet.Tables["pembelian"].Clear();
                MyUtility.SelectTable("SELECT * FROM pembelian", "pembelian");
                MyUtility.MyDataSet.Tables["transaksi"].Clear();
                MyUtility.SelectTable("SELECT * FROM transaksi", "transaksi");
                MyUtility.MyDataSet.Tables["barang"].Clear();
                MyUtility.SelectTable("SELECT * FROM barang", "barang");
            }

            if (result != DialogResult.Cancel)
            {
                endInput();

                DataView dv = MyUtility.MyDataSet.Tables["transaksi"].DefaultView;
                dv.RowFilter = $"id_pembelian = '{idpembelian}'";
                dataGridViewTransaksi.DataSource = dv.ToTable();
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            clearInput();
            unselectInput();
        }

        private void dataGridViewTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = dataGridViewTransaksi.Rows[e.RowIndex];
                textBoxIdBarang.Text = currentRow.Cells["id_barang"].Value.ToString();
                textBoxJumlah.Text = currentRow.Cells["jumlah"].Value.ToString();

                selectInput();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MyUtility.MultipleConfirmationResult("Apakah Anda ingin menyimpan transaksi ini?", "Konfirmasi Selesai Transaksi");

            if (result == DialogResult.Yes)
            {
                MyUtility.ExecuteCommand($"UPDATE pembelian SET total = {label_Id_Barang.Text} WHERE id = '{idpembelian}'");
                MyUtility.MyDataSet.Tables["pembelian"].Clear();
                MyUtility.SelectTable("SELECT * FROM pembelian", "pembelian");
            }
            else if (result == DialogResult.No)
            {
                DataRow[] rows = MyUtility.MyDataSet.Tables["transaksi"].Select($"id_pembelian = '{idpembelian}'");

                if (rows.Length != 0)
                {
                    foreach (DataRow row in rows)
                    {
                        MyUtility.ExecuteCommand($"UPDATE barang SET stok = stok + {row["jumlah"].ToString()} WHERE id = '{row["id_barang"].ToString()}'");
                        MyUtility.ExecuteCommand($"DELETE FROM transaksi WHERE id_barang = '{row["id_barang"]}' AND id_pembelian = '{row["id_pembelian"]}'");
                    }
                }

                MyUtility.ExecuteCommand($"DELETE FROM pembelian WHERE id = '{idpembelian}'");
                MyUtility.MyDataSet.Tables["pembelian"].Clear();
                MyUtility.SelectTable("SELECT * FROM pembelian", "pembelian");
                MyUtility.MyDataSet.Tables["transaksi"].Clear();
                MyUtility.SelectTable("SELECT * FROM transaksi", "transaksi");
                MyUtility.MyDataSet.Tables["barang"].Clear();
                MyUtility.SelectTable("SELECT * FROM barang", "barang");
            }

            if (result != DialogResult.Cancel)
            {
                endInput();

                DataView dv = MyUtility.MyDataSet.Tables["transaksi"].DefaultView;
                dv.RowFilter = $"id_pembelian = '{idpembelian}'";
                dataGridViewTransaksi.DataSource = dv.ToTable();
            }
        }
    }
}
