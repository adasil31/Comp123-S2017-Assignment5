namespace Comp123_S2017_Assignment5
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckBMIbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YouAreLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.YouareTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBMIbutton
            // 
            this.CheckBMIbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBMIbutton.Location = new System.Drawing.Point(29, 349);
            this.CheckBMIbutton.Name = "CheckBMIbutton";
            this.CheckBMIbutton.Size = new System.Drawing.Size(86, 38);
            this.CheckBMIbutton.TabIndex = 0;
            this.CheckBMIbutton.Text = "Check BMI";
            this.CheckBMIbutton.UseVisualStyleBackColor = true;
            this.CheckBMIbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(116, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(192, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(24, 92);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(112, 25);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight:";
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Location = new System.Drawing.Point(24, 137);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(74, 25);
            this.Heightlabel.TabIndex = 4;
            this.Heightlabel.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your BMI:";
            // 
            // YouAreLabel
            // 
            this.YouAreLabel.AutoSize = true;
            this.YouAreLabel.Location = new System.Drawing.Point(24, 282);
            this.YouAreLabel.Name = "YouAreLabel";
            this.YouAreLabel.Size = new System.Drawing.Size(86, 25);
            this.YouAreLabel.TabIndex = 6;
            this.YouAreLabel.Text = "You are:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(136, 137);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(136, 29);
            this.HeightTextBox.TabIndex = 8;
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(136, 88);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(136, 29);
            this.WeightBox.TabIndex = 9;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(136, 187);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(136, 29);
            this.ResultTextBox.TabIndex = 11;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(29, 233);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(90, 29);
            this.MetricRadioButton.TabIndex = 12;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(125, 233);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(105, 29);
            this.ImperialRadioButton.TabIndex = 13;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // YouareTextBox
            // 
            this.YouareTextBox.Location = new System.Drawing.Point(125, 282);
            this.YouareTextBox.Multiline = true;
            this.YouareTextBox.Name = "YouareTextBox";
            this.YouareTextBox.Size = new System.Drawing.Size(142, 34);
            this.YouareTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "BMI CALCULATOR";
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBMIbutton);
            this.Controls.Add(this.YouareTextBox);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.YouAreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Heightlabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckBMIbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label YouAreLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.TextBox YouareTextBox;
        private System.Windows.Forms.Label label1;
    }
}

