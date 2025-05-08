// Jack Deathridge, Sprint 1
//Date: 05/05/2025
//Version: 1.1
//Astronomical Form
//The program is used to sort data from a local observatory to record the number of neutrino interactions an hour. 
//The program has functions to sort, search and edit data.
//Will need to update in future version to handle better error catching
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

        //Sorts array using bubble sort algorithm. Searches for first element in array and then checks it against the next
        //Iterates through until numbers are sorted in ascending order
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
            else //Error catching
            {
                MessageBox.Show("Please load data first");
            }
            DisplayArray();
        }

        //Search function using binary search, iterates through each element and then selects the element in the text box list
        //Will need to add error catching for users not entering numbers
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
            else //user error catching
            {
                MessageBox.Show("Please enter a number in the text box input");
            }
            textBoxInput.Clear();
            textBoxInput.Focus();
        }

        //Edit button. Requires user to highlight an element in the list box display and enter a number to change it to
        //Will want to update this in version 2.0
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
