namespace DB_Lab_Project
{
    partial class See_All_Books
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
            this.AllBooksGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBooksGrid
            // 
            this.AllBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksGrid.Location = new System.Drawing.Point(-1, 86);
            this.AllBooksGrid.Name = "AllBooksGrid";
            this.AllBooksGrid.Size = new System.Drawing.Size(635, 361);
            this.AllBooksGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books";
            // 
            // See_All_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllBooksGrid);
            this.Name = "See_All_Books";
            this.Text = "See_All_Books";
            this.Load += new System.EventHandler(this.See_All_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllBooksGrid;
        private System.Windows.Forms.Label label1;
    }
}