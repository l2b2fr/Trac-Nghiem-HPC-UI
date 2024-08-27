using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Trac_Nghiem_HPC_UI.Http;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Trac_Nghiem_HPC_UI
{
    public partial class frmLogin : DevExpress.XtraEditors.DirectXForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void frmLogin_HtmlElementMouseClick(object sender, DevExpress.Utils.Html.DxHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "point _red")
            {
                var arg = new XtraMessageBoxArgs();
                arg.HtmlTemplate.Assign(htmlMesage);
                arg.Caption = "Thông báo";
                arg.Text = "Bạn có muốn thoát?";
                arg.DefaultButtonIndex = 0;
                var result = XtraMessageBox.Show(arg);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            if (e.ElementId == "point _green")
            {
                this.WindowState = FormWindowState.Minimized;
                //LoadData();
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ipMaSinhVien.Text) || string.IsNullOrWhiteSpace(ipMatKhau.Text))
            {
                alertControlErrorNull.Show(this);
                ipMaSinhVien.Focus();
            }
            else
            {
                bool check = SendPostRequestLogin(ipMaSinhVien.Text, ipMatKhau.Text);
                if (check)
                {
                    this.Hide();
                    new frmLoading().Show();
                }
                else
                {
                    alertControlError.Show(this);
                    ipMaSinhVien.Clear();
                    ipMatKhau.Clear();
                    ipMaSinhVien.Focus();
                }
            }
        }

        private bool SendPostRequestLogin(string maSV, string matKhau)
        {
            string url = Program.urlServer + "/api/sinhvien/login";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            // Tạo đối tượng JSON
            var json = new JObject
                {
                    { "maSV", maSV },
                    { "matKhau", matKhau }
                };
            // Chuyển đổi đối tượng JSON thành chuỗi
            var postData = json.ToString();
            var data = Encoding.UTF8.GetBytes(postData);

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                try
                {
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            using (var streamReader = new StreamReader(response.GetResponseStream()))
                            {
                                var result = streamReader.ReadToEnd();
                                if (!string.IsNullOrEmpty(result))
                                {
                                    var sinhVienResponse = JsonConvert.DeserializeObject<SinhVienResponse>(result);
                                    Program.sinhVienResponse = sinhVienResponse;
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Error: {response.StatusCode}");
                        }
                    }
                }
                catch (WebException ex)
                {
                    Console.WriteLine($"Error: {ex.Status}");
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối với Server!");
            }

            return false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var arg = new XtraMessageBoxArgs();
            arg.HtmlTemplate.Assign(htmlMesage);
            arg.Caption = "Thông báo";
            arg.Text = "Bạn có muốn thoát?";
            arg.DefaultButtonIndex = 0;
            var result = XtraMessageBox.Show(arg);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void alertControlSucces_HtmlElementMouseClick(object sender, DevExpress.XtraBars.Alerter.AlertHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "okButton") e.HtmlPopup.Close();
        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHienMatKhau.Checked)
            {
                ipMatKhau.Properties.PasswordChar = '\0';
            }
            else
            {
                ipMatKhau.Properties.PasswordChar = '*';
            }
        }

        private void alertControlError_HtmlElementMouseClick(object sender, AlertHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "delete")
            {
                e.HtmlPopup.Close();
            }
        }

        private void alertControlErrorNull_HtmlElementMouseClick(object sender, AlertHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "delete")
            {
                e.HtmlPopup.Close();
            }
        }
        private async void LoadData()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://127.0.0.1:8000/api/kythi/1/cathi";
                string token = "20|BiAHDiz55zV7KEdMwxFwHiMMrqW0d5CRUbj81xQBbd1195d3";

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("copecute", token);

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var caThiList = JsonConvert.DeserializeObject<List<CaThi>>(responseBody);
                    foreach (var caThi in caThiList)
                    {
                        MessageBox.Show($"ID: {caThi.Id}, TenCa: {caThi.TenCa}, ThoiGianBatDau: {caThi.ThoiGianBatDau}, ThoiGianKetThuc: {caThi.ThoiGianKetThuc}");
                    }
                }
                else
                {
                    MessageBox.Show($"Request failed: {response.StatusCode}");
                }
            }
        }
    }
}