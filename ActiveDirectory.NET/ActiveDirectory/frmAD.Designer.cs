namespace ActiveDirectory
{
    partial class frmAD
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
            this.grpSearchUser = new System.Windows.Forms.GroupBox();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.grpUserInformation = new System.Windows.Forms.GroupBox();
            this.pnlBlock = new System.Windows.Forms.Panel();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.grpDomain = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpSearchUser.SuspendLayout();
            this.grpUserInformation.SuspendLayout();
            this.grpDomain.SuspendLayout();
            this.grpForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearchUser
            // 
            this.grpSearchUser.Controls.Add(this.txtSearchUser);
            this.grpSearchUser.Controls.Add(this.label2);
            this.grpSearchUser.Controls.Add(this.btnSearchUserName);
            this.grpSearchUser.Location = new System.Drawing.Point(14, 114);
            this.grpSearchUser.Name = "grpSearchUser";
            this.grpSearchUser.Size = new System.Drawing.Size(592, 72);
            this.grpSearchUser.TabIndex = 37;
            this.grpSearchUser.TabStop = false;
            this.grpSearchUser.Text = "Search User";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(226, 28);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(168, 20);
            this.txtSearchUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter a Username/Email ID for search :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUserName.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearchUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchUserName.Location = new System.Drawing.Point(488, 26);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUserName.TabIndex = 4;
            this.btnSearchUserName.Text = "&Search";
            this.btnSearchUserName.UseVisualStyleBackColor = false;
            this.btnSearchUserName.Click += new System.EventHandler(this.btnSearchUserName_Click);
            // 
            // grpUserInformation
            // 
            this.grpUserInformation.Controls.Add(this.pnlBlock);
            this.grpUserInformation.Controls.Add(this.lblUsernameDisplay);
            this.grpUserInformation.Controls.Add(this.lblTelephone);
            this.grpUserInformation.Controls.Add(this.lblPostal);
            this.grpUserInformation.Controls.Add(this.lblCountry);
            this.grpUserInformation.Controls.Add(this.lblState);
            this.grpUserInformation.Controls.Add(this.lblCity);
            this.grpUserInformation.Controls.Add(this.lblCompany);
            this.grpUserInformation.Controls.Add(this.lblTitle);
            this.grpUserInformation.Controls.Add(this.lblEmailId);
            this.grpUserInformation.Controls.Add(this.lblLastName);
            this.grpUserInformation.Controls.Add(this.lblMiddleName);
            this.grpUserInformation.Controls.Add(this.lblFirstname);
            this.grpUserInformation.Location = new System.Drawing.Point(13, 192);
            this.grpUserInformation.Name = "grpUserInformation";
            this.grpUserInformation.Size = new System.Drawing.Size(593, 208);
            this.grpUserInformation.TabIndex = 36;
            this.grpUserInformation.TabStop = false;
            this.grpUserInformation.Text = "User Information";
            // 
            // pnlBlock
            // 
            this.pnlBlock.Location = new System.Drawing.Point(6, 16);
            this.pnlBlock.Name = "pnlBlock";
            this.pnlBlock.Size = new System.Drawing.Size(580, 186);
            this.pnlBlock.TabIndex = 34;
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.AutoSize = true;
            this.lblUsernameDisplay.Location = new System.Drawing.Point(31, 22);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(61, 13);
            this.lblUsernameDisplay.TabIndex = 32;
            this.lblUsernameDisplay.Text = "Username :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(345, 103);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 13);
            this.lblTelephone.TabIndex = 31;
            this.lblTelephone.Text = "Telephone No. :";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(359, 78);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(70, 13);
            this.lblPostal.TabIndex = 30;
            this.lblPostal.Text = "Postal Code :";
            this.lblPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(380, 55);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(49, 13);
            this.lblCountry.TabIndex = 29;
            this.lblCountry.Text = "Country :";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(391, 31);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 13);
            this.lblState.TabIndex = 28;
            this.lblState.Text = "State :";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(62, 186);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "City :";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(35, 163);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(57, 13);
            this.lblCompany.TabIndex = 26;
            this.lblCompany.Text = "Company :";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(59, 139);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Title :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(40, 115);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(52, 13);
            this.lblEmailId.TabIndex = 24;
            this.lblEmailId.Text = "Email ID :";
            this.lblEmailId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(28, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name :";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(17, 67);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(75, 13);
            this.lblMiddleName.TabIndex = 22;
            this.lblMiddleName.Text = "Middle Name :";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(29, 43);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(63, 13);
            this.lblFirstname.TabIndex = 21;
            this.lblFirstname.Text = "First Name :";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDomain
            // 
            this.grpDomain.Controls.Add(this.txtAddress);
            this.grpDomain.Controls.Add(this.lblAddress);
            this.grpDomain.Location = new System.Drawing.Point(326, 11);
            this.grpDomain.Name = "grpDomain";
            this.grpDomain.Size = new System.Drawing.Size(280, 96);
            this.grpDomain.TabIndex = 35;
            this.grpDomain.TabStop = false;
            this.grpDomain.Text = "Domain";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(17, 55);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(247, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(58, 28);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(164, 13);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Domain / Global Catalog Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.txtPassword);
            this.grpForm.Controls.Add(this.txtUsername);
            this.grpForm.Controls.Add(this.lblPassword);
            this.grpForm.Controls.Add(this.lblUsername);
            this.grpForm.Location = new System.Drawing.Point(13, 11);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(297, 96);
            this.grpForm.TabIndex = 34;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Credential";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(95, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(95, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(168, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 58);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(27, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Username :";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 412);
            this.Controls.Add(this.grpSearchUser);
            this.Controls.Add(this.grpUserInformation);
            this.Controls.Add(this.grpDomain);
            this.Controls.Add(this.grpForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Querying Active Directory";
            this.Load += new System.EventHandler(this.frmAD_Load);
            this.grpSearchUser.ResumeLayout(false);
            this.grpSearchUser.PerformLayout();
            this.grpUserInformation.ResumeLayout(false);
            this.grpUserInformation.PerformLayout();
            this.grpDomain.ResumeLayout(false);
            this.grpDomain.PerformLayout();
            this.grpForm.ResumeLayout(false);
            this.grpForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchUserName;
        private System.Windows.Forms.GroupBox grpUserInformation;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.GroupBox grpDomain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.Panel pnlBlock;


    }
}

