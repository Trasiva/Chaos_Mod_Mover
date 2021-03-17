namespace Chaos_Mover
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sdGTA = new System.Windows.Forms.SaveFileDialog();
            this.tvGTA = new System.Windows.Forms.TreeView();
            this.tvStorage = new System.Windows.Forms.TreeView();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnPickPath = new System.Windows.Forms.Button();
            this.txtInstallPath = new System.Windows.Forms.TextBox();
            this.odGTA = new System.Windows.Forms.OpenFileDialog();
            this.fdGTA = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sdGTA
            // 
            this.sdGTA.FileOk += new System.ComponentModel.CancelEventHandler(this.sdGTA_FileOk);
            // 
            // tvGTA
            // 
            this.tvGTA.Location = new System.Drawing.Point(9, 42);
            this.tvGTA.Name = "tvGTA";
            this.tvGTA.Size = new System.Drawing.Size(194, 97);
            this.tvGTA.TabIndex = 0;
            // 
            // tvStorage
            // 
            this.tvStorage.Location = new System.Drawing.Point(290, 42);
            this.tvStorage.Name = "tvStorage";
            this.tvStorage.Size = new System.Drawing.Size(194, 97);
            this.tvStorage.TabIndex = 1;
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(209, 42);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 2;
            this.btnUninstall.Text = "-->";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(209, 116);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 3;
            this.btnInstall.Text = "<--";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnPickPath
            // 
            this.btnPickPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPickPath.BackgroundImage")));
            this.btnPickPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPickPath.Location = new System.Drawing.Point(9, 6);
            this.btnPickPath.Name = "btnPickPath";
            this.btnPickPath.Size = new System.Drawing.Size(30, 30);
            this.btnPickPath.TabIndex = 4;
            this.btnPickPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPickPath.UseVisualStyleBackColor = true;
            this.btnPickPath.Click += new System.EventHandler(this.btnPickPath_Click);
            // 
            // txtInstallPath
            // 
            this.txtInstallPath.Location = new System.Drawing.Point(45, 12);
            this.txtInstallPath.Name = "txtInstallPath";
            this.txtInstallPath.Size = new System.Drawing.Size(158, 20);
            this.txtInstallPath.TabIndex = 5;
            // 
            // odGTA
            // 
            this.odGTA.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mod Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(171, 142);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 31);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Installed";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 180);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstallPath);
            this.Controls.Add(this.btnPickPath);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.tvStorage);
            this.Controls.Add(this.tvGTA);
            this.Name = "frmMain";
            this.Text = "GTA File Mover";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sdGTA;
        private System.Windows.Forms.TreeView tvGTA;
        private System.Windows.Forms.TreeView tvStorage;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnPickPath;
        private System.Windows.Forms.TextBox txtInstallPath;
        private System.Windows.Forms.OpenFileDialog odGTA;
        private System.Windows.Forms.FolderBrowserDialog fdGTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
    }
}

