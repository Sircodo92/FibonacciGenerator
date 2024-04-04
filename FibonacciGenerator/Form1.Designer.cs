namespace FibonacciGenerator
{
    partial class Form1
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
            InputTextBox = new TextBox();
            GenerateButton = new Button();
            OutputListBox = new ListBox();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(63, 33);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(325, 39);
            InputTextBox.TabIndex = 0;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(418, 33);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(150, 46);
            GenerateButton.TabIndex = 1;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // OutputListBox
            // 
            OutputListBox.FormattingEnabled = true;
            OutputListBox.Location = new Point(54, 120);
            OutputListBox.Name = "OutputListBox";
            OutputListBox.Size = new Size(899, 548);
            OutputListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 710);
            Controls.Add(OutputListBox);
            Controls.Add(GenerateButton);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Multi-Threading Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button GenerateButton;
        private ListBox OutputListBox;
    }
}
