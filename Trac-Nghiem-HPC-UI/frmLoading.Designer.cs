namespace Trac_Nghiem_HPC_UI
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alertControlSucces = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.imageCollectionFrmLogin = new DevExpress.Utils.ImageCollection(this.components);
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionFrmLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.progressBarControl1);
            this.directXFormContainerControl1.Controls.Add(this.imageSlider1);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(697, 321);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // imageSlider1
            // 
            this.imageSlider1.AllowLooping = true;
            this.imageSlider1.AnimationTime = 1000;
            this.imageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.imageSlider1.AutoSlideInterval = 1000;
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images2"))));
            this.imageSlider1.Location = new System.Drawing.Point(0, 0);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(697, 299);
            this.imageSlider1.TabIndex = 1;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(0, 296);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBarControl1.Properties.FlowAnimationDelay = 2500;
            this.progressBarControl1.Properties.FlowAnimationDuration = 1000;
            this.progressBarControl1.Properties.FlowAnimationEnabled = true;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(697, 25);
            this.progressBarControl1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alertControlSucces
            // 
            this.alertControlSucces.HtmlImages = this.imageCollectionFrmLogin;
            this.alertControlSucces.HtmlTemplate.Styles = resources.GetString("alertControlSucces.HtmlTemplate.Styles");
            this.alertControlSucces.HtmlTemplate.Template = resources.GetString("alertControlSucces.HtmlTemplate.Template");
            this.alertControlSucces.HtmlElementMouseClick += new DevExpress.XtraBars.Alerter.AlertHtmlElementMouseClickEventHandler(this.alertControlSucces_HtmlElementMouseClick);
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
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(697, 321);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.directXFormContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionFrmLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControlSucces;
        private DevExpress.Utils.ImageCollection imageCollectionFrmLogin;
    }
}