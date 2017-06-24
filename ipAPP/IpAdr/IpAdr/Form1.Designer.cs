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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.colFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colIpAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // lblIP
         // 
         this.lblIP.AutoSize = true;
         this.lblIP.Location = new System.Drawing.Point(84, 41);
         this.lblIP.Name = "lblIP";
         this.lblIP.Size = new System.Drawing.Size(48, 13);
         this.lblIP.TabIndex = 0;
         this.lblIP.Text = "Your IP: ";
         // 
         // lblLocation
         // 
         this.lblLocation.AutoSize = true;
         this.lblLocation.Location = new System.Drawing.Point(56, 54);
         this.lblLocation.Name = "lblLocation";
         this.lblLocation.Size = new System.Drawing.Size(76, 13);
         this.lblLocation.TabIndex = 1;
         this.lblLocation.Text = "You Location: ";
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFlag,
            this.colCountryName,
            this.colIpAdr});
         this.dataGridView1.Location = new System.Drawing.Point(35, 108);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(346, 233);
         this.dataGridView1.TabIndex = 2;
         // 
         // colFlag
         // 
         this.colFlag.HeaderText = "Flag";
         this.colFlag.Name = "colFlag";
         this.colFlag.ReadOnly = true;
         // 
         // colCountryName
         // 
         this.colCountryName.HeaderText = "Country Name";
         this.colCountryName.Name = "colCountryName";
         this.colCountryName.ReadOnly = true;
         // 
         // colIpAdr
         // 
         this.colIpAdr.HeaderText = "IP Address";
         this.colIpAdr.Name = "colIpAdr";
         this.colIpAdr.ReadOnly = true;
         // 
         // frmIpAdr
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(464, 353);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.lblLocation);
         this.Controls.Add(this.lblIP);
         this.Name = "frmIpAdr";
         this.Text = "IpAdr";
         this.Load += new System.EventHandler(this.frmIpAdr_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlag;
      private System.Windows.Forms.DataGridViewTextBoxColumn colCountryName;
      private System.Windows.Forms.DataGridViewTextBoxColumn colIpAdr;
   }
}

