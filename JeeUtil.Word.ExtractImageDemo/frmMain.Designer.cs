namespace JeeUtil.Word.ExtractImageDemo
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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.ImageFormatList = new System.Windows.Forms.ComboBox();
            this.lblFileFormat = new System.Windows.Forms.Label();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.txtSaveLocation);
            this.grpMain.Controls.Add(this.btnProcess);
            this.grpMain.Controls.Add(this.ImageFormatList);
            this.grpMain.Controls.Add(this.lblFileFormat);
            this.grpMain.Controls.Add(this.btnChoosePath);
            this.grpMain.Controls.Add(this.lblFileName);
            this.grpMain.Controls.Add(this.btnChooseFile);
            this.grpMain.Location = new System.Drawing.Point(12, 12);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(425, 133);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Extract Image";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(115, 61);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(178, 20);
            this.txtSaveLocation.TabIndex = 7;
            // 
            // btnProcess
            // 
            this.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcess.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Location = new System.Drawing.Point(354, 103);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(65, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "&Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // ImageFormatList
            // 
            this.ImageFormatList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImageFormatList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageFormatList.FormattingEnabled = true;
            this.ImageFormatList.Items.AddRange(new object[] {
            "jpeg/jpg",
            "png",
            "bmp"});
            this.ImageFormatList.Location = new System.Drawing.Point(350, 61);
            this.ImageFormatList.Name = "ImageFormatList";
            this.ImageFormatList.Size = new System.Drawing.Size(69, 21);
            this.ImageFormatList.TabIndex = 5;
            // 
            // lblFileFormat
            // 
            this.lblFileFormat.AutoSize = true;
            this.lblFileFormat.Location = new System.Drawing.Point(299, 64);
            this.lblFileFormat.Name = "lblFileFormat";
            this.lblFileFormat.Size = new System.Drawing.Size(45, 13);
            this.lblFileFormat.TabIndex = 4;
            this.lblFileFormat.Text = "Format :";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePath.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChoosePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePath.Location = new System.Drawing.Point(7, 59);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(99, 23);
            this.btnChoosePath.TabIndex = 2;
            this.btnChoosePath.Text = "Path to &Save...";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(112, 25);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(55, 13);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Filename :";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.Location = new System.Drawing.Point(7, 20);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(99, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose &File...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 160);
            this.Controls.Add(this.grpMain);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JeeUtil.Word - Extract Image - Demo";
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ComboBox ImageFormatList;
        private System.Windows.Forms.Label lblFileFormat;
        private System.Windows.Forms.TextBox txtSaveLocation;
    }
}

