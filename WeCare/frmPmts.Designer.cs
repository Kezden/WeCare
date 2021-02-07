namespace WeCare
{
    partial class frmPmts
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btMarkPaid = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblOwed = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.lblBuyerPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(55, 173);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(637, 239);
            this.dgvData.TabIndex = 0;
            // 
            // btMarkPaid
            // 
            this.btMarkPaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarkPaid.Location = new System.Drawing.Point(55, 515);
            this.btMarkPaid.Name = "btMarkPaid";
            this.btMarkPaid.Size = new System.Drawing.Size(212, 54);
            this.btMarkPaid.TabIndex = 1;
            this.btMarkPaid.Text = "Mark Item As Paid";
            this.btMarkPaid.UseVisualStyleBackColor = true;
            this.btMarkPaid.Click += new System.EventHandler(this.btMarkPaid_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.Red;
            this.Label3.Location = new System.Drawing.Point(627, 546);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Total Owed";
            // 
            // lblOwed
            // 
            this.lblOwed.AutoSize = true;
            this.lblOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwed.ForeColor = System.Drawing.Color.Red;
            this.lblOwed.Location = new System.Drawing.Point(616, 515);
            this.lblOwed.Name = "lblOwed";
            this.lblOwed.Size = new System.Drawing.Size(76, 29);
            this.lblOwed.TabIndex = 14;
            this.lblOwed.Text = "$0.00";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(533, 546);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Amount Paid";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(522, 515);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(76, 29);
            this.lblPaid.TabIndex = 12;
            this.lblPaid.Text = "$0.00";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(442, 546);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Bid Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(428, 515);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 29);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "$0.00";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(369, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search for Name or Phone Number";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(617, 41);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 18;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Location = new System.Drawing.Point(75, 66);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(75, 13);
            this.lblBuyerName.TabIndex = 19;
            this.lblBuyerName.Text = "_buyerName_";
            // 
            // lblBuyerPhone
            // 
            this.lblBuyerPhone.AutoSize = true;
            this.lblBuyerPhone.Location = new System.Drawing.Point(75, 97);
            this.lblBuyerPhone.Name = "lblBuyerPhone";
            this.lblBuyerPhone.Size = new System.Drawing.Size(79, 13);
            this.lblBuyerPhone.TabIndex = 20;
            this.lblBuyerPhone.Text = "_buyerPhone_";
            // 
            // frmPmts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 608);
            this.Controls.Add(this.lblBuyerPhone);
            this.Controls.Add(this.lblBuyerName);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblOwed);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btMarkPaid);
            this.Controls.Add(this.dgvData);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPmts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPmtsName";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btMarkPaid;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblOwed;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblPaid;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.Label lblBuyerPhone;
    }
}