namespace Q8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f= new FolderBrowserDialog();
            if(f.ShowDialog() == DialogResult.OK )
            {
                textBox1.Text=f.SelectedPath;

                string selcted_folder = f.SelectedPath;

                using (OpenFileDialog o = new OpenFileDialog())
                {
                    o.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    o.InitialDirectory = selcted_folder;

                    if(o.ShowDialog() == DialogResult.OK )
                    {
                        pictureBox1.Image=new Bitmap(o.FileName);
                    }
                }
            }
        }
    }
}
