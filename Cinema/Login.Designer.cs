namespace Cinema
{
    partial class Login
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
            panel1 = new Panel();
            gotoSignUp = new Label();
            loginBtn = new Button();
            Erorr = new Label();
            label4 = new Label();
            label3 = new Label();
            password = new TextBox();
            userName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 32, 85);
            panel1.Controls.Add(gotoSignUp);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(Erorr);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(password);
            panel1.Controls.Add(userName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(40, 35);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 672);
            panel1.TabIndex = 0;
            // 
            // gotoSignUp
            // 
            gotoSignUp.AutoSize = true;
            gotoSignUp.Location = new Point(194, 611);
            gotoSignUp.Name = "gotoSignUp";
            gotoSignUp.Size = new Size(207, 15);
            gotoSignUp.TabIndex = 17;
            gotoSignUp.Text = "Don't Have an account? Register now!";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(0, 18, 50);
            loginBtn.FlatAppearance.BorderColor = Color.FromArgb(130, 82, 78);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(194, 536);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(204, 53);
            loginBtn.TabIndex = 13;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            // 
            // Erorr
            // 
            Erorr.AutoSize = true;
            Erorr.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Erorr.ForeColor = Color.FromArgb(192, 0, 0);
            Erorr.Location = new Point(259, 472);
            Erorr.Margin = new Padding(4, 0, 4, 0);
            Erorr.Name = "Erorr";
            Erorr.Size = new Size(47, 15);
            Erorr.TabIndex = 7;
            Erorr.Text = "label5";
            Erorr.TextAlign = ContentAlignment.MiddleLeft;
            Erorr.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 436);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 6;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 360);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 5;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // password
            // 
            password.Location = new Point(165, 427);
            password.Margin = new Padding(4, 3, 4, 3);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(264, 33);
            password.TabIndex = 4;
            // 
            // userName
            // 
            userName.Location = new Point(164, 352);
            userName.Margin = new Padding(4, 3, 4, 3);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.Size = new Size(264, 32);
            userName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(148, 137, 121);
            label2.Location = new Point(212, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 1;
            label2.Text = " To our cinema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(194, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 18, 50);
            ClientSize = new Size(662, 738);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label Erorr;
        private Button loginBtn;
        private Label gotoSignUp;
    }
}