namespace Cinema
{
    partial class signUp
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
            gotoLogin = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            signUpBtn = new Button();
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
            panel1.Controls.Add(gotoLogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(signUpBtn);
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
            panel1.Size = new Size(655, 672);
            panel1.TabIndex = 0;
            // 
            // gotoLogin
            // 
            gotoLogin.AutoSize = true;
            gotoLogin.Location = new Point(233, 617);
            gotoLogin.Name = "gotoLogin";
            gotoLogin.Size = new Size(204, 15);
            gotoLogin.TabIndex = 16;
            gotoLogin.Text = "Already have an account? Login now!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 393);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 24);
            label5.TabIndex = 15;
            label5.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 384);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 33);
            textBox1.TabIndex = 14;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.FromArgb(0, 18, 50);
            signUpBtn.FlatAppearance.BorderColor = Color.FromArgb(130, 82, 78);
            signUpBtn.FlatAppearance.BorderSize = 0;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBtn.ForeColor = Color.White;
            signUpBtn.Location = new Point(233, 536);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(204, 53);
            signUpBtn.TabIndex = 13;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            // 
            // Erorr
            // 
            Erorr.AutoSize = true;
            Erorr.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Erorr.ForeColor = Color.FromArgb(192, 0, 0);
            Erorr.Location = new Point(18, 492);
            Erorr.Margin = new Padding(4, 0, 4, 0);
            Erorr.Name = "Erorr";
            Erorr.Size = new Size(41, 15);
            Erorr.TabIndex = 7;
            Erorr.Text = "label5";
            Erorr.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 333);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 265);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 5;
            label3.Text = "User name";
            // 
            // password
            // 
            password.Location = new Point(187, 324);
            password.Margin = new Padding(4, 3, 4, 3);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(335, 33);
            password.TabIndex = 4;
            password.TextChanged += password_TextChanged;
            // 
            // userName
            // 
            userName.Location = new Point(187, 265);
            userName.Margin = new Padding(4, 3, 4, 3);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.Size = new Size(335, 32);
            userName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(148, 137, 121);
            label2.Location = new Point(266, 108);
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
            label1.Location = new Point(252, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 18, 50);
            ClientSize = new Size(735, 738);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(4, 3, 4, 3);
            Name = "signUp";
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
        private Button signUpBtn;
        private Label label5;
        private TextBox textBox1;
        private Label gotoLogin;
    }
}