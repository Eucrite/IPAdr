namespace IpAdr
{
    partial class frmIpAdr
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
         this.lblIP = new System.Windows.Forms.Label();
         this.lblLocation = new System.Windows.Forms.Label();
         this.dgvIpAdr = new System.Windows.Forms.DataGridView();
         this.colFlag = new System.Windows.Forms.DataGridViewImageColumn();
         this.colCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colIpAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnRefresh = new System.Windows.Forms.Button();
         this.lblLocalIp = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dgvIpAdr)).BeginInit();
         this.SuspendLayout();
         // 
         // lblIP
         // 
         this.lblIP.AutoSize = true;
         this.lblIP.Location = new System.Drawing.Point(32, 31);
         this.lblIP.Name = "lblIP";
         this.lblIP.Size = new System.Drawing.Size(48, 13);
         this.lblIP.TabIndex = 0;
         this.lblIP.Text = "Your IP: ";
         // 
         // lblLocation
         // 
         this.lblLocation.AutoSize = true;
         this.lblLocation.Location = new System.Drawing.Point(32, 9);
         this.lblLocation.Name = "lblLocation";
         this.lblLocation.Size = new System.Drawing.Size(79, 13);
         this.lblLocation.TabIndex = 1;
         this.lblLocation.Text = "Your Location: ";
         // 
         // dgvIpAdr
         // 
         this.dgvIpAdr.AllowUserToAddRows = false;
         this.dgvIpAdr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvIpAdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvIpAdr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFlag,
            this.colCountryName,
            this.colIpAdr});
         this.dgvIpAdr.Location = new System.Drawing.Point(35, 79);
         this.dgvIpAdr.Name = "dgvIpAdr";
         this.dgvIpAdr.RowHeadersVisible = false;
         this.dgvIpAdr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         this.dgvIpAdr.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvIpAdr.Size = new System.Drawing.Size(371, 220);
         this.dgvIpAdr.TabIndex = 2;
         // 
         // colFlag
         // 
         this.colFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.colFlag.FillWeight = 30.45685F;
         this.colFlag.HeaderText = "Flag";
         this.colFlag.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
         this.colFlag.Name = "colFlag";
         this.colFlag.ReadOnly = true;
         this.colFlag.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         // 
         // colCountryName
         // 
         this.colCountryName.FillWeight = 134.7716F;
         this.colCountryName.HeaderText = "Country Name";
         this.colCountryName.Name = "colCountryName";
         this.colCountryName.ReadOnly = true;
         this.colCountryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         // 
         // colIpAdr
         // 
         this.colIpAdr.FillWeight = 134.7716F;
         this.colIpAdr.HeaderText = "IP Address";
         this.colIpAdr.Name = "colIpAdr";
         this.colIpAdr.ReadOnly = true;
         this.colIpAdr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         // 
         // btnRefresh
         // 
         this.btnRefresh.Location = new System.Drawing.Point(331, 318);
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.Size = new System.Drawing.Size(75, 23);
         this.btnRefresh.TabIndex = 3;
         this.btnRefresh.Text = "Refresh";
         this.btnRefresh.UseVisualStyleBackColor = true;
         this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
         // 
         // lblLocalIp
         // 
         this.lblLocalIp.AutoSize = true;
         this.lblLocalIp.Location = new System.Drawing.Point(32, 54);
         this.lblLocalIp.Name = "lblLocalIp";
         this.lblLocalIp.Size = new System.Drawing.Size(77, 13);
         this.lblLocalIp.TabIndex = 4;
         this.lblLocalIp.Text = "Your Local IP: ";
         // 
         // frmIpAdr
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(464, 353);
         this.Controls.Add(this.lblLocalIp);
         this.Controls.Add(this.btnRefresh);
         this.Controls.Add(this.dgvIpAdr);
         this.Controls.Add(this.lblLocation);
         this.Controls.Add(this.lblIP);
         this.Name = "frmIpAdr";
         this.Text = "IpAdr";
         this.Load += new System.EventHandler(this.frmIpAdr_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvIpAdr)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataGridView dgvIpAdr;
      private System.Windows.Forms.Button btnRefresh;
      private System.Windows.Forms.DataGridViewImageColumn colFlag;
      private System.Windows.Forms.DataGridViewTextBoxColumn colCountryName;
      private System.Windows.Forms.DataGridViewTextBoxColumn colIpAdr;
      private System.Windows.Forms.Label lblLocalIp;
   }
}

