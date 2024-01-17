namespace WABS_Application_Manager
{
    partial class EditAcc
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
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.tbox_Username = new System.Windows.Forms.TextBox();
            this.lblacctype = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.rad_User = new System.Windows.Forms.RadioButton();
            this.rad_Admin = new System.Windows.Forms.RadioButton();
            this.btn_SubmitEdit = new System.Windows.Forms.Button();
            this.lbl_error_notif = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.White;
            this.lblpassword.Location = new System.Drawing.Point(71, 125);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(73, 18);
            this.lblpassword.TabIndex = 14;
            this.lblpassword.Text = "Password:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(71, 84);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(73, 18);
            this.lblusername.TabIndex = 13;
            this.lblusername.Text = "Username:";
            // 
            // tbox_Password
            // 
            this.tbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Password.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Password.Location = new System.Drawing.Point(177, 125);
            this.tbox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.PasswordChar = 'x';
            this.tbox_Password.Size = new System.Drawing.Size(229, 18);
            this.tbox_Password.TabIndex = 10;
            // 
            // tbox_Username
            // 
            this.tbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Username.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Username.Location = new System.Drawing.Point(177, 83);
            this.tbox_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_Username.Name = "tbox_Username";
            this.tbox_Username.Size = new System.Drawing.Size(229, 18);
            this.tbox_Username.TabIndex = 9;
            this.tbox_Username.TextChanged += new System.EventHandler(this.tbox_Username_TextChanged);
            this.tbox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_Username_KeyPress);
            // 
            // lblacctype
            // 
            this.lblacctype.AutoSize = true;
            this.lblacctype.BackColor = System.Drawing.Color.Transparent;
            this.lblacctype.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacctype.ForeColor = System.Drawing.Color.White;
            this.lblacctype.Location = new System.Drawing.Point(48, 159);
            this.lblacctype.Name = "lblacctype";
            this.lblacctype.Size = new System.Drawing.Size(96, 18);
            this.lblacctype.TabIndex = 15;
            this.lblacctype.Text = "Account Type:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(98, 46);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(46, 18);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name:";
            // 
            // tbox_Name
            // 
            this.tbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Name.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Name.Location = new System.Drawing.Point(177, 45);
            this.tbox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(229, 18);
            this.tbox_Name.TabIndex = 8;
            // 
            // rad_User
            // 
            this.rad_User.AutoSize = true;
            this.rad_User.BackColor = System.Drawing.Color.Transparent;
            this.rad_User.Checked = true;
            this.rad_User.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_User.ForeColor = System.Drawing.Color.White;
            this.rad_User.Location = new System.Drawing.Point(215, 159);
            this.rad_User.Name = "rad_User";
            this.rad_User.Size = new System.Drawing.Size(54, 22);
            this.rad_User.TabIndex = 16;
            this.rad_User.TabStop = true;
            this.rad_User.Text = "User";
            this.rad_User.UseVisualStyleBackColor = false;
            // 
            // rad_Admin
            // 
            this.rad_Admin.AutoSize = true;
            this.rad_Admin.BackColor = System.Drawing.Color.Transparent;
            this.rad_Admin.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Admin.ForeColor = System.Drawing.Color.White;
            this.rad_Admin.Location = new System.Drawing.Point(302, 159);
            this.rad_Admin.Name = "rad_Admin";
            this.rad_Admin.Size = new System.Drawing.Size(65, 22);
            this.rad_Admin.TabIndex = 17;
            this.rad_Admin.Text = "Admin";
            this.rad_Admin.UseVisualStyleBackColor = false;
            // 
            // btn_SubmitEdit
            // 
            this.btn_SubmitEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_SubmitEdit.FlatAppearance.BorderSize = 0;
            this.btn_SubmitEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubmitEdit.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitEdit.ForeColor = System.Drawing.Color.White;
            this.btn_SubmitEdit.Location = new System.Drawing.Point(98, 217);
            this.btn_SubmitEdit.Name = "btn_SubmitEdit";
            this.btn_SubmitEdit.Size = new System.Drawing.Size(121, 36);
            this.btn_SubmitEdit.TabIndex = 18;
            this.btn_SubmitEdit.Text = "CHANGE";
            this.btn_SubmitEdit.UseVisualStyleBackColor = false;
            this.btn_SubmitEdit.Click += new System.EventHandler(this.btn_SubmitEdit_Click);
            // 
            // lbl_error_notif
            // 
            this.lbl_error_notif.AutoSize = true;
            this.lbl_error_notif.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error_notif.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_notif.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_error_notif.Location = new System.Drawing.Point(176, 105);
            this.lbl_error_notif.Name = "lbl_error_notif";
            this.lbl_error_notif.Size = new System.Drawing.Size(153, 16);
            this.lbl_error_notif.TabIndex = 19;
            this.lbl_error_notif.Text = "Username is already taken!";
            this.lbl_error_notif.Visible = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(246, 217);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(121, 36);
            this.btn_Close.TabIndex = 20;
            this.btn_Close.Text = "CANCEL";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // EditAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WABS_Application_Manager.Properties.Resources.WABS_main_bg;
            this.ClientSize = new System.Drawing.Size(459, 300);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_error_notif);
            this.Controls.Add(this.btn_SubmitEdit);
            this.Controls.Add(this.rad_Admin);
            this.Controls.Add(this.rad_User);
            this.Controls.Add(this.lblacctype);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.tbox_Username);
            this.Controls.Add(this.tbox_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAcc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Accounts";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditAcc_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        public System.Windows.Forms.TextBox tbox_Password;
        public System.Windows.Forms.TextBox tbox_Username;
        private System.Windows.Forms.Label lblacctype;
        private System.Windows.Forms.Label lblname;
        public System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.RadioButton rad_User;
        private System.Windows.Forms.RadioButton rad_Admin;
        private System.Windows.Forms.Button btn_SubmitEdit;
        public System.Windows.Forms.Label lbl_error_notif;
        private System.Windows.Forms.Button btn_Close;
    }
}