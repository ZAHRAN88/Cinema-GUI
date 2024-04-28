using System.Windows.Forms;

namespace Cinema
{
    public partial class Booking_Form : Form
    {
        public static string time;
        public static string date;
        public Booking_Form()
        {

            InitializeComponent();



        }






        public static List<string> bookedChairs = new List<string>();
        public static bool AreImagesEqual(Image image1, Image image2)
        {
            // Check if both images are null
            if (image1 == null && image2 == null)
                return true;

            // Check if only one of the images is null
            if (image1 == null || image2 == null)
                return false;

            // Check if images have different dimensions
            if (image1.Size != image2.Size)
                return false;

            // Create Bitmap objects from images
            Bitmap bmp1 = new Bitmap(image1);
            Bitmap bmp2 = new Bitmap(image2);

            // Compare each pixel in the images
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        return false;
                }
            }

            // Images are equal
            return true;
        }

        private void click_chair(object sender, EventArgs e)
        {
            PictureBox c = sender as PictureBox;
            if (AreImagesEqual(c.Image, book_c.Image))
            {

                MessageBox.Show("This chair is already booked");
            }
            else
            {
                c.Image =
                    (AreImagesEqual(c.Image, select_c.Image))
                    ? global::Cinema.Properties.Resources.Lawson_Chair
                    : global::Cinema.Properties.Resources._new;


            }


        }

        private void book_chair(object sender, EventArgs e)
        {
            PictureBox c = sender as PictureBox;
            if (AreImagesEqual(c.Image, book_c.Image))
            {
                MessageBox.Show("This chair is already booked");
            }
            else
            {
                bookedChairs.Add(c.Name);
                c.Image = Properties.Resources.red;
                if (bookedChairs.Count > 5)
                {
                    MessageBox.Show($"You can Book Up to 5 chairs only");
                }
                

            }
        }


        private void assign_handler()
        {
            ca1.Click += click_chair;
            ca1.DoubleClick += book_chair;
            ca2.Click += click_chair;
            ca2.DoubleClick += book_chair;
            ca3.Click += click_chair;
            ca3.DoubleClick += book_chair;
            ca4.Click += click_chair;
            ca4.DoubleClick += book_chair;
            ca5.Click += click_chair;

            ca5.DoubleClick += book_chair;
            ca6.Click += click_chair;
            ca6.DoubleClick += book_chair;
            cb1.Click += click_chair;
            cb1.DoubleClick += book_chair;
            cb2.Click += click_chair;
            cb2.DoubleClick += book_chair;
            cb3.Click += click_chair;

            cb3.DoubleClick += book_chair;
            cb4.Click += click_chair;
            cb4.DoubleClick += book_chair;
            cb5.Click += click_chair;
            cb5.DoubleClick += book_chair;
            cb6.Click += click_chair;
            cb6.DoubleClick += book_chair;
            cc1.Click += click_chair;
            cc1.DoubleClick += book_chair;
            cc2.Click += click_chair;
            cc2.DoubleClick += book_chair;
            cc3.Click += click_chair;
            cc3.DoubleClick += book_chair;
            cc4.Click += click_chair;
            cc4.DoubleClick += book_chair;
            cc5.Click += click_chair;
            cc5.DoubleClick += book_chair;
            cc6.Click += click_chair;
            cc6.DoubleClick += book_chair;
            cd1.Click += click_chair;
            cd1.DoubleClick += book_chair;
            cd2.Click += click_chair;
            cd2.DoubleClick += book_chair;
            cd3.Click += click_chair;
            cd3.DoubleClick += book_chair;
            cd4.Click += click_chair;
            cd4.DoubleClick += book_chair;
            cd5.Click += click_chair;
            cd5.DoubleClick += book_chair;
            cd6.Click += click_chair;
            cd6.DoubleClick += book_chair;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                // Check if the control is a PictureBox
                if (control is PictureBox pictureBox && pictureBox.Name.StartsWith("c"))
                {
                    // Assign click event handler
                    pictureBox.Click += click_chair;
                    // Assign double-click event handler
                    pictureBox.DoubleClick += book_chair;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            time = comboBox3.SelectedItem.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assign_handler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ticket h = new ticket();
            this.Hide();
            h.Show();
        }
    }
}
