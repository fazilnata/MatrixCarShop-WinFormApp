namespace NataCarShop.Forms
{
    partial class AdminLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admintxt = new DevExpress.XtraEditors.TextEdit();
            this.passwordtxt = new DevExpress.XtraEditors.TextEdit();
            this.AdminGoBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.adminlbl = new DevExpress.XtraEditors.LabelControl();
            this.passwordlbl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admintxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordtxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NataCarShop.Properties.Resources.Coder_Desktop_Wallpaper_640;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // admintxt
            // 
            this.admintxt.Location = new System.Drawing.Point(245, 163);
            this.admintxt.Name = "admintxt";
            this.admintxt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admintxt.Properties.Appearance.Options.UseFont = true;
            this.admintxt.Size = new System.Drawing.Size(271, 32);
            this.admintxt.TabIndex = 1;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(245, 237);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordtxt.Properties.Appearance.Options.UseFont = true;
            this.passwordtxt.Properties.UseSystemPasswordChar = true;
            this.passwordtxt.Size = new System.Drawing.Size(271, 32);
            this.passwordtxt.TabIndex = 2;
            // 
            // AdminGoBtn
            // 
            this.AdminGoBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminGoBtn.Appearance.Options.UseFont = true;
            this.AdminGoBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AdminGoBtn.ImageOptions.SvgImage")));
            this.AdminGoBtn.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.AdminGoBtn.Location = new System.Drawing.Point(547, 311);
            this.AdminGoBtn.Name = "AdminGoBtn";
            this.AdminGoBtn.Size = new System.Drawing.Size(148, 46);
            this.AdminGoBtn.TabIndex = 3;
            this.AdminGoBtn.Text = "Daxil ol";
            this.AdminGoBtn.Click += new System.EventHandler(this.AdminGoBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.labelControl1.Location = new System.Drawing.Point(178, 165);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 23);
            this.labelControl1.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.labelControl2.Location = new System.Drawing.Point(178, 240);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 23);
            this.labelControl2.TabIndex = 5;
            // 
            // adminlbl
            // 
            this.adminlbl.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("adminlbl.ImageOptions.SvgImage")));
            this.adminlbl.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.adminlbl.Location = new System.Drawing.Point(169, 165);
            this.adminlbl.Name = "adminlbl";
            this.adminlbl.Size = new System.Drawing.Size(30, 30);
            this.adminlbl.TabIndex = 6;
            // 
            // passwordlbl
            // 
            this.passwordlbl.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("passwordlbl.ImageOptions.SvgImage")));
            this.passwordlbl.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.passwordlbl.Location = new System.Drawing.Point(169, 233);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(30, 30);
            this.passwordlbl.TabIndex = 7;
            // 
            // AdminLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 502);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.adminlbl);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.AdminGoBtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.admintxt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogIn_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admintxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordtxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit admintxt;
        private DevExpress.XtraEditors.TextEdit passwordtxt;
        private DevExpress.XtraEditors.SimpleButton AdminGoBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl adminlbl;
        private DevExpress.XtraEditors.LabelControl passwordlbl;
    }
}