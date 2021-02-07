namespace WeCare
{
    partial class frmItemAdded
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btClone = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(92, 153);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(137, 52);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "ADD NEW";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClone
            // 
            this.btClone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClone.Location = new System.Drawing.Point(316, 153);
            this.btClone.Name = "btClone";
            this.btClone.Size = new System.Drawing.Size(137, 52);
            this.btClone.TabIndex = 1;
            this.btClone.Text = "CLONE";
            this.btClone.UseVisualStyleBackColor = true;
            this.btClone.Click += new System.EventHandler(this.btClone_Click);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(12, 21);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(521, 129);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "_keyword_ added successfully with Item Index #";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmItemAdded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 217);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btClone);
            this.Controls.Add(this.btAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemAdded";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClone;
        private System.Windows.Forms.Label lblText;
    }
}