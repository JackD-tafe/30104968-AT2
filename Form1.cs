// Jack Deathridge, Sprint 1
//Date: 05/05/2025
//Version: 1.0
//Astronomical Form
//The program is used to sort data from a local observatory to record the number of neutrino interactions an hour. 
//Inputs: Random data is inputted. Users can input numbers to search for and can select an item from the data to replace with their inputted number
//Processes: Sort and Search functions as well as an edit function
//Outputs: None
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
            if (!empty)
            {
                int temp = 0;
                for (int outer = 0; outer < max - 1; outer++)
                {
                    for (int inner = 0; inner < max - 1; inner++)
                    {
                        if (myArray[inner] > myArray[inner + 1])
                        {
                            temp = myArray[inner + 1];
                            myArray[inner + 1] = myArray[inner];
                            myArray[inner] = temp;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please load data first");
            }
            DisplayArray();
        }

        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            Array.Sort(myArray, 0, 24);
            DisplayArray();
            int indx;
            if (!(string.IsNullOrEmpty(textBoxInput.Text)))
            {
                indx = Array.BinarySearch(myArray, 0, 24, int.Parse(textBoxInput.Text));
                if (indx > -1)
                {
                    MessageBox.Show("Success; Item found", "Found Message");
                    ListBoxDisplay.SetSelected(indx, true);
                }
                else
                {
                    MessageBox.Show("Search did not find the value", "Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number in the text box input");
            }
            textBoxInput.Clear();
            textBoxInput.Focus();
        }

        private void btnEditButton_Click(object sender, EventArgs e)
        {
            if (!empty)
            {
                myArray[ListBoxDisplay.SelectedIndex] = Int32.Parse(textBoxInput.Text);
                textBoxInput.Clear();
                DisplayArray();
            }
            else if (string.IsNullOrEmpty(textBoxInput.Text))
            {
                MessageBox.Show("Please enter a number in the text box input");
            }
        }
    }
}
