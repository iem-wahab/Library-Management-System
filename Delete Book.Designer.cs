namespace DB_Lab_Project
{
    partial class Delete_Book
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
            this.BookPublisherID_Input = new System.Windows.Forms.TextBox();
            this.UpdateBook_Adminbtn = new System.Windows.Forms.Button();
            this.BookEdition_Input = new System.Windows.Forms.TextBox();
            this.BookQuantity_Input = new System.Windows.Forms.TextBox();
            this.BookTitle_Input = new System.Windows.Forms.TextBox();
            this.DeleteBook_btn = new System.Windows.Forms.Button();
            this.BookID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBooksGrid
            // 
            this.AllBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksGrid.Location = new System.Drawing.Point(280, 32);
            this.AllBooksGrid.Name = "AllBooksGrid";
            this.AllBooksGrid.Size = new System.Drawing.Size(620, 416);
            this.AllBooksGrid.TabIndex = 0;
            this.AllBooksGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllBooksGrid_CellContentClick);
            // 
            // BookPublisherID_Input
            // 
            this.BookPublisherID_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookPublisherID_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublisherID_Input.ForeColor = System.Drawing.Color.DimGray;
            this.BookPublisherID_Input.Location = new System.Drawing.Point(75, 254);
            this.BookPublisherID_Input.Multiline = true;
            this.BookPublisherID_Input.Name = "BookPublisherID_Input";
            this.BookPublisherID_Input.Size = new System.Drawing.Size(125, 27);
            this.BookPublisherID_Input.TabIndex = 25;
            this.BookPublisherID_Input.Text = "Publisher ID";
            // 
            // UpdateBook_Adminbtn
            // 
            this.UpdateBook_Adminbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UpdateBook_Adminbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBook_Adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBook_Adminbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBook_Adminbtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBook_Adminbtn.Location = new System.Drawing.Point(17, 370);
            this.UpdateBook_Adminbtn.Name = "UpdateBook_Adminbtn";
            this.UpdateBook_Adminbtn.Size = new System.Drawing.Size(92, 45);
            this.UpdateBook_Adminbtn.TabIndex = 24;
            this.UpdateBook_Adminbtn.Text = "UPDATE";
            this.UpdateBook_Adminbtn.UseVisualStyleBackColor = false;
            this.UpdateBook_Adminbtn.Click += new System.EventHandler(this.UpdateBook_Adminbtn_Click);
            // 
            // BookEdition_Input
            // 
            this.BookEdition_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookEdition_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookEdition_Input.ForeColor = System.Drawing.Color.DimGray;
            this.BookEdition_Input.Location = new System.Drawing.Point(75, 194);
            this.BookEdition_Input.Multiline = true;
            this.BookEdition_Input.Name = "BookEdition_Input";
            this.BookEdition_Input.Size = new System.Drawing.Size(125, 27);
            this.BookEdition_Input.TabIndex = 23;
            this.BookEdition_Input.Text = "Book Edition";
            // 
            // BookQuantity_Input
            // 
            this.BookQuantity_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookQuantity_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookQuantity_Input.ForeColor = System.Drawing.Color.DimGray;
            this.BookQuantity_Input.Location = new System.Drawing.Point(75, 138);
            this.BookQuantity_Input.Multiline = true;
            this.BookQuantity_Input.Name = "BookQuantity_Input";
            this.BookQuantity_Input.Size = new System.Drawing.Size(122, 27);
            this.BookQuantity_Input.TabIndex = 22;
            this.BookQuantity_Input.Text = "Book Quantity";
            // 
            // BookTitle_Input
            // 
            this.BookTitle_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookTitle_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle_Input.ForeColor = System.Drawing.Color.DimGray;
            this.BookTitle_Input.Location = new System.Drawing.Point(75, 85);
            this.BookTitle_Input.Multiline = true;
            this.BookTitle_Input.Name = "BookTitle_Input";
            this.BookTitle_Input.Size = new System.Drawing.Size(125, 30);
            this.BookTitle_Input.TabIndex = 21;
            this.BookTitle_Input.Text = "Book Title";
            // 
            // DeleteBook_btn
            // 
            this.DeleteBook_btn.BackColor = System.Drawing.Color.Red;
            this.DeleteBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBook_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBook_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteBook_btn.Location = new System.Drawing.Point(174, 370);
            this.DeleteBook_btn.Name = "DeleteBook_btn";
            this.DeleteBook_btn.Size = new System.Drawing.Size(92, 45);
            this.DeleteBook_btn.TabIndex = 26;
            this.DeleteBook_btn.Text = "DELETE";
            this.DeleteBook_btn.UseVisualStyleBackColor = false;
            this.DeleteBook_btn.Click += new System.EventHandler(this.DeleteBook_btn_Click);
            // 
            // BookID
            // 
            this.BookID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookID.ForeColor = System.Drawing.Color.DimGray;
            this.BookID.Location = new System.Drawing.Point(75, 32);
            this.BookID.Multiline = true;
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(125, 30);
            this.BookID.TabIndex = 27;
            this.BookID.Text = "Book ID";
            // 
            // Delete_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.DeleteBook_btn);
            this.Controls.Add(this.BookPublisherID_Input);
            this.Controls.Add(this.UpdateBook_Adminbtn);
            this.Controls.Add(this.BookEdition_Input);
            this.Controls.Add(this.BookQuantity_Input);
            this.Controls.Add(this.BookTitle_Input);
            this.Controls.Add(this.AllBooksGrid);
            this.Name = "Delete_Book";
            this.Text = "Delete_Book";
            this.Load += new System.EventHandler(this.Delete_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllBooksGrid;
        private System.Windows.Forms.TextBox BookPublisherID_Input;
        private System.Windows.Forms.Button UpdateBook_Adminbtn;
        private System.Windows.Forms.TextBox BookEdition_Input;
        private System.Windows.Forms.TextBox BookQuantity_Input;
        private System.Windows.Forms.TextBox BookTitle_Input;
        private System.Windows.Forms.Button DeleteBook_btn;
        private System.Windows.Forms.TextBox BookID;
    }
}