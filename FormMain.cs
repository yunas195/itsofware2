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
    public partial class FormMain : Form
    {
        FormBarang barang;
        FormTransaksi transaksi;
        FormLaporan laporan;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MyUtility.SelectTable("SELECT*FROM barang", "barang");
            DataColumn []primarykeys = { MyUtility.MyDataSet.Tables["barang"].Columns["id"] };
            MyUtility.MyDataSet.Tables["barang"].PrimaryKey = primarykeys;
            MyUtility.SelectTable("SELECT*FROM pembelian", "pembelian");
            MyUtility.SelectTable("SELECT*FROM transaksi", "transaksi");
            MyUtility.MyDataSet.Tables["transaksi"].Columns.Add("total", typeof(int), "jumlah*harga");

            barang = new FormBarang();
            transaksi = new FormTransaksi();
            laporan = new FormLaporan();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barang.IsDisposed)
            {
                barang = new FormBarang();
            }
            barang.MdiParent = this;
            barang.Show();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transaksi.IsDisposed)
            {
                transaksi = new FormTransaksi();
            }
            transaksi.MdiParent = this;
            transaksi.Show();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (laporan.IsDisposed)
            {
                laporan = new FormLaporan();
            }
            laporan.MdiParent = this;
            laporan.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
