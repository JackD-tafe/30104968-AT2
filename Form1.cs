// Jack Deathridge, Sprint 1
//Date: 05/05/2025
//Version: 2.1
//Astronomical Form
//The program is used to sort data from a local observatory to record the number of neutrino interactions an hour.
//It has also been adjusted to be able to perform some mathematical calculations on the data set.
//Program has the ability to search/sort/edit the data set. It can search with two different methodologies. 
//Program performs calculations to find the mid-extreme, mode, average and range of the data. 
//Program has been adjusted to have tooltips

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
        int emptyPtr = 0;

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
            {
                MessageBox.Show("Nothing to display");
            }
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
            listMathBox.Items.Clear();
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
            else //simple error catching
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
                    MessageBox.Show($"Success; Item found at index {indx}", "Found Message");
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

        //Button to calculate the mid-extreme. min/max are found and the middle is found via arraylength/2.

        private void btnMidExtremeButton_Click(object sender, EventArgs e)
        {
            if (!empty)
            {
                int minExtreme = myArray.Min();
                int maxExtreme = myArray.Max();
                int midExtremeIndex = myArray.Length / 2;

                if (myArray.Length % 2 == 0)
                {
                    int middleNum1 = myArray[midExtremeIndex - 1];
                    int middleNum2 = myArray[midExtremeIndex];
                    double middle = (middleNum1 + middleNum2) / 2.0;

                    listMathBox.Items.Clear();
                    listMathBox.Items.Add($"Minimum: {minExtreme}");
                    listMathBox.Items.Add($"Maximum: {maxExtreme}");
                    listMathBox.Items.Add($"Mid extreme: {middle}");
                }
            }
            else
            {
                MessageBox.Show("No data present");
            }
        }

        //Mode Calculation, arranges the values by descending order, finds the most frequently occuring value
        private void btnModeButton_Click(object sender, EventArgs e)
        {
            if (empty != true)
            {
                int highestValue = myArray.OrderByDescending(n => n).First();

                int mode = myArray.GroupBy(i => i).OrderByDescending(f => f.Count()).Select(f => f.Key).FirstOrDefault();
                int frequency = myArray.Where(n => n == mode).Count();
                listMathBox.Items.Clear();
                listMathBox.Items.Add($"The mode is {mode} and occured {frequency} times");
            }
            else
            {
                MessageBox.Show("No data present");
            }
        }

        //Calculates the average, just the sum of all elements divided by the amount of elements
        private void btnAverageButton_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (empty != true)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    total += myArray[i];
                }

                int sum = total;
                double average = sum / myArray.Length;
                listMathBox.Items.Clear();
                listMathBox.Items.Add($"The average is {average}");
            }
            else
            {
                MessageBox.Show("No data present");
            }
        }

        //Calculates the range, largest number - lowest number = range
        private void btnRangeButton_Click(object sender, EventArgs e)
        {
            if (empty != true)
            {
                float minExtreme = myArray.Min();
                float maxExtreme = myArray.Max();

                float range = maxExtreme - minExtreme;

                listMathBox.Items.Clear();
                listMathBox.Items.Add($"The range is {range} or {maxExtreme} - {minExtreme}");
            }
            else
            {
                MessageBox.Show("No data present");
            }
        }

        //Sequential search or linear search. Just a for loop to iterate through each element of the array and a couple if loops for error catching.
        private void btnSeqSearchButton_Click(object sender, EventArgs e)
        {
            int indx;
            bool found = false;
            if (!(Int32.TryParse(textBoxInput.Text, out indx)))
            {
                MessageBox.Show("Please enter an integer");
                return;
            }
            for (int x = 0; x < max; x++)
            {
                if (myArray[x] == indx)
                {
                    MessageBox.Show($"Item found at index {x}");
                    ListBoxDisplay.SetSelected(x, true);
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("Not found, try again");
            }
        }
    }
}
