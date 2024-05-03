namespace CSVosk
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
            startStopButton1 = new Button();
            sttTextBox1 = new TextBox();
            resultTextBox1 = new TextBox();
            clearButton1 = new Button();
            SuspendLayout();
            // 
            // startStopButton1
            // 
            startStopButton1.BackColor = Color.DarkGray;
            startStopButton1.FlatAppearance.BorderColor = Color.Black;
            startStopButton1.FlatStyle = FlatStyle.Flat;
            startStopButton1.Location = new Point(0, 0);
            startStopButton1.Margin = new Padding(4);
            startStopButton1.Name = "startStopButton1";
            startStopButton1.Size = new Size(80, 80);
            startStopButton1.TabIndex = 0;
            startStopButton1.Text = "start";
            startStopButton1.UseVisualStyleBackColor = false;
            startStopButton1.Click += startStopButton1_Click;
            // 
            // sttTextBox1
            // 
            sttTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sttTextBox1.BackColor = Color.Black;
            sttTextBox1.BorderStyle = BorderStyle.None;
            sttTextBox1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sttTextBox1.ForeColor = Color.Lime;
            sttTextBox1.Location = new Point(88, 343);
            sttTextBox1.Margin = new Padding(4);
            sttTextBox1.Multiline = true;
            sttTextBox1.Name = "sttTextBox1";
            sttTextBox1.Size = new Size(924, 99);
            sttTextBox1.TabIndex = 1;
            sttTextBox1.Text = "text";
            // 
            // resultTextBox1
            // 
            resultTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultTextBox1.BackColor = Color.Black;
            resultTextBox1.BorderStyle = BorderStyle.None;
            resultTextBox1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resultTextBox1.ForeColor = Color.Lime;
            resultTextBox1.Location = new Point(88, 0);
            resultTextBox1.Margin = new Padding(4);
            resultTextBox1.Multiline = true;
            resultTextBox1.Name = "resultTextBox1";
            resultTextBox1.ScrollBars = ScrollBars.Vertical;
            resultTextBox1.Size = new Size(924, 335);
            resultTextBox1.TabIndex = 2;
            resultTextBox1.Text = "text";
            // 
            // clearButton1
            // 
            clearButton1.BackColor = Color.DarkGray;
            clearButton1.FlatAppearance.BorderColor = Color.Black;
            clearButton1.FlatStyle = FlatStyle.Flat;
            clearButton1.Location = new Point(0, 88);
            clearButton1.Margin = new Padding(4);
            clearButton1.Name = "clearButton1";
            clearButton1.Size = new Size(80, 80);
            clearButton1.TabIndex = 3;
            clearButton1.Text = "clear";
            clearButton1.UseVisualStyleBackColor = false;
            clearButton1.Click += clearButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1029, 455);
            Controls.Add(clearButton1);
            Controls.Add(resultTextBox1);
            Controls.Add(sttTextBox1);
            Controls.Add(startStopButton1);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startStopButton1;
        private TextBox sttTextBox1;
        private TextBox resultTextBox1;
        private Button clearButton1;
    }
}