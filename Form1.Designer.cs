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
            btnSearchButton.UseVisualStyleBackColor = true;
            btnSearchButton.Click += btnSearchButton_Click;
            // 
            // ListBoxDisplay
            // 
            ListBoxDisplay.FormattingEnabled = true;
            ListBoxDisplay.ItemHeight = 15;
            ListBoxDisplay.Location = new Point(12, 136);
            ListBoxDisplay.Name = "ListBoxDisplay";
            ListBoxDisplay.Size = new Size(144, 424);
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
            label1.Click += label1_Click;
            // 
            // btnEditButton
            // 
            btnEditButton.Location = new Point(442, 12);
            btnEditButton.Name = "btnEditButton";
            btnEditButton.Size = new Size(75, 23);
            btnEditButton.TabIndex = 6;
            btnEditButton.Text = "Edit";
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
            btnMidExtremeButton.UseVisualStyleBackColor = true;
            btnMidExtremeButton.Click += button1_Click;
            // 
            // btnModeButton
            // 
            btnModeButton.Location = new Point(280, 44);
            btnModeButton.Name = "btnModeButton";
            btnModeButton.Size = new Size(75, 23);
            btnModeButton.TabIndex = 8;
            btnModeButton.Text = "Mode";
            btnModeButton.UseVisualStyleBackColor = true;
            // 
            // btnAverageButton
            // 
            btnAverageButton.Location = new Point(361, 44);
            btnAverageButton.Name = "btnAverageButton";
            btnAverageButton.Size = new Size(75, 23);
            btnAverageButton.TabIndex = 9;
            btnAverageButton.Text = "Average";
            btnAverageButton.UseVisualStyleBackColor = true;
            // 
            // btnRangeButton
            // 
            btnRangeButton.Location = new Point(442, 44);
            btnRangeButton.Name = "btnRangeButton";
            btnRangeButton.Size = new Size(75, 23);
            btnRangeButton.TabIndex = 10;
            btnRangeButton.Text = "Range";
            btnRangeButton.UseVisualStyleBackColor = true;
            // 
            // btnSeqSearchButton
            // 
            btnSeqSearchButton.Location = new Point(199, 73);
            btnSeqSearchButton.Name = "btnSeqSearchButton";
            btnSeqSearchButton.Size = new Size(75, 23);
            btnSeqSearchButton.TabIndex = 11;
            btnSeqSearchButton.Text = "SeqSearch";
            btnSeqSearchButton.UseVisualStyleBackColor = true;
            btnSeqSearchButton.Click += button1_Click_1;
            // 
            // AstroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 576);
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
    }
}
