namespace WeCare
{
    partial class frmMain
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
            this.btItemMgr = new System.Windows.Forms.Button();
            this.btBidMgr = new System.Windows.Forms.Button();
            this.btPmts = new System.Windows.Forms.Button();
            this.panControls = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btItemMgr
            // 
            this.btItemMgr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btItemMgr.Location = new System.Drawing.Point(11, 190);
            this.btItemMgr.Name = "btItemMgr";
            this.btItemMgr.Size = new System.Drawing.Size(169, 64);
            this.btItemMgr.TabIndex = 0;
            this.btItemMgr.Text = "Item Manager";
            this.btItemMgr.UseVisualStyleBackColor = true;
            this.btItemMgr.Click += new System.EventHandler(this.btItemMgr_Click);
            // 
            // btBidMgr
            // 
            this.btBidMgr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBidMgr.Location = new System.Drawing.Point(11, 276);
            this.btBidMgr.Name = "btBidMgr";
            this.btBidMgr.Size = new System.Drawing.Size(169, 64);
            this.btBidMgr.TabIndex = 1;
            this.btBidMgr.Text = "Bid Manager";
            this.btBidMgr.UseVisualStyleBackColor = true;
            this.btBidMgr.Click += new System.EventHandler(this.btBidMgr_Click);
            // 
            // btPmts
            // 
            this.btPmts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPmts.Location = new System.Drawing.Point(11, 455);
            this.btPmts.Name = "btPmts";
            this.btPmts.Size = new System.Drawing.Size(169, 64);
            this.btPmts.TabIndex = 2;
            this.btPmts.Text = "Payments";
            this.btPmts.UseVisualStyleBackColor = true;
            this.btPmts.Click += new System.EventHandler(this.btPmts_Click);
            // 
            // panControls
            // 
            this.panControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panControls.Controls.Add(this.pictureBox1);
            this.panControls.Controls.Add(this.btPmts);
            this.panControls.Controls.Add(this.btBidMgr);
            this.panControls.Controls.Add(this.btItemMgr);
            this.panControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panControls.Location = new System.Drawing.Point(0, 0);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(200, 729);
            this.panControls.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeCare.Properties.Resources.heart_holly2;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panControls);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.panControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btItemMgr;
        private System.Windows.Forms.Button btBidMgr;
        private System.Windows.Forms.Button btPmts;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

