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
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
        }
         void clearInput()
        {
            textBoxid.Clear();
            textBoxNama.Clear();
            textBoxHarga.Clear();
            textBoxStok.Clear();
        }

        void disableInput()
        {
            textBoxid.Enabled = false;
            buttonTambah.Enabled = false;
            buttonUbah.Enabled = true;
            buttonHapus.Enabled = true;
            buttonBatal.Enabled = true;
        }

        void enableInput()
        {
            textBoxid.Enabled = true;
            buttonTambah.Enabled = true;
            buttonUbah.Enabled = false;
            buttonHapus.Enabled = false;
            buttonBatal.Enabled = false;

        }
        private void FormBarang_Load(object sender, EventArgs e)
        {
            dataGridViewBarang.DataSource = MyUtility.MyDataSet.Tables["barang"];
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

            MyUtility.ExecuteCommand($"INSERT INTO barang VALUES('{textBoxid.Text}', '{textBoxNama.Text}', {textBoxHarga.Text}, {textBoxStok.Text})");
            MyUtility.MyDataSet.Tables["barang"].Clear();
            MyUtility.SelectTable("SELECT * FROM barang", "barang");
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            MyUtility.ExecuteCommand($"UPDATE barang SET nama = '{textBoxNama.Text}', harga = {textBoxHarga.Text}, stok = {textBoxStok.Text} WHERE id = '{textBoxid.Text}'");
            MyUtility.MyDataSet.Tables["barang"].Clear();
            MyUtility.SelectTable("SELECT * FROM barang", "barang");

            clearInput();
            enableInput();
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = dataGridViewBarang.Rows[e.RowIndex];
                textBoxid.Text = currentRow.Cells["id"].Value.ToString();
                textBoxNama.Text = currentRow.Cells["nama"].Value.ToString();
                textBoxHarga.Text = currentRow.Cells["harga"].Value.ToString();
                textBoxStok.Text = currentRow.Cells["stok"].Value.ToString();

                disableInput();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MyUtility.ConfirmationResult("Apakah Anda yakin ingin menghapus data Barang ini?", "Konfirmasi Penghapusan Data Barang");

            if (result == DialogResult.Yes)
            {
                MyUtility.ExecuteCommand($"DELETE FROM barang WHERE id = '{textBoxid.Text}'");
                MyUtility.MyDataSet.Tables["barang"].Clear();
                MyUtility.SelectTable("SELECT * FROM barang", "barang");

                clearInput();
                enableInput();
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            textBoxid.Text = "";
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            textBoxStok.Text = "";


            clearInput();
            enableInput();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
