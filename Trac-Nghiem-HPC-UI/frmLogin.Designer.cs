namespace Trac_Nghiem_HPC_UI
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.ipMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ipMaSinhVien = new DevExpress.XtraEditors.TextEdit();
            this.imageCollectionFrmLogin = new DevExpress.Utils.ImageCollection(this.components);
            this.htmlTemplateCollectionFrmLogin = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.htmlMesage = new DevExpress.Utils.Html.HtmlTemplate();
            this.alertControlSucces = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipMaSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionFrmLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.ipMatKhau);
            this.directXFormContainerControl1.Controls.Add(this.btnDangNhap);
            this.directXFormContainerControl1.Controls.Add(this.btnThoat);
            this.directXFormContainerControl1.Controls.Add(this.labelControl3);
            this.directXFormContainerControl1.Controls.Add(this.labelControl2);
            this.directXFormContainerControl1.Controls.Add(this.labelControl1);
            this.directXFormContainerControl1.Controls.Add(this.ipMaSinhVien);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(31, 81);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(1000, 504);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // ipMatKhau
            // 
            this.ipMatKhau.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.ipMatKhau.Location = new System.Drawing.Point(98, 283);
            this.ipMatKhau.Name = "ipMatKhau";
            this.ipMatKhau.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.ipMatKhau.Properties.AdvancedModeOptions.Label = "Nhập mật khẩu của bạn";
            this.ipMatKhau.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipMatKhau.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.ipMatKhau.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.White;
            this.ipMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipMatKhau.Properties.Appearance.Options.UseFont = true;
            this.ipMatKhau.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.ipMatKhau.Size = new System.Drawing.Size(492, 46);
            this.ipMatKhau.TabIndex = 9;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseBackColor = true;
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(98, 382);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(144, 44);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(446, 382);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 44);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(98, 244);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 33);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "MẬT KHẨU";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(98, 140);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(179, 33);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "MÃ SINH VIÊN";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(98, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(496, 42);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "PHẦN MỀM THI TRẮC NGHIỆM";
            // 
            // ipMaSinhVien
            // 
            this.ipMaSinhVien.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.ipMaSinhVien.Location = new System.Drawing.Point(98, 179);
            this.ipMaSinhVien.Name = "ipMaSinhVien";
            this.ipMaSinhVien.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.ipMaSinhVien.Properties.AdvancedModeOptions.Label = "Nhập mã sinh viên của bạn";
            this.ipMaSinhVien.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipMaSinhVien.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.ipMaSinhVien.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.White;
            this.ipMaSinhVien.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipMaSinhVien.Properties.Appearance.Options.UseFont = true;
            this.ipMaSinhVien.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.ipMaSinhVien.Size = new System.Drawing.Size(492, 46);
            this.ipMaSinhVien.TabIndex = 0;
            // 
            // imageCollectionFrmLogin
            // 
            this.imageCollectionFrmLogin.ImageSize = new System.Drawing.Size(16, 16);
            this.imageCollectionFrmLogin.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionFrmLogin.ImageStream")));
            this.imageCollectionFrmLogin.IsDpiAware = DevExpress.Utils.DefaultBoolean.True;
            this.imageCollectionFrmLogin.Images.SetKeyName(0, "img_view.png");
            this.imageCollectionFrmLogin.Images.SetKeyName(1, "logo.png");
            this.imageCollectionFrmLogin.Images.SetKeyName(2, "check.png");
            // 
            // htmlTemplateCollectionFrmLogin
            // 
            this.htmlTemplateCollectionFrmLogin.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlMesage});
            // 
            // htmlMesage
            // 
            this.htmlMesage.Name = "htmlMesage";
            this.htmlMesage.Styles = resources.GetString("htmlMesage.Styles");
            this.htmlMesage.Template = resources.GetString("htmlMesage.Template");
            // 
            // alertControlSucces
            // 
            this.alertControlSucces.HtmlImages = this.imageCollectionFrmLogin;
            this.alertControlSucces.HtmlTemplate.Styles = resources.GetString("alertControlSucces.HtmlTemplate.Styles");
            this.alertControlSucces.HtmlTemplate.Template = resources.GetString("alertControlSucces.HtmlTemplate.Template");
            this.alertControlSucces.HtmlElementMouseClick += new DevExpress.XtraBars.Alerter.AlertHtmlElementMouseClickEventHandler(this.alertControlSucces_HtmlElementMouseClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(1073, 614);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HtmlImages = this.imageCollectionFrmLogin;
            this.HtmlTemplate.Styles = resources.GetString("frmLogin.HtmlTemplate.Styles");
            this.HtmlTemplate.Template = resources.GetString("frmLogin.HtmlTemplate.Template");
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLogin.IconOptions.Image")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.HtmlElementMouseClick += new DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(this.frmLogin_HtmlElementMouseClick);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.directXFormContainerControl1.ResumeLayout(false);
            this.directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipMaSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionFrmLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.Utils.ImageCollection imageCollectionFrmLogin;
        private DevExpress.XtraEditors.TextEdit ipMaSinhVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.Utils.Html.HtmlTemplateCollection htmlTemplateCollectionFrmLogin;
        private DevExpress.Utils.Html.HtmlTemplate htmlMesage;
        private DevExpress.XtraEditors.TextEdit ipMatKhau;
        private DevExpress.XtraBars.Alerter.AlertControl alertControlSucces;
    }
}