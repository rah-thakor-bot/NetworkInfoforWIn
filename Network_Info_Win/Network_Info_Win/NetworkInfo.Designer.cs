namespace Network_Info_Win
{
    partial class NetworkInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpNetworkInfo = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnChangeCredential = new System.Windows.Forms.Button();
            this.panelCredential = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUserValidatingStr = new System.Windows.Forms.Label();
            this.btnSaveCredential = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grpCredential = new System.Windows.Forms.GroupBox();
            this.grdBasicInfo = new System.Windows.Forms.DataGridView();
            this.grpProcessor = new System.Windows.Forms.GroupBox();
            this.grdHardware = new System.Windows.Forms.DataGridView();
            this.grpPrograms = new System.Windows.Forms.GroupBox();
            this.grdPrograms = new System.Windows.Forms.DataGridView();
            this.grpNetworkInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelCredential.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.grpCredential.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBasicInfo)).BeginInit();
            this.grpProcessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHardware)).BeginInit();
            this.grpPrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrograms)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNetworkInfo
            // 
            this.grpNetworkInfo.Controls.Add(this.splitContainer1);
            this.grpNetworkInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNetworkInfo.Location = new System.Drawing.Point(0, 0);
            this.grpNetworkInfo.Name = "grpNetworkInfo";
            this.grpNetworkInfo.Size = new System.Drawing.Size(842, 732);
            this.grpNetworkInfo.TabIndex = 0;
            this.grpNetworkInfo.TabStop = false;
            this.grpNetworkInfo.Text = "Network Information";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnChangeCredential);
            this.splitContainer1.Panel1.Controls.Add(this.panelCredential);
            this.splitContainer1.Panel1.Controls.Add(this.lblIP);
            this.splitContainer1.Panel1.Controls.Add(this.txtIP);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Reset);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(836, 713);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnChangeCredential
            // 
            this.btnChangeCredential.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCredential.Location = new System.Drawing.Point(108, 90);
            this.btnChangeCredential.Name = "btnChangeCredential";
            this.btnChangeCredential.Size = new System.Drawing.Size(197, 23);
            this.btnChangeCredential.TabIndex = 11;
            this.btnChangeCredential.Text = "Click here to change credential";
            this.btnChangeCredential.UseVisualStyleBackColor = true;
            this.btnChangeCredential.Click += new System.EventHandler(this.btnChangeCredential_Click);
            // 
            // panelCredential
            // 
            this.panelCredential.Controls.Add(this.button1);
            this.panelCredential.Controls.Add(this.lblUserValidatingStr);
            this.panelCredential.Controls.Add(this.btnSaveCredential);
            this.panelCredential.Controls.Add(this.label2);
            this.panelCredential.Controls.Add(this.lblUserName);
            this.panelCredential.Controls.Add(this.txtPassword);
            this.panelCredential.Controls.Add(this.txtUsername);
            this.panelCredential.Location = new System.Drawing.Point(331, 11);
            this.panelCredential.Name = "panelCredential";
            this.panelCredential.Size = new System.Drawing.Size(317, 126);
            this.panelCredential.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUserValidatingStr
            // 
            this.lblUserValidatingStr.AutoSize = true;
            this.lblUserValidatingStr.BackColor = System.Drawing.Color.OrangeRed;
            this.lblUserValidatingStr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserValidatingStr.ForeColor = System.Drawing.Color.Snow;
            this.lblUserValidatingStr.Location = new System.Drawing.Point(104, 35);
            this.lblUserValidatingStr.Name = "lblUserValidatingStr";
            this.lblUserValidatingStr.Size = new System.Drawing.Size(110, 15);
            this.lblUserValidatingStr.TabIndex = 5;
            this.lblUserValidatingStr.Text = "*domain\\username";
            // 
            // btnSaveCredential
            // 
            this.btnSaveCredential.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCredential.Location = new System.Drawing.Point(101, 88);
            this.btnSaveCredential.Name = "btnSaveCredential";
            this.btnSaveCredential.Size = new System.Drawing.Size(125, 23);
            this.btnSaveCredential.TabIndex = 4;
            this.btnSaveCredential.Text = "Save Credential";
            this.btnSaveCredential.UseVisualStyleBackColor = true;
            this.btnSaveCredential.Click += new System.EventHandler(this.btnCredential_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(31, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 15);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(101, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(213, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(101, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(213, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(12, 26);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(62, 15);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "IP Address";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(108, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(197, 23);
            this.txtIP.TabIndex = 0;
            this.txtIP.Enter += new System.EventHandler(this.txtIP_Enter);
            this.txtIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIP_KeyDown);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(246, 51);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(59, 23);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(108, 51);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(120, 23);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "Show Information";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grpPrograms);
            this.splitContainer2.Size = new System.Drawing.Size(836, 569);
            this.splitContainer2.SplitterDistance = 478;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grpCredential);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.grpProcessor);
            this.splitContainer3.Size = new System.Drawing.Size(478, 569);
            this.splitContainer3.SplitterDistance = 264;
            this.splitContainer3.TabIndex = 0;
            // 
            // grpCredential
            // 
            this.grpCredential.Controls.Add(this.grdBasicInfo);
            this.grpCredential.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCredential.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCredential.Location = new System.Drawing.Point(0, 0);
            this.grpCredential.Name = "grpCredential";
            this.grpCredential.Size = new System.Drawing.Size(478, 264);
            this.grpCredential.TabIndex = 1;
            this.grpCredential.TabStop = false;
            this.grpCredential.Text = "Basic information";
            // 
            // grdBasicInfo
            // 
            this.grdBasicInfo.BackgroundColor = System.Drawing.Color.Snow;
            this.grdBasicInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grdBasicInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBasicInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBasicInfo.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdBasicInfo.Location = new System.Drawing.Point(3, 19);
            this.grdBasicInfo.MultiSelect = false;
            this.grdBasicInfo.Name = "grdBasicInfo";
            this.grdBasicInfo.ReadOnly = true;
            this.grdBasicInfo.RowHeadersVisible = false;
            this.grdBasicInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Snow;
            this.grdBasicInfo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdBasicInfo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grdBasicInfo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdBasicInfo.RowTemplate.ReadOnly = true;
            this.grdBasicInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBasicInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBasicInfo.Size = new System.Drawing.Size(472, 242);
            this.grdBasicInfo.TabIndex = 0;
            // 
            // grpProcessor
            // 
            this.grpProcessor.Controls.Add(this.grdHardware);
            this.grpProcessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProcessor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProcessor.Location = new System.Drawing.Point(0, 0);
            this.grpProcessor.Name = "grpProcessor";
            this.grpProcessor.Size = new System.Drawing.Size(478, 301);
            this.grpProcessor.TabIndex = 1;
            this.grpProcessor.TabStop = false;
            this.grpProcessor.Text = "Hardware information";
            // 
            // grdHardware
            // 
            this.grdHardware.BackgroundColor = System.Drawing.Color.Snow;
            this.grdHardware.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grdHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHardware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHardware.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdHardware.Location = new System.Drawing.Point(3, 19);
            this.grdHardware.MultiSelect = false;
            this.grdHardware.Name = "grdHardware";
            this.grdHardware.ReadOnly = true;
            this.grdHardware.RowHeadersVisible = false;
            this.grdHardware.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Snow;
            this.grdHardware.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdHardware.RowTemplate.ReadOnly = true;
            this.grdHardware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHardware.Size = new System.Drawing.Size(472, 279);
            this.grdHardware.TabIndex = 0;
            // 
            // grpPrograms
            // 
            this.grpPrograms.Controls.Add(this.grdPrograms);
            this.grpPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrograms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrograms.Location = new System.Drawing.Point(0, 0);
            this.grpPrograms.Name = "grpPrograms";
            this.grpPrograms.Size = new System.Drawing.Size(354, 569);
            this.grpPrograms.TabIndex = 0;
            this.grpPrograms.TabStop = false;
            this.grpPrograms.Text = "Programs installed";
            // 
            // grdPrograms
            // 
            this.grdPrograms.BackgroundColor = System.Drawing.Color.Snow;
            this.grdPrograms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grdPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPrograms.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdPrograms.Location = new System.Drawing.Point(3, 19);
            this.grdPrograms.MultiSelect = false;
            this.grdPrograms.Name = "grdPrograms";
            this.grdPrograms.ReadOnly = true;
            this.grdPrograms.RowHeadersVisible = false;
            this.grdPrograms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Snow;
            this.grdPrograms.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdPrograms.RowTemplate.ReadOnly = true;
            this.grdPrograms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPrograms.Size = new System.Drawing.Size(348, 547);
            this.grdPrograms.TabIndex = 0;
            // 
            // NetworkInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 732);
            this.Controls.Add(this.grpNetworkInfo);
            this.Name = "NetworkInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpNetworkInfo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelCredential.ResumeLayout(false);
            this.panelCredential.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.grpCredential.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBasicInfo)).EndInit();
            this.grpProcessor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHardware)).EndInit();
            this.grpPrograms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrograms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNetworkInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.DataGridView grdBasicInfo;
        private System.Windows.Forms.DataGridView grdHardware;
        private System.Windows.Forms.GroupBox grpCredential;
        private System.Windows.Forms.GroupBox grpProcessor;
        private System.Windows.Forms.GroupBox grpPrograms;
        private System.Windows.Forms.DataGridView grdPrograms;
        private System.Windows.Forms.Panel panelCredential;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSaveCredential;
        private System.Windows.Forms.Label lblUserValidatingStr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangeCredential;
    }
}

