namespace project1
{
    partial class test
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
            dataGridView1 = new DataGridView();
            Status = new DataGridViewTextBoxColumn();
            Firstname = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Film = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Status, Firstname, Column1, Film, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(843, 687);
            dataGridView1.TabIndex = 0;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Firstname
            // 
            Firstname.HeaderText = "First name";
            Firstname.Name = "Firstname";
            // 
            // Column1
            // 
            Column1.HeaderText = "Last name";
            Column1.Name = "Column1";
            // 
            // Film
            // 
            Film.HeaderText = "Film";
            Film.Name = "Film";
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Time";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Seat";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "ID";
            Column6.Name = "Column6";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 687);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Film;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}