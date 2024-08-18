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
            this.checkEditHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipMaSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionFrmLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.checkEditHienMatKhau);
            this.directXFormContainerControl1.Controls.Add(this.ipMatKhau);
            this.directXFormContainerControl1.Controls.Add(this.btnDangNhap);
            this.directXFormContainerControl1.Controls.Add(this.btnThoat);
            this.directXFormContainerControl1.Controls.Add(this.labelControl3);
            this.directXFormContainerControl1.Controls.Add(this.labelControl2);
            this.directXFormContainerControl1.Controls.Add(this.labelControl1);
            this.directXFormContainerControl1.Controls.Add(this.ipMaSinhVien);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(38, 100);
            this.directXFormContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(1250, 620);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // checkEditHienMatKhau
            // 
            this.checkEditHienMatKhau.Location = new System.Drawing.Point(556, 315);
            this.checkEditHienMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEditHienMatKhau.Name = "checkEditHienMatKhau";
            this.checkEditHienMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditHienMatKhau.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.checkEditHienMatKhau.Properties.Appearance.Options.UseFont = true;
            this.checkEditHienMatKhau.Properties.Appearance.Options.UseForeColor = true;
            this.checkEditHienMatKhau.Properties.Caption = "Hiện mật khẩu";
            this.checkEditHienMatKhau.Size = new System.Drawing.Size(134, 24);
            this.checkEditHienMatKhau.TabIndex = 10;
            this.checkEditHienMatKhau.CheckedChanged += new System.EventHandler(this.checkEditHienMatKhau_CheckedChanged);
            // 
            // ipMatKhau
            // 
            this.ipMatKhau.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.ipMatKhau.Location = new System.Drawing.Point(114, 348);
            this.ipMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipMatKhau.Name = "ipMatKhau";
            this.ipMatKhau.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.ipMatKhau.Properties.AdvancedModeOptions.Label = "Nhập mật khẩu của bạn";
            this.ipMatKhau.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipMatKhau.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.ipMatKhau.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.White;
            this.ipMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipMatKhau.Properties.Appearance.Options.UseFont = true;
            this.ipMatKhau.Properties.PasswordChar = '*';
            this.ipMatKhau.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.ipMatKhau.Size = new System.Drawing.Size(574, 57);
            this.ipMatKhau.TabIndex = 9;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseBackColor = true;
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(114, 470);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(168, 54);
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
            this.btnThoat.Location = new System.Drawing.Point(520, 470);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(168, 54);
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
            this.labelControl3.Location = new System.Drawing.Point(114, 300);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(170, 41);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "MẬT KHẨU";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(114, 172);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(223, 41);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "MÃ SINH VIÊN";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(114, 100);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(619, 53);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "PHẦN MỀM THI TRẮC NGHIỆM";
            // 
            // ipMaSinhVien
            // 
            this.ipMaSinhVien.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.ipMaSinhVien.Location = new System.Drawing.Point(114, 220);
            this.ipMaSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipMaSinhVien.Name = "ipMaSinhVien";
            this.ipMaSinhVien.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.ipMaSinhVien.Properties.AdvancedModeOptions.Label = "Nhập mã sinh viên của bạn";
            this.ipMaSinhVien.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipMaSinhVien.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.ipMaSinhVien.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.White;
            this.ipMaSinhVien.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipMaSinhVien.Properties.Appearance.Options.UseFont = true;
            this.ipMaSinhVien.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.ipMaSinhVien.Size = new System.Drawing.Size(574, 57);
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
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(88)))), ((int)(((byte)(163)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(152, 58);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(259, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Phần mềm thi trắc nghiệm";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ChildControls.Add(this.labelControl4);
            this.ClientSize = new System.Drawing.Size(1325, 756);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HtmlImages = this.imageCollectionFrmLogin;
            this.HtmlTemplate.Styles = resources.GetString("frmLogin.HtmlTemplate.Styles");
            this.HtmlTemplate.Template = resources.GetString("frmLogin.HtmlTemplate.Template");
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLogin.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.HtmlElementMouseClick += new DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(this.frmLogin_HtmlElementMouseClick);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.directXFormContainerControl1.ResumeLayout(false);
            this.directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipMaSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionFrmLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.CheckEdit checkEditHienMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}