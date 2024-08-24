namespace Trac_Nghiem_HPC_UI
{
    partial class frmLamBai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLamBai));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.htmlContentControl3 = new DevExpress.XtraEditors.HtmlContentControl();
            this.radioGroupDapAn = new DevExpress.XtraEditors.RadioGroup();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.htmlContentControl2 = new DevExpress.XtraEditors.HtmlContentControl();
            this.gridControlDanhSachCauHoi = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.stepProgressBarThoiGian = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem4 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl3)).BeginInit();
            this.htmlContentControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupDapAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl2)).BeginInit();
            this.htmlContentControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).BeginInit();
            this.htmlContentControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBarThoiGian)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.BackColor = System.Drawing.Color.White;
            this.directXFormContainerControl1.Controls.Add(this.htmlContentControl3);
            this.directXFormContainerControl1.Controls.Add(this.htmlContentControl2);
            this.directXFormContainerControl1.Controls.Add(this.htmlContentControl1);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(1900, 1056);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // htmlContentControl3
            // 
            this.htmlContentControl3.Controls.Add(this.radioGroupDapAn);
            this.htmlContentControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl3.HtmlImages = this.imageCollection1;
            this.htmlContentControl3.HtmlTemplate.Styles = resources.GetString("htmlContentControl3.HtmlTemplate.Styles");
            this.htmlContentControl3.HtmlTemplate.Template = resources.GetString("htmlContentControl3.HtmlTemplate.Template");
            this.htmlContentControl3.Location = new System.Drawing.Point(0, 164);
            this.htmlContentControl3.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.htmlContentControl3.Name = "htmlContentControl3";
            this.htmlContentControl3.Size = new System.Drawing.Size(1464, 899);
            this.htmlContentControl3.TabIndex = 2;
            // 
            // radioGroupDapAn
            // 
            this.radioGroupDapAn.Location = new System.Drawing.Point(24, 462);
            this.radioGroupDapAn.Name = "radioGroupDapAn";
            this.radioGroupDapAn.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupDapAn.Properties.Appearance.Options.UseFont = true;
            this.radioGroupDapAn.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "A. View"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "B. Controller"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "C. Model"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "D. Router")});
            this.radioGroupDapAn.Size = new System.Drawing.Size(1416, 414);
            this.radioGroupDapAn.TabIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.IsDpiAware = DevExpress.Utils.DefaultBoolean.True;
            this.imageCollection1.Images.SetKeyName(0, "f814f9ee86f9897f7482c28cf25322e0.jpg.png");
            this.imageCollection1.Images.SetKeyName(1, "hourglass.png");
            this.imageCollection1.Images.SetKeyName(2, "8.png");
            this.imageCollection1.Images.SetKeyName(3, "mo-hinh-mvc-trong-java-la-gi-04.jpg");
            // 
            // htmlContentControl2
            // 
            this.htmlContentControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlContentControl2.Controls.Add(this.gridControlDanhSachCauHoi);
            this.htmlContentControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl2.HtmlTemplate.Styles = resources.GetString("htmlContentControl2.HtmlTemplate.Styles");
            this.htmlContentControl2.HtmlTemplate.Template = resources.GetString("htmlContentControl2.HtmlTemplate.Template");
            this.htmlContentControl2.Location = new System.Drawing.Point(1469, 164);
            this.htmlContentControl2.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.htmlContentControl2.Name = "htmlContentControl2";
            this.htmlContentControl2.Size = new System.Drawing.Size(431, 899);
            this.htmlContentControl2.TabIndex = 1;
            // 
            // gridControlDanhSachCauHoi
            // 
            this.gridControlDanhSachCauHoi.Location = new System.Drawing.Point(16, 56);
            this.gridControlDanhSachCauHoi.MainView = this.tileView1;
            this.gridControlDanhSachCauHoi.Name = "gridControlDanhSachCauHoi";
            this.gridControlDanhSachCauHoi.Size = new System.Drawing.Size(399, 560);
            this.gridControlDanhSachCauHoi.TabIndex = 0;
            this.gridControlDanhSachCauHoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.GridControl = this.gridControlDanhSachCauHoi;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsBehavior.AllowSmoothScrolling = true;
            this.tileView1.OptionsTiles.ColumnCount = 3;
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(248, 70);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileView1.TileHtmlTemplate.Styles = resources.GetString("tileView1.TileHtmlTemplate.Styles");
            this.tileView1.TileHtmlTemplate.Template = "<div id=\"kiemTraButton\" class=\"button\" onclick=\"onDetailButtonClick\">\r\n\t$Câu: {_i" +
    "d}\r\n</div>";
            // 
            // htmlContentControl1
            // 
            this.htmlContentControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlContentControl1.Controls.Add(this.labelControl1);
            this.htmlContentControl1.Controls.Add(this.stepProgressBarThoiGian);
            this.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl1.HtmlImages = this.imageCollection1;
            this.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles");
            this.htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template");
            this.htmlContentControl1.Location = new System.Drawing.Point(0, 0);
            this.htmlContentControl1.Margin = new System.Windows.Forms.Padding(20);
            this.htmlContentControl1.Name = "htmlContentControl1";
            this.htmlContentControl1.Size = new System.Drawing.Size(1900, 169);
            this.htmlContentControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(1080, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 28);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Thời gian";
            // 
            // stepProgressBarThoiGian
            // 
            this.stepProgressBarThoiGian.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stepProgressBarThoiGian.Appearance.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepProgressBarThoiGian.Appearance.Options.UseBackColor = true;
            this.stepProgressBarThoiGian.Appearance.Options.UseFont = true;
            this.stepProgressBarThoiGian.Appearances.CommonActiveColor = System.Drawing.Color.Blue;
            this.stepProgressBarThoiGian.ConnectorLineThickness = 5;
            this.stepProgressBarThoiGian.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.stepProgressBarThoiGian.Cursor = System.Windows.Forms.Cursors.Default;
            this.stepProgressBarThoiGian.IndentBetweenItems = 300;
            this.stepProgressBarThoiGian.IndicatorLineThickness = 5;
            this.stepProgressBarThoiGian.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("stepProgressBarThoiGian.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage")));
            this.stepProgressBarThoiGian.Items.Add(this.stepProgressBarItem1);
            this.stepProgressBarThoiGian.Items.Add(this.stepProgressBarItem2);
            this.stepProgressBarThoiGian.Items.Add(this.stepProgressBarItem3);
            this.stepProgressBarThoiGian.Items.Add(this.stepProgressBarItem4);
            this.stepProgressBarThoiGian.Location = new System.Drawing.Point(902, 61);
            this.stepProgressBarThoiGian.Name = "stepProgressBarThoiGian";
            this.stepProgressBarThoiGian.ShadowSize = 12;
            this.stepProgressBarThoiGian.Size = new System.Drawing.Size(986, 95);
            this.stepProgressBarThoiGian.TabIndex = 1;
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.Appearance.ContentBlockAppearance.Caption.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepProgressBarItem1.Appearance.ContentBlockAppearance.Caption.Options.UseFont = true;
            this.stepProgressBarItem1.ContentBlock2.Appearance.Caption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.stepProgressBarItem1.ContentBlock2.Appearance.Caption.Options.UseFont = true;
            this.stepProgressBarItem1.ContentBlock2.Caption = "0%";
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            this.stepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("stepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.SvgImage")));
            this.stepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.stepProgressBarItem1.Options.Indicator.InactiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline;
            this.stepProgressBarItem1.Options.Indicator.Width = 40;
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.Appearance.ContentBlockAppearance.Caption.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.stepProgressBarItem2.Appearance.ContentBlockAppearance.Caption.Options.UseFont = true;
            this.stepProgressBarItem2.ContentBlock2.Appearance.Caption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.stepProgressBarItem2.ContentBlock2.Appearance.Caption.Options.UseFont = true;
            this.stepProgressBarItem2.ContentBlock2.Caption = "25%";
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            this.stepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("stepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.SvgImage")));
            this.stepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.stepProgressBarItem2.Options.Indicator.InactiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline;
            this.stepProgressBarItem2.Options.Indicator.Width = 40;
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.Appearance.ContentBlockAppearance.Caption.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.stepProgressBarItem3.Appearance.ContentBlockAppearance.Caption.Options.UseFont = true;
            this.stepProgressBarItem3.ContentBlock2.Appearance.Caption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.stepProgressBarItem3.ContentBlock2.Appearance.Caption.Options.UseFont = true;
            this.stepProgressBarItem3.ContentBlock2.Caption = "50%";
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            this.stepProgressBarItem3.Options.Indicator.ActiveStateImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("stepProgressBarItem3.Options.Indicator.ActiveStateImageOptions.SvgImage")));
            this.stepProgressBarItem3.Options.Indicator.ActiveStateImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.stepProgressBarItem3.Options.Indicator.InactiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline;
            this.stepProgressBarItem3.Options.Indicator.Width = 40;
            // 
            // stepProgressBarItem4
            // 
            this.stepProgressBarItem4.Appearance.ContentBlockAppearance.Caption.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.stepProgressBarItem4.Appearance.ContentBlockAppearance.Caption.Options.UseFont = true;
            this.stepProgressBarItem4.ContentBlock2.Appearance.Caption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepProgressBarItem4.ContentBlock2.Appearance.Caption.Options.UseFont = true;
            this.stepProgressBarItem4.ContentBlock2.Caption = "100%";
            this.stepProgressBarItem4.Name = "stepProgressBarItem4";
            this.stepProgressBarItem4.Options.Indicator.ActiveStateImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("stepProgressBarItem4.Options.Indicator.ActiveStateImageOptions.SvgImage")));
            this.stepProgressBarItem4.Options.Indicator.ActiveStateImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.stepProgressBarItem4.Options.Indicator.InactiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline;
            this.stepProgressBarItem4.Options.Indicator.Width = 40;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(1900, 1056);
            this.ForceDirectX = DevExpress.Utils.DefaultBoolean.True;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLamBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLamBai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLamBai_Load);
            this.directXFormContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl3)).EndInit();
            this.htmlContentControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupDapAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl2)).EndInit();
            this.htmlContentControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).EndInit();
            this.htmlContentControl1.ResumeLayout(false);
            this.htmlContentControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBarThoiGian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl1;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl3;
        private DevExpress.XtraEditors.HtmlContentControl htmlContentControl2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.StepProgressBar stepProgressBarThoiGian;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem4;
        private DevExpress.XtraGrid.GridControl gridControlDanhSachCauHoi;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraEditors.RadioGroup radioGroupDapAn;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}