namespace WeCare
{
    partial class frmBidMgr
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
            this.btWinner = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCheckSmall = new System.Windows.Forms.CheckBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numBidLot = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBidLot)).BeginInit();
            this.SuspendLayout();
            // 
            // btWinner
            // 
            this.btWinner.Location = new System.Drawing.Point(646, 666);
            this.btWinner.Name = "btWinner";
            this.btWinner.Size = new System.Drawing.Size(105, 43);
            this.btWinner.TabIndex = 25;
            this.btWinner.Text = "Enter Winner";
            this.btWinner.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(356, 666);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(105, 43);
            this.btPrint.TabIndex = 24;
            this.btPrint.Text = "Print Bid Lot";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(110, 666);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(105, 43);
            this.btRemove.TabIndex = 23;
            this.btRemove.Text = "Remove Item";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(110, 453);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(640, 160);
            this.listBox1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 235);
            this.dataGridView1.TabIndex = 21;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(723, 59);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 22);
            this.numericUpDown2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lot Size:";
            // 
            // tbCheckSmall
            // 
            this.tbCheckSmall.AutoSize = true;
            this.tbCheckSmall.Location = new System.Drawing.Point(440, 59);
            this.tbCheckSmall.Name = "tbCheckSmall";
            this.tbCheckSmall.Size = new System.Drawing.Size(201, 17);
            this.tbCheckSmall.TabIndex = 18;
            this.tbCheckSmall.Text = "CHECK FOR SMALL ITEMS OR LOTS";
            this.tbCheckSmall.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(690, 18);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 17;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(545, 15);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(68, 22);
            this.txtIndex.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Item Index #:";
            // 
            // numBidLot
            // 
            this.numBidLot.Location = new System.Drawing.Point(147, 54);
            this.numBidLot.Name = "numBidLot";
            this.numBidLot.Size = new System.Drawing.Size(68, 22);
            this.numBidLot.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bid Lot:";
            // 
            // frmBidMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 773);
            this.Controls.Add(this.btWinner);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCheckSmall);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numBidLot);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBidMgr";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBidMgr";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBidLot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWinner;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox tbCheckSmall;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBidLot;
        private System.Windows.Forms.Label label1;
    }
}