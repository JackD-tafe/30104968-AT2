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
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 70);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 0;
            // 
            // btnLoadButton
            // 
            btnLoadButton.Location = new Point(118, 69);
            btnLoadButton.Name = "btnLoadButton";
            btnLoadButton.Size = new Size(75, 23);
            btnLoadButton.TabIndex = 1;
            btnLoadButton.Text = "Load Data";
            btnLoadButton.UseVisualStyleBackColor = true;
            btnLoadButton.Click += btnLoadButton_Click;
            // 
            // btnSortButton
            // 
            btnSortButton.Location = new Point(199, 69);
            btnSortButton.Name = "btnSortButton";
            btnSortButton.Size = new Size(75, 23);
            btnSortButton.TabIndex = 2;
            btnSortButton.Text = "Sort";
            btnSortButton.UseVisualStyleBackColor = true;
            btnSortButton.Click += btnSortButton_Click;
            // 
            // btnSearchButton
            // 
            btnSearchButton.Location = new Point(280, 69);
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
            ListBoxDisplay.Size = new Size(519, 424);
            ListBoxDisplay.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Edit/Search Input";
            // 
            // btnEditButton
            // 
            btnEditButton.Location = new Point(361, 69);
            btnEditButton.Name = "btnEditButton";
            btnEditButton.Size = new Size(75, 23);
            btnEditButton.TabIndex = 6;
            btnEditButton.Text = "Edit";
            btnEditButton.UseVisualStyleBackColor = true;
            btnEditButton.Click += btnEditButton_Click;
            // 
            // AstroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 576);
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
    }
}
