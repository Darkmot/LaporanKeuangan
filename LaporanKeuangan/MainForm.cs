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
            OutputPanel.Visible = false;
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPanel.Visible = false;
            OutputPanel.Visible = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Initialize DateTime Picker
            TanggalPicker.CustomFormat = "dd-MMM-yyyy";
            RangePickerStart.CustomFormat = "dd-MMM-yyyy";
            RangePickerEnd.CustomFormat = "dd-MMM-yyyy";
            DateTime curDate = DateTime.Now;
            RangePickerStart.Value = new DateTime(curDate.Year, curDate.Month, 1);
            RangePickerEnd.Value = new DateTime(curDate.Year, curDate.Month, DateTime.DaysInMonth(curDate.Year, curDate.Month));
            JumlahNumeric.Maximum = Decimal.MaxValue;


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

            refreshInputGridView(TransaksiComboBox.SelectedIndex,RangePickerStart.Value,RangePickerEnd.Value);
            
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

            this.TrialBalanceReportViewer.RefreshReport();
        }

        void refreshInputGridView(int jenis_id, DateTime rangeStart, DateTime rangeEnd)
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
                q += "AND DATA_TRANSAKSI.tanggal_transaksi >= '" + rangeStart + "' ";
                q += "AND DATA_TRANSAKSI.tanggal_transaksi <= '" + rangeEnd + "' ";
                q += "ORDER BY tanggal_transaksi";

                Console.WriteLine(q);

                SqlConnection c = new SqlConnection(conString);
                SqlDataAdapter ad = new SqlDataAdapter(q, c);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                InputGridView.ReadOnly = true;
                InputGridView.DataSource = ds.Tables[0];
            
                //Formatting
                InputGridView.Columns[0].DefaultCellStyle.Format = "dd-MMM-yyyy";
                InputGridView.Columns[3].DefaultCellStyle.Format = "N0";
                InputGridView.Columns[4].DefaultCellStyle.Format = "N0";

                for (int i = 0; i < InputGridView.Columns.Count; i++)
                {
                    InputGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

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
            refreshInputGridView(TransaksiComboBox.SelectedIndex, RangePickerStart.Value, RangePickerEnd.Value);

        }

        private void TambahButton_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(conString);
            try
            {
                string q = "INSERT INTO DATA_TRANSAKSI (jenis_id,tanggal_transaksi,kode_akun,debet_transaksi,kredit_transaksi,keterangan_transaksi) ";
                q += "values (" + TransaksiComboBox.SelectedIndex + ", ";
                q += "'" + TanggalPicker.Value + "', ";
                q += kodeAkunList[KodeAkunCombo.SelectedIndex] + ", ";
                if (DebetRadio.Checked)
                {
                    q += JumlahNumeric.Value + ", 0, ";
                }
                else
                {
                    q += "0, " + JumlahNumeric.Value + ", ";
                }
                q += "'" + KeteranganTextBox.Text + "')";

                SqlCommand execQ = new SqlCommand(q, c);
                c.Open();
                execQ.ExecuteNonQuery();

                MessageBox.Show("Transaski Berhasil Ditambah!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.Close();
            }
            refreshInputGridView(TransaksiComboBox.SelectedIndex, RangePickerStart.Value, RangePickerEnd.Value);

        }

    }
}
