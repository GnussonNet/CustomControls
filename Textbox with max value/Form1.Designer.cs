namespace Textbox_with_max_value
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
            this.randomTest1 = new Textbox_with_max_value.RandomTest();
            this.textBoxMax1 = new Textbox_with_max_value.TextBoxMax();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomTest1
            // 
            this.randomTest1.Location = new System.Drawing.Point(388, 28);
            this.randomTest1.Name = "randomTest1";
            this.randomTest1.number1 = 26D;
            this.randomTest1.number2 = 3D;
            this.randomTest1.operation = null;
            this.randomTest1.Size = new System.Drawing.Size(169, 55);
            this.randomTest1.TabIndex = 1;
            // 
            // textBoxMax1
            // 
            this.textBoxMax1.Location = new System.Drawing.Point(12, 12);
            this.textBoxMax1.MaximumCharacters = 140;
            this.textBoxMax1.Name = "textBoxMax1";
            this.textBoxMax1.Size = new System.Drawing.Size(304, 89);
            this.textBoxMax1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "To chnage the maximum characters allowed, got to properties and change \"Maximum C" +
    "haracters\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomTest1);
            this.Controls.Add(this.textBoxMax1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Custom Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxMax textBoxMax1;
        private RandomTest randomTest1;
        private System.Windows.Forms.Label label1;
    }
}

