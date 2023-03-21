
namespace Week6_B
{
    partial class TextAnalyzer
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
            this.analyzeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numberCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCharacterCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.wordPhraseTextBox = new System.Windows.Forms.TextBox();
            this.enterTextTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.indexListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phraseLabel = new System.Windows.Forms.Label();
            this.replaceDecsription = new System.Windows.Forms.Label();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(120, 299);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 0;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(217, 299);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(314, 299);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numberCheckBox
            // 
            this.numberCheckBox.AutoSize = true;
            this.numberCheckBox.Enabled = false;
            this.numberCheckBox.Location = new System.Drawing.Point(428, 231);
            this.numberCheckBox.Name = "numberCheckBox";
            this.numberCheckBox.Size = new System.Drawing.Size(70, 19);
            this.numberCheckBox.TabIndex = 3;
            this.numberCheckBox.Text = "Number";
            this.numberCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCharacterCheckBox
            // 
            this.specialCharacterCheckBox.AutoSize = true;
            this.specialCharacterCheckBox.Enabled = false;
            this.specialCharacterCheckBox.Location = new System.Drawing.Point(428, 197);
            this.specialCharacterCheckBox.Name = "specialCharacterCheckBox";
            this.specialCharacterCheckBox.Size = new System.Drawing.Size(117, 19);
            this.specialCharacterCheckBox.TabIndex = 4;
            this.specialCharacterCheckBox.Text = "Special Character";
            this.specialCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowerCaseCheckBox
            // 
            this.lowerCaseCheckBox.AutoSize = true;
            this.lowerCaseCheckBox.Enabled = false;
            this.lowerCaseCheckBox.Location = new System.Drawing.Point(428, 163);
            this.lowerCaseCheckBox.Name = "lowerCaseCheckBox";
            this.lowerCaseCheckBox.Size = new System.Drawing.Size(86, 19);
            this.lowerCaseCheckBox.TabIndex = 5;
            this.lowerCaseCheckBox.Text = "Lower Case";
            this.lowerCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Enabled = false;
            this.upperCaseCheckBox.Location = new System.Drawing.Point(428, 126);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Size = new System.Drawing.Size(86, 19);
            this.upperCaseCheckBox.TabIndex = 6;
            this.upperCaseCheckBox.Text = "Upper Case";
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // wordPhraseTextBox
            // 
            this.wordPhraseTextBox.Location = new System.Drawing.Point(24, 36);
            this.wordPhraseTextBox.Name = "wordPhraseTextBox";
            this.wordPhraseTextBox.Size = new System.Drawing.Size(131, 23);
            this.wordPhraseTextBox.TabIndex = 7;
            // 
            // enterTextTextBox
            // 
            this.enterTextTextBox.Location = new System.Drawing.Point(24, 96);
            this.enterTextTextBox.Multiline = true;
            this.enterTextTextBox.Name = "enterTextTextBox";
            this.enterTextTextBox.Size = new System.Drawing.Size(263, 185);
            this.enterTextTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(428, 96);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // indexListBox
            // 
            this.indexListBox.FormattingEnabled = true;
            this.indexListBox.ItemHeight = 15;
            this.indexListBox.Location = new System.Drawing.Point(314, 96);
            this.indexListBox.Name = "indexListBox";
            this.indexListBox.Size = new System.Drawing.Size(87, 184);
            this.indexListBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Instances of Phrase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Phrase or Word";
            // 
            // passwordDescription
            // 
            this.passwordDescription.AutoSize = true;
            this.passwordDescription.Location = new System.Drawing.Point(428, 67);
            this.passwordDescription.Name = "passwordDescription";
            this.passwordDescription.Size = new System.Drawing.Size(94, 15);
            this.passwordDescription.TabIndex = 13;
            this.passwordDescription.Text = "Create Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Index of Phrase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter Text to Search";
            // 
            // phraseLabel
            // 
            this.phraseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phraseLabel.Location = new System.Drawing.Point(187, 36);
            this.phraseLabel.Name = "phraseLabel";
            this.phraseLabel.Size = new System.Drawing.Size(100, 23);
            this.phraseLabel.TabIndex = 16;
            // 
            // replaceDecsription
            // 
            this.replaceDecsription.AutoSize = true;
            this.replaceDecsription.Location = new System.Drawing.Point(314, 9);
            this.replaceDecsription.Name = "replaceDecsription";
            this.replaceDecsription.Size = new System.Drawing.Size(114, 15);
            this.replaceDecsription.TabIndex = 17;
            this.replaceDecsription.Text = "Replace Phrase With";
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(314, 34);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(100, 23);
            this.replaceTextBox.TabIndex = 18;
            // 
            // TextAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 377);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.replaceDecsription);
            this.Controls.Add(this.phraseLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indexListBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.enterTextTextBox);
            this.Controls.Add(this.wordPhraseTextBox);
            this.Controls.Add(this.upperCaseCheckBox);
            this.Controls.Add(this.lowerCaseCheckBox);
            this.Controls.Add(this.specialCharacterCheckBox);
            this.Controls.Add(this.numberCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.analyzeButton);
            this.Name = "TextAnalyzer";
            this.Text = "Text Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox numberCheckBox;
        private System.Windows.Forms.CheckBox specialCharacterCheckBox;
        private System.Windows.Forms.CheckBox lowerCaseCheckBox;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.TextBox wordPhraseTextBox;
        private System.Windows.Forms.TextBox enterTextTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ListBox indexListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passwordDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label phraseLabel;
        private System.Windows.Forms.Label replaceDecsription;
        private System.Windows.Forms.TextBox replaceTextBox;
    }
}

