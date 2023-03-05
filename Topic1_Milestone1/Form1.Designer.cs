namespace Topic1_Milestone1
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
            inputBox = new TextBox();
            nextButton = new Button();
            restartButton = new Button();
            inputLabel = new Label();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(242, 110);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(125, 27);
            inputBox.TabIndex = 1;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(260, 162);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 2;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // restartButton
            // 
            restartButton.Location = new Point(260, 162);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(94, 29);
            restartButton.TabIndex = 8;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Visible = false;
            restartButton.Click += restartButton_Click;
            // 
            // inputLabel
            // 
            inputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inputLabel.Location = new Point(12, 72);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(589, 35);
            inputLabel.TabIndex = 9;
            inputLabel.Text = "Greeting";
            inputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 305);
            Controls.Add(inputLabel);
            Controls.Add(restartButton);
            Controls.Add(nextButton);
            Controls.Add(inputBox);
            Name = "Form1";
            Text = "Greeting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputBox;
        private Button nextButton;
        private Button restartButton;
        private Label inputLabel;
    }
}