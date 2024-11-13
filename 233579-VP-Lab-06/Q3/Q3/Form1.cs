namespace Q3

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up ListView columns for "Number" and "Square"
            listView1.View = View.Details;
            listView1.Columns.Add("Number", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Square", 100, HorizontalAlignment.Left);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // Clear existing items before calculation
            CalculateAndDisplaySquares(10);
        }

        private void CalculateAndDisplaySquares(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                int square = CalculateSquare(i);
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(square.ToString());
                listView1.Items.Add(item);
            }
        }

        private int CalculateSquare(int number)
        {
            return number * number;
        }
    }
}
