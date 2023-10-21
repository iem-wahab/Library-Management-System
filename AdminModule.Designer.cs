namespace DB_Lab_Project
{
    partial class AdminModule
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
            this.AddBook_btn = new System.Windows.Forms.Button();
            this.UpdateBook_btn = new System.Windows.Forms.Button();
            this.DeleteBook_btn = new System.Windows.Forms.Button();
            this.SeeAllPerson_btn = new System.Windows.Forms.Button();
            this.SeeAllBooks_btn = new System.Windows.Forms.Button();
            this.AvailableBooks_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBook_btn
            // 
            this.AddBook_btn.Location = new System.Drawing.Point(82, 12);
            this.AddBook_btn.Name = "AddBook_btn";
            this.AddBook_btn.Size = new System.Drawing.Size(75, 23);
            this.AddBook_btn.TabIndex = 0;
            this.AddBook_btn.Text = "Add Book";
            this.AddBook_btn.UseVisualStyleBackColor = true;
            this.AddBook_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateBook_btn
            // 
            this.UpdateBook_btn.Location = new System.Drawing.Point(82, 108);
            this.UpdateBook_btn.Name = "UpdateBook_btn";
            this.UpdateBook_btn.Size = new System.Drawing.Size(101, 31);
            this.UpdateBook_btn.TabIndex = 1;
            this.UpdateBook_btn.Text = "Update Book";
            this.UpdateBook_btn.UseVisualStyleBackColor = true;
            this.UpdateBook_btn.Click += new System.EventHandler(this.UpdateBook_btn_Click);
            // 
            // DeleteBook_btn
            // 
            this.DeleteBook_btn.Location = new System.Drawing.Point(82, 55);
            this.DeleteBook_btn.Name = "DeleteBook_btn";
            this.DeleteBook_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBook_btn.TabIndex = 2;
            this.DeleteBook_btn.Text = "Delete Book";
            this.DeleteBook_btn.UseVisualStyleBackColor = true;
            this.DeleteBook_btn.Click += new System.EventHandler(this.DeleteBook_btn_Click);
            // 
            // SeeAllPerson_btn
            // 
            this.SeeAllPerson_btn.Location = new System.Drawing.Point(82, 249);
            this.SeeAllPerson_btn.Name = "SeeAllPerson_btn";
            this.SeeAllPerson_btn.Size = new System.Drawing.Size(137, 23);
            this.SeeAllPerson_btn.TabIndex = 3;
            this.SeeAllPerson_btn.Text = "See All Users";
            this.SeeAllPerson_btn.UseVisualStyleBackColor = true;
            this.SeeAllPerson_btn.Click += new System.EventHandler(this.SeeAllPerson_btn_Click);
            // 
            // SeeAllBooks_btn
            // 
            this.SeeAllBooks_btn.Location = new System.Drawing.Point(82, 158);
            this.SeeAllBooks_btn.Name = "SeeAllBooks_btn";
            this.SeeAllBooks_btn.Size = new System.Drawing.Size(111, 23);
            this.SeeAllBooks_btn.TabIndex = 5;
            this.SeeAllBooks_btn.Text = "See All Books";
            this.SeeAllBooks_btn.UseVisualStyleBackColor = true;
            this.SeeAllBooks_btn.Click += new System.EventHandler(this.SeeAllBooks_btn_Click);
            // 
            // AvailableBooks_btn
            // 
            this.AvailableBooks_btn.Location = new System.Drawing.Point(82, 312);
            this.AvailableBooks_btn.Name = "AvailableBooks_btn";
            this.AvailableBooks_btn.Size = new System.Drawing.Size(162, 23);
            this.AvailableBooks_btn.TabIndex = 7;
            this.AvailableBooks_btn.Text = "Available Books";
            this.AvailableBooks_btn.UseVisualStyleBackColor = true;
            this.AvailableBooks_btn.Click += new System.EventHandler(this.AvailableBooks_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(82, 197);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(111, 30);
            this.Search_btn.TabIndex = 8;
            this.Search_btn.Text = "Sreach Book";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // AdminModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.AvailableBooks_btn);
            this.Controls.Add(this.SeeAllBooks_btn);
            this.Controls.Add(this.SeeAllPerson_btn);
            this.Controls.Add(this.DeleteBook_btn);
            this.Controls.Add(this.UpdateBook_btn);
            this.Controls.Add(this.AddBook_btn);
            this.Name = "AdminModule";
            this.Text = "Admin Module";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBook_btn;
        private System.Windows.Forms.Button UpdateBook_btn;
        private System.Windows.Forms.Button DeleteBook_btn;
        private System.Windows.Forms.Button SeeAllPerson_btn;
        private System.Windows.Forms.Button SeeAllBooks_btn;
        private System.Windows.Forms.Button AvailableBooks_btn;
        private System.Windows.Forms.Button Search_btn;
    }
}