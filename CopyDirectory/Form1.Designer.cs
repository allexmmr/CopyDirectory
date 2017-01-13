namespace CopyDirectory
{
    partial class Form1
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
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(307, 80);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(31, 23);
            this.btnDestination.TabIndex = 20;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(307, 30);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(31, 23);
            this.btnSource.TabIndex = 19;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(15, 108);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 31);
            this.btnCopy.TabIndex = 18;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(15, 80);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(287, 22);
            this.txtDestination.TabIndex = 17;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(15, 31);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(287, 22);
            this.txtSource.TabIndex = 16;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(12, 60);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(140, 17);
            this.lblDestination.TabIndex = 15;
            this.lblDestination.Text = "Destination Directory";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 9);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(114, 17);
            this.lblSource.TabIndex = 14;
            this.lblSource.Text = "Source Directory";
            // 
            // listHistory
            // 
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ItemHeight = 16;
            this.listHistory.Location = new System.Drawing.Point(15, 189);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(322, 132);
            this.listHistory.TabIndex = 21;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(15, 166);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(52, 17);
            this.lblHistory.TabIndex = 22;
            this.lblHistory.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 333);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Label lblHistory;
    }
}

