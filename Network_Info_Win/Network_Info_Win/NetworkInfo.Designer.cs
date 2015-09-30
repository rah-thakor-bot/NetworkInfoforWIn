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
            this.grpNetworkInfo = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblIP);
            this.splitContainer1.Panel1.Controls.Add(this.txtIP);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Reset);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(836, 713);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(12, 26);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(58, 13);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "IP Address";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(108, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(169, 20);
            this.txtIP.TabIndex = 8;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(202, 51);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(108, 51);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 6;
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
            this.splitContainer2.Size = new System.Drawing.Size(836, 614);
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
            this.splitContainer3.Size = new System.Drawing.Size(478, 614);
            this.splitContainer3.SplitterDistance = 285;
            this.splitContainer3.TabIndex = 0;
            // 
            // grpCredential
            // 
            this.grpCredential.Controls.Add(this.grdBasicInfo);
            this.grpCredential.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCredential.Location = new System.Drawing.Point(0, 0);
            this.grpCredential.Name = "grpCredential";
            this.grpCredential.Size = new System.Drawing.Size(478, 285);
            this.grpCredential.TabIndex = 1;
            this.grpCredential.TabStop = false;
            this.grpCredential.Text = "Basic information";
            // 
            // grdBasicInfo
            // 
            this.grdBasicInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBasicInfo.Location = new System.Drawing.Point(3, 16);
            this.grdBasicInfo.Name = "grdBasicInfo";
            this.grdBasicInfo.RowHeadersVisible = false;
            this.grdBasicInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBasicInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBasicInfo.Size = new System.Drawing.Size(472, 266);
            this.grdBasicInfo.TabIndex = 0;
            // 
            // grpProcessor
            // 
            this.grpProcessor.Controls.Add(this.grdHardware);
            this.grpProcessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProcessor.Location = new System.Drawing.Point(0, 0);
            this.grpProcessor.Name = "grpProcessor";
            this.grpProcessor.Size = new System.Drawing.Size(478, 325);
            this.grpProcessor.TabIndex = 1;
            this.grpProcessor.TabStop = false;
            this.grpProcessor.Text = "Hardware information";
            // 
            // grdHardware
            // 
            this.grdHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHardware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHardware.Location = new System.Drawing.Point(3, 16);
            this.grdHardware.Name = "grdHardware";
            this.grdHardware.RowHeadersVisible = false;
            this.grdHardware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHardware.Size = new System.Drawing.Size(472, 306);
            this.grdHardware.TabIndex = 0;
            // 
            // grpPrograms
            // 
            this.grpPrograms.Controls.Add(this.grdPrograms);
            this.grpPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrograms.Location = new System.Drawing.Point(0, 0);
            this.grpPrograms.Name = "grpPrograms";
            this.grpPrograms.Size = new System.Drawing.Size(354, 614);
            this.grpPrograms.TabIndex = 0;
            this.grpPrograms.TabStop = false;
            this.grpPrograms.Text = "Programs installed";
            // 
            // grdPrograms
            // 
            this.grdPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPrograms.Location = new System.Drawing.Point(3, 16);
            this.grdPrograms.Name = "grdPrograms";
            this.grdPrograms.RowHeadersVisible = false;
            this.grdPrograms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPrograms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPrograms.Size = new System.Drawing.Size(348, 595);
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
    }
}

