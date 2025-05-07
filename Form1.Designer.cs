namespace _30104968_AT2_V1
{
    partial class AstroForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxInput = new TextBox();
            btnLoadButton = new Button();
            btnSortButton = new Button();
            btnSearchButton = new Button();
            ListBoxDisplay = new ListBox();
            label1 = new Label();
            btnEditButton = new Button();
            btnMidExtremeButton = new Button();
            btnModeButton = new Button();
            btnAverageButton = new Button();
            btnRangeButton = new Button();
            btnSeqSearchButton = new Button();
            listMathBox = new ListBox();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 44);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 0;
            // 
            // btnLoadButton
            // 
            btnLoadButton.Location = new Point(199, 12);
            btnLoadButton.Name = "btnLoadButton";
            btnLoadButton.Size = new Size(75, 23);
            btnLoadButton.TabIndex = 1;
            btnLoadButton.Text = "Load Data";
            toolTip1.SetToolTip(btnLoadButton, "This button loads data into an array to display in the Display box on the left");
            btnLoadButton.UseVisualStyleBackColor = true;
            btnLoadButton.Click += btnLoadButton_Click;
            // 
            // btnSortButton
            // 
            btnSortButton.Location = new Point(280, 12);
            btnSortButton.Name = "btnSortButton";
            btnSortButton.Size = new Size(75, 23);
            btnSortButton.TabIndex = 2;
            btnSortButton.Text = "Sort";
            toolTip1.SetToolTip(btnSortButton, "This button sorts the data using bubble sort methodology");
            btnSortButton.UseVisualStyleBackColor = true;
            btnSortButton.Click += btnSortButton_Click;
            // 
            // btnSearchButton
            // 
            btnSearchButton.Location = new Point(361, 12);
            btnSearchButton.Name = "btnSearchButton";
            btnSearchButton.Size = new Size(75, 23);
            btnSearchButton.TabIndex = 3;
            btnSearchButton.Text = "Search";
            toolTip1.SetToolTip(btnSearchButton, "This data will search the data for the number you enter in the text box");
            btnSearchButton.UseVisualStyleBackColor = true;
            btnSearchButton.Click += btnSearchButton_Click;
            // 
            // ListBoxDisplay
            // 
            ListBoxDisplay.FormattingEnabled = true;
            ListBoxDisplay.ItemHeight = 15;
            ListBoxDisplay.Location = new Point(12, 136);
            ListBoxDisplay.Name = "ListBoxDisplay";
            ListBoxDisplay.Size = new Size(204, 424);
            ListBoxDisplay.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Edit/Search Input";
            // 
            // btnEditButton
            // 
            btnEditButton.Location = new Point(442, 12);
            btnEditButton.Name = "btnEditButton";
            btnEditButton.Size = new Size(75, 23);
            btnEditButton.TabIndex = 6;
            btnEditButton.Text = "Edit";
            toolTip1.SetToolTip(btnEditButton, "This button will change a selected number in the display box to the number you enter in the edit text input box");
            btnEditButton.UseVisualStyleBackColor = true;
            btnEditButton.Click += btnEditButton_Click;
            // 
            // btnMidExtremeButton
            // 
            btnMidExtremeButton.Location = new Point(199, 44);
            btnMidExtremeButton.Name = "btnMidExtremeButton";
            btnMidExtremeButton.Size = new Size(75, 23);
            btnMidExtremeButton.TabIndex = 7;
            btnMidExtremeButton.Text = "MidEx";
            toolTip1.SetToolTip(btnMidExtremeButton, "This button calculates the mid-extreme and displays it in the right box");
            btnMidExtremeButton.UseVisualStyleBackColor = true;
            btnMidExtremeButton.Click += btnMidExtremeButton_Click;
            // 
            // btnModeButton
            // 
            btnModeButton.Location = new Point(280, 44);
            btnModeButton.Name = "btnModeButton";
            btnModeButton.Size = new Size(75, 23);
            btnModeButton.TabIndex = 8;
            btnModeButton.Text = "Mode";
            toolTip1.SetToolTip(btnModeButton, "This button calculates the Mode of the data and displays it in the right box");
            btnModeButton.UseVisualStyleBackColor = true;
            btnModeButton.Click += btnModeButton_Click;
            // 
            // btnAverageButton
            // 
            btnAverageButton.Location = new Point(361, 44);
            btnAverageButton.Name = "btnAverageButton";
            btnAverageButton.Size = new Size(75, 23);
            btnAverageButton.TabIndex = 9;
            btnAverageButton.Text = "Average";
            toolTip1.SetToolTip(btnAverageButton, "This button calculates the average of the data and displays it in the right side box");
            btnAverageButton.UseVisualStyleBackColor = true;
            btnAverageButton.Click += btnAverageButton_Click;
            // 
            // btnRangeButton
            // 
            btnRangeButton.Location = new Point(442, 44);
            btnRangeButton.Name = "btnRangeButton";
            btnRangeButton.Size = new Size(75, 23);
            btnRangeButton.TabIndex = 10;
            btnRangeButton.Text = "Range";
            toolTip1.SetToolTip(btnRangeButton, "This button calculates the range of the data and displays it on the rightside box");
            btnRangeButton.UseVisualStyleBackColor = true;
            btnRangeButton.Click += btnRangeButton_Click;
            // 
            // btnSeqSearchButton
            // 
            btnSeqSearchButton.Location = new Point(199, 73);
            btnSeqSearchButton.Name = "btnSeqSearchButton";
            btnSeqSearchButton.Size = new Size(75, 23);
            btnSeqSearchButton.TabIndex = 11;
            btnSeqSearchButton.Text = "SeqSearch";
            btnSeqSearchButton.UseVisualStyleBackColor = true;
            // 
            // listMathBox
            // 
            listMathBox.FormattingEnabled = true;
            listMathBox.ItemHeight = 15;
            listMathBox.Location = new Point(280, 136);
            listMathBox.Name = "listMathBox";
            listMathBox.Size = new Size(237, 424);
            listMathBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 118);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 13;
            label2.Text = "Math Calculations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 14;
            label3.Text = "Data Display";
            // 
            // AstroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 576);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listMathBox);
            Controls.Add(btnSeqSearchButton);
            Controls.Add(btnRangeButton);
            Controls.Add(btnAverageButton);
            Controls.Add(btnModeButton);
            Controls.Add(btnMidExtremeButton);
            Controls.Add(btnEditButton);
            Controls.Add(label1);
            Controls.Add(ListBoxDisplay);
            Controls.Add(btnSearchButton);
            Controls.Add(btnSortButton);
            Controls.Add(btnLoadButton);
            Controls.Add(textBoxInput);
            Name = "AstroForm";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button btnLoadButton;
        private Button btnSortButton;
        private Button btnSearchButton;
        private ListBox ListBoxDisplay;
        private Label label1;
        private Button btnEditButton;
        private Button btnMidExtremeButton;
        private Button btnModeButton;
        private Button btnAverageButton;
        private Button btnRangeButton;
        private Button btnSeqSearchButton;
        private ListBox listMathBox;
        private ToolTip toolTip1;
        private Label label2;
        private Label label3;
    }
}
