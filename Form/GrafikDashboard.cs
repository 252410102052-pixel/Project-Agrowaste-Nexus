using AgroWasteNexus.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AgroWasteNexus.Forms
{
    public partial class GrafikDashboard : Form
    {
        private GrafikRepository repository = new GrafikRepository();

        private Chart chartStatusBatch;
        private Chart chartProduksi;
        private Chart chartQc;
        private Button btnKembali;

        public GrafikDashboard()
        {
            InitializeComponent();
            BuatTampilan();
        }

        private void GrafikDashboard_Load(object sender, EventArgs e)
        {
            LoadGrafikStatusBatch();
            LoadGrafikProduksi();
            LoadGrafikQc();
        }

        private void BuatTampilan()
        {
            this.Text = "Grafik Dashboard - AgroWaste Nexus";
            this.Size = new Size(1200, 750);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblJudul = new Label();
            lblJudul.Text = "GRAFIK DASHBOARD AGROWASTE NEXUS";
            lblJudul.Font = new Font("Century", 20, FontStyle.Bold);
            lblJudul.ForeColor = Color.DarkGreen;
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(300, 30);
            this.Controls.Add(lblJudul);

            chartStatusBatch = new Chart();
            chartStatusBatch.Location = new Point(40, 100);
            chartStatusBatch.Size = new Size(350, 450);
            this.Controls.Add(chartStatusBatch);

            chartProduksi = new Chart();
            chartProduksi.Location = new Point(420, 100);
            chartProduksi.Size = new Size(350, 450);
            this.Controls.Add(chartProduksi);

            chartQc = new Chart();
            chartQc.Location = new Point(800, 100);
            chartQc.Size = new Size(350, 450);
            this.Controls.Add(chartQc);

            btnKembali = new Button();
            btnKembali.Text = "← Kembali";
            btnKembali.Size = new Size(150, 40);
            btnKembali.Location = new Point(500, 600);
            btnKembali.Font = new Font("Century", 10, FontStyle.Bold);
            btnKembali.ForeColor = Color.DarkGreen;
            btnKembali.Click += btnKembali_Click;
            this.Controls.Add(btnKembali);

            this.Load += GrafikDashboard_Load;
        }

        private void LoadGrafikStatusBatch()
        {
            DataTable dt = repository.GetStatusBatch();

            chartStatusBatch.Series.Clear();
            chartStatusBatch.ChartAreas.Clear();
            chartStatusBatch.Titles.Clear();

            chartStatusBatch.ChartAreas.Add(new ChartArea("AreaBatch"));

            Series series = new Series("Status Batch");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["status_batch"].ToString(),
                    Convert.ToInt32(row["jumlah"])
                );
            }

            chartStatusBatch.Series.Add(series);
            chartStatusBatch.Titles.Add("Status Batch Limbah");
        }

        private void LoadGrafikProduksi()
        {
            DataTable dt = repository.GetProduksiPerProduk();

            chartProduksi.Series.Clear();
            chartProduksi.ChartAreas.Clear();
            chartProduksi.Titles.Clear();

            chartProduksi.ChartAreas.Add(new ChartArea("AreaProduksi"));

            Series series = new Series("Total Produksi");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["nama_produk"].ToString(),
                    Convert.ToDecimal(row["total_produksi"])
                );
            }

            chartProduksi.Series.Add(series);
            chartProduksi.Titles.Add("Produksi per Produk");
        }

        private void LoadGrafikQc()
        {
            DataTable dt = repository.GetQcLolosGagal();

            chartQc.Series.Clear();
            chartQc.ChartAreas.Clear();
            chartQc.Titles.Clear();

            chartQc.ChartAreas.Add(new ChartArea("AreaQC"));

            Series series = new Series("Quality Control");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                series.Points.AddXY(
                    "Lolos",
                    Convert.ToDecimal(row["total_lolos"])
                );

                series.Points.AddXY(
                    "Gagal",
                    Convert.ToDecimal(row["total_gagal"])
                );
            }

            chartQc.Series.Add(series);
            chartQc.Titles.Add("QC Lolos vs Gagal");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}