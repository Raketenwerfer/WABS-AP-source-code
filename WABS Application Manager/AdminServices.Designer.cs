namespace WABS_Application_Manager
{
    partial class AdminServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AdminTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_back1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mng_DelAcc = new System.Windows.Forms.Button();
            this.btn_mng_EdAcc = new System.Windows.Forms.Button();
            this.btn_mng_AddAcc = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_back2 = new System.Windows.Forms.Button();
            this.btn_HardDelete = new System.Windows.Forms.Button();
            this.btn_RestoreEntry = new System.Windows.Forms.Button();
            this.dgvRemovedApps = new System.Windows.Forms.DataGridView();
            this.AdminTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemovedApps)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminTab
            // 
            this.AdminTab.Controls.Add(this.tabPage1);
            this.AdminTab.Controls.Add(this.tabPage2);
            this.AdminTab.Location = new System.Drawing.Point(-1, -2);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.SelectedIndex = 0;
            this.AdminTab.Size = new System.Drawing.Size(754, 353);
            this.AdminTab.TabIndex = 4;
            this.AdminTab.SelectedIndexChanged += new System.EventHandler(this.AdminTab_SelectedIndexChanged);
            this.AdminTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminServices_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage1.BackgroundImage = global::WABS_Application_Manager.Properties.Resources.WABS_main_bg;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btn_back1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvDisplay);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Accounts Manager";
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminServices_MouseDown);
            // 
            // btn_back1
            // 
            this.btn_back1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_back1.FlatAppearance.BorderSize = 0;
            this.btn_back1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back1.ForeColor = System.Drawing.Color.White;
            this.btn_back1.Location = new System.Drawing.Point(29, 268);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Size = new System.Drawing.Size(167, 38);
            this.btn_back1.TabIndex = 10;
            this.btn_back1.Text = "Back";
            this.btn_back1.UseVisualStyleBackColor = false;
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_mng_DelAcc);
            this.panel1.Controls.Add(this.btn_mng_EdAcc);
            this.panel1.Controls.Add(this.btn_mng_AddAcc);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 155);
            this.panel1.TabIndex = 4;
            // 
            // btn_mng_DelAcc
            // 
            this.btn_mng_DelAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_mng_DelAcc.FlatAppearance.BorderSize = 0;
            this.btn_mng_DelAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mng_DelAcc.ForeColor = System.Drawing.Color.White;
            this.btn_mng_DelAcc.Location = new System.Drawing.Point(18, 106);
            this.btn_mng_DelAcc.Name = "btn_mng_DelAcc";
            this.btn_mng_DelAcc.Size = new System.Drawing.Size(167, 38);
            this.btn_mng_DelAcc.TabIndex = 2;
            this.btn_mng_DelAcc.Text = "Delete Account";
            this.btn_mng_DelAcc.UseVisualStyleBackColor = false;
            this.btn_mng_DelAcc.Click += new System.EventHandler(this.btn_mng_DelAcc_Click);
            // 
            // btn_mng_EdAcc
            // 
            this.btn_mng_EdAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_mng_EdAcc.FlatAppearance.BorderSize = 0;
            this.btn_mng_EdAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mng_EdAcc.ForeColor = System.Drawing.Color.White;
            this.btn_mng_EdAcc.Location = new System.Drawing.Point(18, 62);
            this.btn_mng_EdAcc.Name = "btn_mng_EdAcc";
            this.btn_mng_EdAcc.Size = new System.Drawing.Size(167, 38);
            this.btn_mng_EdAcc.TabIndex = 1;
            this.btn_mng_EdAcc.Text = "Edit Account";
            this.btn_mng_EdAcc.UseVisualStyleBackColor = false;
            this.btn_mng_EdAcc.Click += new System.EventHandler(this.btn_mng_EdAcc_Click);
            // 
            // btn_mng_AddAcc
            // 
            this.btn_mng_AddAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_mng_AddAcc.FlatAppearance.BorderSize = 0;
            this.btn_mng_AddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mng_AddAcc.ForeColor = System.Drawing.Color.White;
            this.btn_mng_AddAcc.Location = new System.Drawing.Point(18, 18);
            this.btn_mng_AddAcc.Name = "btn_mng_AddAcc";
            this.btn_mng_AddAcc.Size = new System.Drawing.Size(167, 38);
            this.btn_mng_AddAcc.TabIndex = 0;
            this.btn_mng_AddAcc.Text = "Add Account";
            this.btn_mng_AddAcc.UseVisualStyleBackColor = false;
            this.btn_mng_AddAcc.Click += new System.EventHandler(this.btn_mng_AddAcc_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.AllowUserToDeleteRows = false;
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplay.Location = new System.Drawing.Point(225, 12);
            this.dgvDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDisplay.MultiSelect = false;
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(511, 296);
            this.dgvDisplay.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage2.BackgroundImage = global::WABS_Application_Manager.Properties.Resources.WABS_main_bg;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.btn_back2);
            this.tabPage2.Controls.Add(this.btn_HardDelete);
            this.tabPage2.Controls.Add(this.btn_RestoreEntry);
            this.tabPage2.Controls.Add(this.dgvRemovedApps);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Removed Applications";
            this.tabPage2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminServices_MouseDown);
            // 
            // btn_back2
            // 
            this.btn_back2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_back2.FlatAppearance.BorderSize = 0;
            this.btn_back2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back2.ForeColor = System.Drawing.Color.White;
            this.btn_back2.Location = new System.Drawing.Point(29, 268);
            this.btn_back2.Name = "btn_back2";
            this.btn_back2.Size = new System.Drawing.Size(167, 38);
            this.btn_back2.TabIndex = 9;
            this.btn_back2.Text = "Back";
            this.btn_back2.UseVisualStyleBackColor = false;
            this.btn_back2.Click += new System.EventHandler(this.btn_back2_Click);
            // 
            // btn_HardDelete
            // 
            this.btn_HardDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_HardDelete.FlatAppearance.BorderSize = 0;
            this.btn_HardDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HardDelete.ForeColor = System.Drawing.Color.White;
            this.btn_HardDelete.Location = new System.Drawing.Point(29, 74);
            this.btn_HardDelete.Name = "btn_HardDelete";
            this.btn_HardDelete.Size = new System.Drawing.Size(167, 38);
            this.btn_HardDelete.TabIndex = 8;
            this.btn_HardDelete.Text = "Delete Entry";
            this.btn_HardDelete.UseVisualStyleBackColor = false;
            this.btn_HardDelete.Click += new System.EventHandler(this.btn_HardDelete_Click);
            // 
            // btn_RestoreEntry
            // 
            this.btn_RestoreEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_RestoreEntry.FlatAppearance.BorderSize = 0;
            this.btn_RestoreEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RestoreEntry.ForeColor = System.Drawing.Color.White;
            this.btn_RestoreEntry.Location = new System.Drawing.Point(29, 30);
            this.btn_RestoreEntry.Name = "btn_RestoreEntry";
            this.btn_RestoreEntry.Size = new System.Drawing.Size(167, 38);
            this.btn_RestoreEntry.TabIndex = 7;
            this.btn_RestoreEntry.Text = "Restore Entry";
            this.btn_RestoreEntry.UseVisualStyleBackColor = false;
            this.btn_RestoreEntry.Click += new System.EventHandler(this.btn_RestoreEntry_Click);
            // 
            // dgvRemovedApps
            // 
            this.dgvRemovedApps.AllowUserToAddRows = false;
            this.dgvRemovedApps.AllowUserToDeleteRows = false;
            this.dgvRemovedApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRemovedApps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRemovedApps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemovedApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRemovedApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemovedApps.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRemovedApps.Location = new System.Drawing.Point(225, 12);
            this.dgvRemovedApps.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRemovedApps.MultiSelect = false;
            this.dgvRemovedApps.Name = "dgvRemovedApps";
            this.dgvRemovedApps.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemovedApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRemovedApps.RowTemplate.Height = 24;
            this.dgvRemovedApps.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemovedApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemovedApps.Size = new System.Drawing.Size(511, 296);
            this.dgvRemovedApps.TabIndex = 6;
            // 
            // AdminServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(749, 344);
            this.Controls.Add(this.AdminTab);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminServices";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Avenue & Business Solutions Inc. - Accounts Manager";
            this.Activated += new System.EventHandler(this.AdminServices_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminServices_MouseDown);
            this.AdminTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemovedApps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl AdminTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_mng_DelAcc;
        private System.Windows.Forms.Button btn_mng_EdAcc;
        private System.Windows.Forms.Button btn_mng_AddAcc;
        public System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dgvRemovedApps;
        private System.Windows.Forms.Button btn_HardDelete;
        private System.Windows.Forms.Button btn_RestoreEntry;
        private System.Windows.Forms.Button btn_back1;
        private System.Windows.Forms.Button btn_back2;
    }
}