namespace AESxWin
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.btnRemovePath = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstPaths = new System.Windows.Forms.ListBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkSelectDest = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstExts = new System.Windows.Forms.ComboBox();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.chkDeleteOrg = new System.Windows.Forms.CheckBox();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.gbDest = new System.Windows.Forms.GroupBox();
            this.btnDecryptAndOpen = new System.Windows.Forms.Button();
            this.gbPasswordConfirm = new System.Windows.Forms.GroupBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPaths.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.gbDest.SuspendLayout();
            this.gbPasswordConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPaths
            // 
            this.gbPaths.Controls.Add(this.btnRemovePath);
            this.gbPaths.Controls.Add(this.btnAddFolder);
            this.gbPaths.Controls.Add(this.btnAddFile);
            this.gbPaths.Controls.Add(this.lstPaths);
            this.gbPaths.Location = new System.Drawing.Point(16, 14);
            this.gbPaths.Margin = new System.Windows.Forms.Padding(4);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Padding = new System.Windows.Forms.Padding(4);
            this.gbPaths.Size = new System.Drawing.Size(539, 186);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Paths";
            // 
            // btnRemovePath
            // 
            this.btnRemovePath.Location = new System.Drawing.Point(430, 97);
            this.btnRemovePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemovePath.Name = "btnRemovePath";
            this.btnRemovePath.Size = new System.Drawing.Size(100, 28);
            this.btnRemovePath.TabIndex = 3;
            this.btnRemovePath.Text = "Remove";
            this.btnRemovePath.UseVisualStyleBackColor = true;
            this.btnRemovePath.Click += new System.EventHandler(this.btnRemovePath_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(117, 97);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(100, 28);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(9, 97);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(100, 28);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Add File(s)";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstPaths
            // 
            this.lstPaths.AllowDrop = true;
            this.lstPaths.FormattingEnabled = true;
            this.lstPaths.HorizontalScrollbar = true;
            this.lstPaths.ItemHeight = 16;
            this.lstPaths.Location = new System.Drawing.Point(8, 23);
            this.lstPaths.Margin = new System.Windows.Forms.Padding(4);
            this.lstPaths.Name = "lstPaths";
            this.lstPaths.Size = new System.Drawing.Size(521, 68);
            this.lstPaths.TabIndex = 0;
            this.lstPaths.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstPaths_DragDrop);
            this.lstPaths.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstPaths_DragEnter);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chkSelectDest);
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.lstExts);
            this.gbOptions.Controls.Add(this.chkSubFolders);
            this.gbOptions.Controls.Add(this.chkDeleteOrg);
            this.gbOptions.Location = new System.Drawing.Point(16, 198);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(4);
            this.gbOptions.Size = new System.Drawing.Size(539, 69);
            this.gbOptions.TabIndex = 2;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkSelectDest
            // 
            this.chkSelectDest.AutoSize = true;
            this.chkSelectDest.Location = new System.Drawing.Point(277, 22);
            this.chkSelectDest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSelectDest.Name = "chkSelectDest";
            this.chkSelectDest.Size = new System.Drawing.Size(188, 21);
            this.chkSelectDest.TabIndex = 2;
            this.chkSelectDest.Text = "Select Destination Folder";
            this.chkSelectDest.UseVisualStyleBackColor = true;
            this.chkSelectDest.CheckedChanged += new System.EventHandler(this.chkSelectDest_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Extensions :";
            // 
            // lstExts
            // 
            this.lstExts.FormattingEnabled = true;
            this.lstExts.Items.AddRange(new object[] {
            "(Images) jpg jpeg png gif bmp",
            "(Videos) avi flv mov mp4 mpg rm rmvb mkv swf vob wmv 3g2 3gp asf ogv",
            "(Audio) mp3 wav acc ogg amr wma",
            "(Documents) pdf txt rtf doc docx ppt pptx xls xlsx",
            "(Compresed) zip rar 7z tar gzip",
            "(Code) cs vb java py rb cpp html css js",
            "(All Files)"});
            this.lstExts.Location = new System.Drawing.Point(370, 50);
            this.lstExts.Margin = new System.Windows.Forms.Padding(4);
            this.lstExts.Name = "lstExts";
            this.lstExts.Size = new System.Drawing.Size(160, 24);
            this.lstExts.TabIndex = 4;
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Location = new System.Drawing.Point(9, 52);
            this.chkSubFolders.Margin = new System.Windows.Forms.Padding(4);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(196, 21);
            this.chkSubFolders.TabIndex = 1;
            this.chkSubFolders.Text = "Search Folder Recursively";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // chkDeleteOrg
            // 
            this.chkDeleteOrg.AutoSize = true;
            this.chkDeleteOrg.Location = new System.Drawing.Point(9, 23);
            this.chkDeleteOrg.Margin = new System.Windows.Forms.Padding(4);
            this.chkDeleteOrg.Name = "chkDeleteOrg";
            this.chkDeleteOrg.Size = new System.Drawing.Size(154, 21);
            this.chkDeleteOrg.TabIndex = 0;
            this.chkDeleteOrg.Text = "Delete Orignal Files";
            this.chkDeleteOrg.UseVisualStyleBackColor = true;
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Location = new System.Drawing.Point(16, 274);
            this.gbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Padding = new System.Windows.Forms.Padding(4, 4, 20, 4);
            this.gbPassword.Size = new System.Drawing.Size(539, 59);
            this.gbPassword.TabIndex = 3;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(4, 19);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(515, 32);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.Location = new System.Drawing.Point(16, 408);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(135, 40);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.Location = new System.Drawing.Point(158, 408);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(124, 40);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInfo.Location = new System.Drawing.Point(0, 556);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(571, 25);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "v2.1";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(16, 451);
            this.gbLog.Margin = new System.Windows.Forms.Padding(4);
            this.gbLog.Name = "gbLog";
            this.gbLog.Padding = new System.Windows.Forms.Padding(4);
            this.gbLog.Size = new System.Drawing.Size(535, 102);
            this.gbLog.TabIndex = 8;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(4, 19);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(527, 79);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(8, 20);
            this.txtDest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(520, 22);
            this.txtDest.TabIndex = 0;
            // 
            // gbDest
            // 
            this.gbDest.Controls.Add(this.txtDest);
            this.gbDest.Location = new System.Drawing.Point(16, 140);
            this.gbDest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDest.Name = "gbDest";
            this.gbDest.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDest.Size = new System.Drawing.Size(530, 50);
            this.gbDest.TabIndex = 1;
            this.gbDest.TabStop = false;
            this.gbDest.Text = "Destination";
            this.gbDest.Visible = false;
            // 
            // btnDecryptAndOpen
            // 
            this.btnDecryptAndOpen.Enabled = false;
            this.btnDecryptAndOpen.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptAndOpen.Location = new System.Drawing.Point(288, 408);
            this.btnDecryptAndOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecryptAndOpen.Name = "btnDecryptAndOpen";
            this.btnDecryptAndOpen.Size = new System.Drawing.Size(263, 41);
            this.btnDecryptAndOpen.TabIndex = 7;
            this.btnDecryptAndOpen.Text = "Decrypt and Open A File";
            this.btnDecryptAndOpen.UseVisualStyleBackColor = true;
            this.btnDecryptAndOpen.Click += new System.EventHandler(this.btnDecryptAndOpen_Click);
            // 
            // gbPasswordConfirm
            // 
            this.gbPasswordConfirm.Controls.Add(this.txtPasswordConfirm);
            this.gbPasswordConfirm.Location = new System.Drawing.Point(16, 333);
            this.gbPasswordConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.gbPasswordConfirm.Name = "gbPasswordConfirm";
            this.gbPasswordConfirm.Padding = new System.Windows.Forms.Padding(4, 4, 20, 4);
            this.gbPasswordConfirm.Size = new System.Drawing.Size(539, 59);
            this.gbPasswordConfirm.TabIndex = 4;
            this.gbPasswordConfirm.TabStop = false;
            this.gbPasswordConfirm.Text = "Password Confirm";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPasswordConfirm.Location = new System.Drawing.Point(4, 19);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(515, 32);
            this.txtPasswordConfirm.TabIndex = 0;
            this.txtPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswordConfirm.TextChanged += new System.EventHandler(this.TxtPasswordConfirm_TextChanged);
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 581);
            this.Controls.Add(this.gbPasswordConfirm);
            this.Controls.Add(this.btnDecryptAndOpen);
            this.Controls.Add(this.gbDest);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbPaths);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESxWin";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbPaths.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.gbDest.ResumeLayout(false);
            this.gbDest.PerformLayout();
            this.gbPasswordConfirm.ResumeLayout(false);
            this.gbPasswordConfirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListBox lstPaths;
        private System.Windows.Forms.Button btnRemovePath;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.CheckBox chkDeleteOrg;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox lstExts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox chkSelectDest;
        private System.Windows.Forms.GroupBox gbDest;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnDecryptAndOpen;
        private System.Windows.Forms.GroupBox gbPasswordConfirm;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.ErrorProvider epPassword;
    }
}

