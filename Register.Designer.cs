
namespace DB_Lab_Project
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName_Input = new System.Windows.Forms.TextBox();
            this.LastName_Input = new System.Windows.Forms.TextBox();
            this.Email_Input = new System.Windows.Forms.TextBox();
            this.Passward_Input = new System.Windows.Forms.TextBox();
            this.ConfirmPassward_Input = new System.Windows.Forms.TextBox();
            this.Register_Now = new System.Windows.Forms.Button();
            this.Close_Label1 = new System.Windows.Forms.Label();
            this.SignIn_Registration = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 2);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(231, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 2);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Create the account. It\'s free and only takes a minute.";
            // 
            // FirstName_Input
            // 
            this.FirstName_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.FirstName_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_Input.ForeColor = System.Drawing.Color.DimGray;
            this.FirstName_Input.Location = new System.Drawing.Point(23, 148);
            this.FirstName_Input.Multiline = true;
            this.FirstName_Input.Name = "FirstName_Input";
            this.FirstName_Input.Size = new System.Drawing.Size(125, 30);
            this.FirstName_Input.TabIndex = 8;
            this.FirstName_Input.Text = "First Name";
            // 
            // LastName_Input
            // 
            this.LastName_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LastName_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_Input.ForeColor = System.Drawing.Color.DimGray;
            this.LastName_Input.Location = new System.Drawing.Point(186, 148);
            this.LastName_Input.Multiline = true;
            this.LastName_Input.Name = "LastName_Input";
            this.LastName_Input.Size = new System.Drawing.Size(125, 30);
            this.LastName_Input.TabIndex = 9;
            this.LastName_Input.Text = "Last Name";
            // 
            // Email_Input
            // 
            this.Email_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Email_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Input.ForeColor = System.Drawing.Color.DimGray;
            this.Email_Input.Location = new System.Drawing.Point(26, 210);
            this.Email_Input.Multiline = true;
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(285, 27);
            this.Email_Input.TabIndex = 10;
            this.Email_Input.Text = "Email";
            // 
            // Passward_Input
            // 
            this.Passward_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Passward_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passward_Input.ForeColor = System.Drawing.Color.DimGray;
            this.Passward_Input.Location = new System.Drawing.Point(26, 265);
            this.Passward_Input.Multiline = true;
            this.Passward_Input.Name = "Passward_Input";
            this.Passward_Input.Size = new System.Drawing.Size(285, 27);
            this.Passward_Input.TabIndex = 11;
            this.Passward_Input.Text = "Passward";
            this.Passward_Input.TextChanged += new System.EventHandler(this.Passward_Input_TextChanged);
            // 
            // ConfirmPassward_Input
            // 
            this.ConfirmPassward_Input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ConfirmPassward_Input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassward_Input.ForeColor = System.Drawing.Color.DimGray;
            this.ConfirmPassward_Input.Location = new System.Drawing.Point(26, 321);
            this.ConfirmPassward_Input.Multiline = true;
            this.ConfirmPassward_Input.Name = "ConfirmPassward_Input";
            this.ConfirmPassward_Input.Size = new System.Drawing.Size(285, 27);
            this.ConfirmPassward_Input.TabIndex = 12;
            this.ConfirmPassward_Input.Text = "Confirm Passward";
            this.ConfirmPassward_Input.TextChanged += new System.EventHandler(this.ConfirmPassward_Input_TextChanged);
            // 
            // Register_Now
            // 
            this.Register_Now.BackColor = System.Drawing.Color.ForestGreen;
            this.Register_Now.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Now.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Now.ForeColor = System.Drawing.Color.White;
            this.Register_Now.Location = new System.Drawing.Point(64, 380);
            this.Register_Now.Name = "Register_Now";
            this.Register_Now.Size = new System.Drawing.Size(182, 48);
            this.Register_Now.TabIndex = 13;
            this.Register_Now.Text = "Register_Now";
            this.Register_Now.UseVisualStyleBackColor = false;
            // 
            // Close_Label1
            // 
            this.Close_Label1.AutoSize = true;
            this.Close_Label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Label1.ForeColor = System.Drawing.Color.Black;
            this.Close_Label1.Location = new System.Drawing.Point(302, 9);
            this.Close_Label1.Name = "Close_Label1";
            this.Close_Label1.Size = new System.Drawing.Size(17, 16);
            this.Close_Label1.TabIndex = 17;
            this.Close_Label1.Text = "X";
            this.Close_Label1.Click += new System.EventHandler(this.Close_Label1_Click);
            // 
            // SignIn_Registration
            // 
            this.SignIn_Registration.AutoSize = true;
            this.SignIn_Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn_Registration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Registration.ForeColor = System.Drawing.Color.DimGray;
            this.SignIn_Registration.Location = new System.Drawing.Point(275, 444);
            this.SignIn_Registration.Name = "SignIn_Registration";
            this.SignIn_Registration.Size = new System.Drawing.Size(48, 16);
            this.SignIn_Registration.TabIndex = 19;
            this.SignIn_Registration.Text = "Sign In";
            this.SignIn_Registration.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(278, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 1);
            this.panel3.TabIndex = 20;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(331, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SignIn_Registration);
            this.Controls.Add(this.Close_Label1);
            this.Controls.Add(this.Register_Now);
            this.Controls.Add(this.ConfirmPassward_Input);
            this.Controls.Add(this.Passward_Input);
            this.Controls.Add(this.Email_Input);
            this.Controls.Add(this.LastName_Input);
            this.Controls.Add(this.FirstName_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName_Input;
        private System.Windows.Forms.TextBox LastName_Input;
        private System.Windows.Forms.TextBox Email_Input;
        private System.Windows.Forms.TextBox Passward_Input;
        private System.Windows.Forms.TextBox ConfirmPassward_Input;
        private System.Windows.Forms.Button Register_Now;
        private System.Windows.Forms.Label Close_Label1;
        private System.Windows.Forms.Label SignIn_Registration;
        private System.Windows.Forms.Panel panel3;
    }
}