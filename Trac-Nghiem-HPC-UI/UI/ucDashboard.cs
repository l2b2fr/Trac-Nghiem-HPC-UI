﻿using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trac_Nghiem_HPC_UI.DemoData;
using Trac_Nghiem_HPC_UI.Http;

namespace Trac_Nghiem_HPC_UI.UI
{
    public partial class ucDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            LoadProfile();
            LoadData();
            LoadDataChart();
            //loadLichThi();
        }

        private void LoadProfile()
        {
            List<SinhVienResponse> response = new List<SinhVienResponse>();
            response.Add(Program.sinhVienResponse);
            htmlContentControlProfile.DataContext = response;
        }
        private void LoadData()
        {
            var danhSachMonThi = MonThi.FakeMultipleData(30);
            gridControl1.DataSource = danhSachMonThi;
        }

        private void LoadDataChart()
        {
            var series = new Series("Thành tích hoạt động của bạn", ViewType.StackedBar);
            series.Points.Add(new SeriesPoint("Nhập môn lập trình", 10) { Color = Color.Red });
            series.Points.Add(new SeriesPoint("Cấu trúc dữ liệu", 6) { Color = Color.Blue });
            series.Points.Add(new SeriesPoint("Hệ điều hành", 2) { Color = Color.Green });
            series.Points.Add(new SeriesPoint("Mạng máy tính", 8) { Color = Color.Orange });
            series.Points.Add(new SeriesPoint("Cơ sở dữ liệu", 9) { Color = Color.Purple });

            ((BarSeriesView)series.View).ColorEach = true;

            //series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

            ((BarSeriesLabel)series.Label).TextPattern = "{A}: {V:n0} điểm";

            series.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            series.ToolTipPointPattern = "{A}: {V:n0} điểm";
            chartControl1.Series.Add(series);
        }

        private async void loadLichThi()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("copecute", Program.sinhVienResponse.Token);

                try
                {
                    var response = await client.GetAsync(Program.urlServer + "/api/kythi");
                    response.EnsureSuccessStatusCode();
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var kyThis = JsonConvert.DeserializeObject<List<KyThi>>(jsonString);

                    foreach (var kyThi in kyThis)
                    {
                        Console.WriteLine($"Tên kỳ thi: {kyThi.TenKyThi}");
                        Console.WriteLine($"Ngày bắt đầu: {kyThi.NgayBatDau}");
                        Console.WriteLine($"Ngày kết thúc: {kyThi.NgayKetThuc}");

                        foreach (var ca in kyThi.Ca_This)
                        {
                            Console.WriteLine($"  Tên ca: {ca.TenCa}");
                            Console.WriteLine($"  Thời gian bắt đầu: {ca.ThoiGianBatDau}");
                            Console.WriteLine($"  Thời gian kết thúc: {ca.ThoiGianKetThuc}");
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error fetching data: {e.Message}");
                }
            }
        }
    }
}
