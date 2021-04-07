using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmTransaksiBarang
{
    public static class MyUtility
    {
        public static string ConnectionString = @"Data Source=DESKTOP-86HDJ4M;Initial Catalog=data_barang;Integrated Security=True";

        public static DataSet MyDataSet = new DataSet();

        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static void SelectTable(string query, string tableName)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.CommandText = query;
            sda.SelectCommand.Connection = connection;

            sda.Fill(MyDataSet, tableName);
        }

        public static void ExecuteCommand(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static DialogResult ConfirmationResult(string text,string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult MultipleConfirmationResult(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static int GetLastNumber(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;

            connection.Open();
            int number = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            return number;
        }
    }
}
