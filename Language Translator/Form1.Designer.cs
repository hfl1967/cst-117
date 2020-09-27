namespace Language_Translator
{
    partial class Form1
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
            this.italianButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.spanishButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // italianButton
            // 
            this.italianButton.Location = new System.Drawing.Point(21, 148);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(89, 28);
            this.italianButton.TabIndex = 0;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(20, 19);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(344, 32);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Select a language and I will say Good Morning";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(21, 60);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(337, 59);
            this.translationLabel.TabIndex = 2;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(147, 148);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(89, 28);
            this.spanishButton.TabIndex = 3;
            this.spanishButton.Text = "Spanish";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(269, 148);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(89, 28);
            this.germanButton.TabIndex = 4;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(21, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "This is a textbox. You can type in here, but it doesn\'t go anywhere yet.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 236);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link to MS Forms Controls";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 265);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Radio Button Clicked?";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(21, 356);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please choose a date at random from the calendar below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.italianButton);
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
    }
}

