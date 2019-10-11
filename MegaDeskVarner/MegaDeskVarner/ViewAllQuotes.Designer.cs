namespace MegaDeskVarner
{
    partial class ViewAllQuotes
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
            this.closeViewQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeViewQuotes
            // 
            this.closeViewQuotes.Location = new System.Drawing.Point(237, 340);
            this.closeViewQuotes.Name = "closeViewQuotes";
            this.closeViewQuotes.Size = new System.Drawing.Size(101, 42);
            this.closeViewQuotes.TabIndex = 0;
            this.closeViewQuotes.Text = "Close";
            this.closeViewQuotes.UseVisualStyleBackColor = true;
            this.closeViewQuotes.Click += new System.EventHandler(this.closeViewQuotes_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeViewQuotes;
            this.ClientSize = new System.Drawing.Size(350, 394);
            this.Controls.Add(this.closeViewQuotes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeViewQuotes;
    }
}