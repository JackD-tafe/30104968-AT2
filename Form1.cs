namespace _30104968_AT2_V1
{
    public partial class AstroForm : Form
    {
        public AstroForm()
        {
            InitializeComponent();
        }

        //Creates an array
        static int max = 24;
        int[] myArray = new int[max];
        bool empty = true;

        //Method to display the array that can be re-used in other button clicks.
        private void DisplayArray()
        {
            if (!empty)
            {
                ListBoxDisplay.Items.Clear();
                for (int i = 0; i < max; i++)
                {
                    ListBoxDisplay.Items.Add(myArray[i]);
                }
            }
            //Error catching
            else
                MessageBox.Show("Nothing to display");
        }
        //Fills array with random numbers
        Random rnd = new Random();
        private void btnLoadButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < max; i++)
            {
                myArray[i] = rnd.Next(10, 90);
            }
            empty = false;
            DisplayArray();
        }

        private void btnSortButton_Click(object sender, EventArgs e)
        {
            Array.Sort(myArray);
            DisplayArray();
        }

        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            myArray.GetValue(Int32.Parse(textBoxInput.Text));
        }

        private void btnEditButton_Click(object sender, EventArgs e)
        {
            if (!empty)
            {
                myArray[ListBoxDisplay.SelectedIndex] = Int32.Parse(textBoxInput.Text);
                textBoxInput.Clear();
                DisplayArray();
            }
        }
    }
}
