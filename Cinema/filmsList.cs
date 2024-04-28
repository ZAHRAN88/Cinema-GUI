namespace Cinema
{
    public partial class filmsList : Form
    {
        public static string selectedFilmName;
        
        public static PictureBox selectedImg=new PictureBox();
        public filmsList()
        {
            InitializeComponent();
            panel1.Click += panelclick;
            panel2.Click += panelclick;
            panel3.Click += panelclick;
            panel4.Click += panelclick;
            panel5.Click += panelclick;
            panel6.Click += panelclick;
            panel7.Click += panelclick;
            panel8.Click += panelclick;
            panel9.Click += panelclick;
            panel10.Click += panelclick;
            pictureBox1.Click += picclick;
            pictureBox2.Click += picclick;
            pictureBox3.Click += picclick;
            pictureBox4.Click += picclick;
            pictureBox5.Click += picclick;
            pictureBox6.Click += picclick;
            pictureBox7.Click += picclick;
            pictureBox8.Click += picclick;
            pictureBox9.Click += picclick;
            pictureBox10.Click += picclick;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getData(Panel p)
        {
           
            string panelNum = p.Name.ToString().Substring(5);
            PictureBox pictureBox = Controls.Find("pictureBox" + panelNum, true).FirstOrDefault() as PictureBox;
            selectedImg.Image = pictureBox.Image;
            Label label = Controls.Find("label" + panelNum, true).FirstOrDefault() as Label;
            selectedFilmName = label.Text;
            
        }
        private void getDataP(PictureBox p)
        {

            string panelNum = p.Name.ToString().Substring(10);
            PictureBox pictureBox = Controls.Find("pictureBox" + panelNum, true).FirstOrDefault() as PictureBox;
            selectedImg.Image = pictureBox.Image;
            Label label = Controls.Find("label" + panelNum, true).FirstOrDefault() as Label;
            selectedFilmName = label.Text;
        }
        private void panelclick(object sender, EventArgs e)
        {
            filmDetails film= new filmDetails();
          
            getData(sender as Panel);
            this.Hide();
            film.Show();
            
        }
        private void picclick(object sender, EventArgs e)
        {
            filmDetails film = new filmDetails();

            getDataP(sender as PictureBox);
            this.Hide();
            film.Show();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}