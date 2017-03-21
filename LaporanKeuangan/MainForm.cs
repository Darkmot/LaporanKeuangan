using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaporanKeuangan
{
    public partial class MainForm : Form
    {
        List<int> kodeAkunList;
        string conString = global::LaporanKeuangan.Properties.Settings.Default.LaporanKeuanganDatabaseConnectionString;

        public MainForm()
        {
            InitializeComponent();
        }

        private void inputDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPanel.Visible = true;
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPanel.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Initialize DateTime Picker
            TanggalPicker.CustomFormat = "dd-MMM-yyyy";

            //Initialize Transaksi Selection
            try
            {
                string q = "SELECT * FROM JENIS_TRANSAKSI ORDER BY jenis_id";
                //Console.WriteLine("ConString: " + conString);
                SqlConnection c = new SqlConnection(conString);
                SqlDataAdapter ad = new SqlDataAdapter(q, c);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                foreach (DataRow theRow in ds.Tables[0].Rows)
                {
                    TransaksiComboBox.Items.Add(theRow["nama_transaksi"]);
                }
                TransaksiComboBox.SelectedIndex = 0;
                c.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(),"Database Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            refreshInputGridView(TransaksiComboBox.SelectedIndex);
            
            //Initialize Daftar Akun Selection
            try
            {
                string q = "SELECT * FROM DAFTAR_AKUN ORDER BY kode_akun";
                SqlConnection c = new SqlConnection(conString);
                SqlDataAdapter ad = new SqlDataAdapter(q, c);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                kodeAkunList = new List<int>();
                foreach (DataRow theRow in ds.Tables[0].Rows)
                {
                    KodeAkunCombo.Items.Add(theRow["kode_akun"] + " - " + theRow["nama_akun"]);
                    int ka = (int)theRow["kode_akun"];
                    kodeAkunList.Add(ka);
                }
                KodeAkunCombo.SelectedIndex = 0;
                c.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(),"Database Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        void refreshInputGridView(int jenis_id)
        {
            try
            {
                //string q = "SELECT * FROM DATA_TRANSAKSI";
                string q = "SELECT tanggal_transaksi TANGGAL, ";
                q += "DATA_TRANSAKSI.kode_akun as 'KODE AKUN', ";
                q += "DAFTAR_AKUN.nama_akun as 'NAMA AKUN', ";
                q += "debet_transaksi as 'DEBET', ";
                q += "kredit_transaksi as 'KREDIT', ";
                q += "keterangan_transaksi as 'KETERANGAN' ";
                q += "FROM DATA_TRANSAKSI, DAFTAR_AKUN ";
                q += "WHERE DATA_TRANSAKSI.kode_akun = DAFTAR_AKUN.kode_akun ";
                q += "AND DATA_TRANSAKSI.jenis_id = " + jenis_id + " ";
                q += "ORDER BY tanggal_transaksi";

                SqlConnection c = new SqlConnection(global::LaporanKeuangan.Properties.Settings.Default.LaporanKeuanganDatabaseConnectionString);
                SqlDataAdapter ad = new SqlDataAdapter(q, c);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                InputGridView.ReadOnly = true;
                InputGridView.DataSource = ds.Tables[0];
            
                //Formatting
                InputGridView.Columns[0].DefaultCellStyle.Format = "dd-MMM-yyyy";

                c.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TransaksiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Transkasi Changed");
            refreshInputGridView(TransaksiComboBox.SelectedIndex);

        }
    }
}
