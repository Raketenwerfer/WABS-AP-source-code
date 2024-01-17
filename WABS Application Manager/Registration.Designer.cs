namespace WABS_Application_Manager
{
    partial class Registration
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
            this.rad_Admin = new System.Windows.Forms.RadioButton();
            this.rad_User = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_confpass_error = new System.Windows.Forms.Label();
            this.lbl_password_error = new System.Windows.Forms.Label();
            this.lbl_username_error = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbox_ConfPassword = new System.Windows.Forms.TextBox();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.tbox_Username = new System.Windows.Forms.TextBox();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_RegisterAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rad_Admin
            // 
            this.rad_Admin.AutoSize = true;
            this.rad_Admin.BackColor = System.Drawing.Color.Transparent;
            this.rad_Admin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rad_Admin.FlatAppearance.BorderSize = 0;
            this.rad_Admin.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Admin.ForeColor = System.Drawing.Color.White;
            this.rad_Admin.Location = new System.Drawing.Point(188, 373);
            this.rad_Admin.Name = "rad_Admin";
            this.rad_Admin.Size = new System.Drawing.Size(65, 22);
            this.rad_Admin.TabIndex = 54;
            this.rad_Admin.TabStop = true;
            this.rad_Admin.Text = "Admin";
            this.rad_Admin.UseVisualStyleBackColor = false;
            this.rad_Admin.CheckedChanged += new System.EventHandler(this.rad_Admin_CheckedChanged);
            // 
            // rad_User
            // 
            this.rad_User.AutoSize = true;
            this.rad_User.BackColor = System.Drawing.Color.Transparent;
            this.rad_User.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rad_User.FlatAppearance.BorderSize = 0;
            this.rad_User.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_User.ForeColor = System.Drawing.Color.White;
            this.rad_User.Location = new System.Drawing.Point(128, 373);
            this.rad_User.Name = "rad_User";
            this.rad_User.Size = new System.Drawing.Size(54, 22);
            this.rad_User.TabIndex = 53;
            this.rad_User.TabStop = true;
            this.rad_User.Text = "User";
            this.rad_User.UseVisualStyleBackColor = false;
            this.rad_User.CheckedChanged += new System.EventHandler(this.rad_User_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Role:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_confpass_error
            // 
            this.lbl_confpass_error.AutoSize = true;
            this.lbl_confpass_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confpass_error.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confpass_error.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_confpass_error.Location = new System.Drawing.Point(79, 328);
            this.lbl_confpass_error.Name = "lbl_confpass_error";
            this.lbl_confpass_error.Size = new System.Drawing.Size(147, 16);
            this.lbl_confpass_error.TabIndex = 51;
            this.lbl_confpass_error.Text = "Passwords do not match!";
            // 
            // lbl_password_error
            // 
            this.lbl_password_error.AutoSize = true;
            this.lbl_password_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password_error.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password_error.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_password_error.Location = new System.Drawing.Point(77, 249);
            this.lbl_password_error.Name = "lbl_password_error";
            this.lbl_password_error.Size = new System.Drawing.Size(147, 16);
            this.lbl_password_error.TabIndex = 50;
            this.lbl_password_error.Text = "Passwords do not match!";
            // 
            // lbl_username_error
            // 
            this.lbl_username_error.AutoSize = true;
            this.lbl_username_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username_error.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username_error.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_username_error.Location = new System.Drawing.Point(77, 171);
            this.lbl_username_error.Name = "lbl_username_error";
            this.lbl_username_error.Size = new System.Drawing.Size(153, 16);
            this.lbl_username_error.TabIndex = 49;
            this.lbl_username_error.Text = "Username is already taken!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Confirm Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(74, 54);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(52, 19);
            this.lbl5.TabIndex = 45;
            this.lbl5.Text = "Name:";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbox_ConfPassword
            // 
            this.tbox_ConfPassword.BackColor = System.Drawing.Color.White;
            this.tbox_ConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_ConfPassword.Font = new System.Drawing.Font("HP Simplified Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_ConfPassword.Location = new System.Drawing.Point(80, 302);
            this.tbox_ConfPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_ConfPassword.Name = "tbox_ConfPassword";
            this.tbox_ConfPassword.PasswordChar = 'x';
            this.tbox_ConfPassword.Size = new System.Drawing.Size(415, 23);
            this.tbox_ConfPassword.TabIndex = 44;
            this.tbox_ConfPassword.TextChanged += new System.EventHandler(this.tbox_ConfPassword_TextChanged);
            // 
            // tbox_Password
            // 
            this.tbox_Password.BackColor = System.Drawing.Color.White;
            this.tbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Password.Font = new System.Drawing.Font("HP Simplified Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Password.Location = new System.Drawing.Point(78, 223);
            this.tbox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.PasswordChar = 'x';
            this.tbox_Password.Size = new System.Drawing.Size(415, 23);
            this.tbox_Password.TabIndex = 43;
            this.tbox_Password.TextChanged += new System.EventHandler(this.tbox_ConfPassword_TextChanged);
            // 
            // tbox_Username
            // 
            this.tbox_Username.BackColor = System.Drawing.Color.White;
            this.tbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Username.Font = new System.Drawing.Font("HP Simplified Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Username.Location = new System.Drawing.Point(78, 146);
            this.tbox_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_Username.Name = "tbox_Username";
            this.tbox_Username.Size = new System.Drawing.Size(415, 23);
            this.tbox_Username.TabIndex = 42;
            this.tbox_Username.TextChanged += new System.EventHandler(this.tbox_Username_TextChanged);
            // 
            // tbox_Name
            // 
            this.tbox_Name.BackColor = System.Drawing.Color.White;
            this.tbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Name.Font = new System.Drawing.Font("HP Simplified Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Name.Location = new System.Drawing.Point(78, 79);
            this.tbox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(415, 23);
            this.tbox_Name.TabIndex = 41;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(295, 450);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(192, 39);
            this.btn_Cancel.TabIndex = 40;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_RegisterAccount
            // 
            this.btn_RegisterAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_RegisterAccount.FlatAppearance.BorderSize = 0;
            this.btn_RegisterAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegisterAccount.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterAccount.ForeColor = System.Drawing.Color.White;
            this.btn_RegisterAccount.Location = new System.Drawing.Point(84, 450);
            this.btn_RegisterAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RegisterAccount.Name = "btn_RegisterAccount";
            this.btn_RegisterAccount.Size = new System.Drawing.Size(192, 39);
            this.btn_RegisterAccount.TabIndex = 39;
            this.btn_RegisterAccount.Text = "REGISTER";
            this.btn_RegisterAccount.UseVisualStyleBackColor = false;
            this.btn_RegisterAccount.Click += new System.EventHandler(this.btn_RegisterAccount_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WABS_Application_Manager.Properties.Resources.WABS_main_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 514);
            this.Controls.Add(this.rad_Admin);
            this.Controls.Add(this.rad_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_confpass_error);
            this.Controls.Add(this.lbl_password_error);
            this.Controls.Add(this.lbl_username_error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.tbox_ConfPassword);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.tbox_Username);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_RegisterAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Creation";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registration_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_Admin;
        private System.Windows.Forms.RadioButton rad_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_confpass_error;
        private System.Windows.Forms.Label lbl_password_error;
        private System.Windows.Forms.Label lbl_username_error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox tbox_ConfPassword;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.TextBox tbox_Username;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_RegisterAccount;
    }
}