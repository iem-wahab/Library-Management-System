namespace DB_Lab_Project
{
    partial class Add_Book
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
            this.AddBook_Adminbtn = new System.Windows.Forms.Button();
            this.BookEdition_Input = new System.Windows.Forms.TextBox();
            this.BookQuantity_Input = new System.Windows.Forms.TextBox();
            this.BookTitle_Input = new System.Windows.Forms.TextBox();
            this.BookPublisherID_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBook_Adminbtn
            // 
            this.AddBook_Adminbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AddBook_Adminbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBook_Adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook_Adminbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook_Adminbtn.ForeColor = System.Drawing.Color.White;
            this.AddBook_Adminbtn.Location = new System.Drawing.Point(297, 317);
            this.AddBook_Adminbtn.Name = "AddBook_Adminbtn";
            this.AddBook_Adminbtn.Size = new System.Drawing.Size(182, 48);
            this.AddBook_Adminbtn.TabIndex = 19;
            this.AddBook_Adminbtn.Text = "ADD";
            this.AddBook_Adminbtn.UseVisualStyleBackColor = false;
            this.AddBook_Adminbtn.Click += new System.EventHandler(this.AddBook_Adminbtn_Click);
            // 
            // BookEdition_Input
            // 
            this.BookEdition_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookEdition_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookEdition_Input.ForeColor = System.Drawing.Color.DimGray;
            this.BookEdition_Input.Location = new System.Drawing.Point(419, 92);
            this.BookEdition_Input.Multiline = true;
            this.BookEdition_Input.Name = "BookEdition_Input";
            this.BookEdition_Input.Size = new System.Drawing.Size(125, 27);
            this.BookEdition_Input.TabIndex = 17;
            this.BookEdition_Input.Text = "Book Edition";
            this.BookEdition_Input.TextChanged += new System.EventHandler(this.BookEdition_Input_TextChanged);
            // 
            // BookQuantity_Input
            // 
            this.BookQuantity_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookQuantity_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookQuantity_Input.ForeColor = System.Drawing.Color.DimGray;
            this.BookQuantity_Input.Location = new System.Drawing.Point(259, 147);
            this.BookQuantity_Input.Multiline = true;
            this.BookQuantity_Input.Name = "BookQuantity_Input";
            this.BookQuantity_Input.Size = new System.Drawing.Size(122, 27);
            this.BookQuantity_Input.TabIndex = 16;
            this.BookQuantity_Input.Text = "Book Quantity";
            this.BookQuantity_Input.TextChanged += new System.EventHandler(this.BookQuantity_Input_TextChanged);
            // 
            // BookTitle_Input
            // 
            this.BookTitle_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookTitle_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle_Input.ForeColor = System.Drawing.Color.DimGray;
            this.BookTitle_Input.Location = new System.Drawing.Point(259, 89);
            this.BookTitle_Input.Multiline = true;
            this.BookTitle_Input.Name = "BookTitle_Input";
            this.BookTitle_Input.Size = new System.Drawing.Size(125, 30);
            this.BookTitle_Input.TabIndex = 15;
            this.BookTitle_Input.Text = "Book Title";
            this.BookTitle_Input.TextChanged += new System.EventHandler(this.BookTitle_Input_TextChanged);
            // 
            // BookPublisherID_Input
            // 
            this.BookPublisherID_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookPublisherID_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublisherID_Input.ForeColor = System.Drawing.Color.DimGray;
            this.BookPublisherID_Input.Location = new System.Drawing.Point(259, 203);
            this.BookPublisherID_Input.Multiline = true;
            this.BookPublisherID_Input.Name = "BookPublisherID_Input";
            this.BookPublisherID_Input.Size = new System.Drawing.Size(125, 27);
            this.BookPublisherID_Input.TabIndex = 20;
            this.BookPublisherID_Input.Text = "Publisher ID";
            this.BookPublisherID_Input.TextChanged += new System.EventHandler(this.BookPublisherID_Input_TextChanged);
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookPublisherID_Input);
            this.Controls.Add(this.AddBook_Adminbtn);
            this.Controls.Add(this.BookEdition_Input);
            this.Controls.Add(this.BookQuantity_Input);
            this.Controls.Add(this.BookTitle_Input);
            this.Name = "Add_Book";
            this.Text = "Add_Book";
            this.Load += new System.EventHandler(this.Add_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBook_Adminbtn;
        private System.Windows.Forms.TextBox BookEdition_Input;
        private System.Windows.Forms.TextBox BookQuantity_Input;
        private System.Windows.Forms.TextBox BookTitle_Input;
        private System.Windows.Forms.TextBox BookPublisherID_Input;
    }
}