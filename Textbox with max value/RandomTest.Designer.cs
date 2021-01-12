namespace Textbox_with_max_value
{
    partial class RandomTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.rbtnAddition = new System.Windows.Forms.RadioButton();
            this.rbtnSubtraction = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplication = new System.Windows.Forms.RadioButton();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNumber1
            // 
            this.lblNumber1.Location = new System.Drawing.Point(0, 0);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(25, 23);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "999";
            this.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperation
            // 
            this.lblOperation.Location = new System.Drawing.Point(29, 0);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(25, 23);
            this.lblOperation.TabIndex = 1;
            this.lblOperation.Text = "+";
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber2
            // 
            this.lblNumber2.Location = new System.Drawing.Point(58, 0);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(25, 23);
            this.lblNumber2.TabIndex = 2;
            this.lblNumber2.Text = "999";
            this.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEqual
            // 
            this.lblEqual.Location = new System.Drawing.Point(87, 0);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(25, 23);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            this.lblEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.White;
            this.txtAnswer.Location = new System.Drawing.Point(118, 1);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(50, 20);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // rbtnAddition
            // 
            this.rbtnAddition.AutoSize = true;
            this.rbtnAddition.Checked = true;
            this.rbtnAddition.Location = new System.Drawing.Point(2, 36);
            this.rbtnAddition.Name = "rbtnAddition";
            this.rbtnAddition.Size = new System.Drawing.Size(31, 17);
            this.rbtnAddition.TabIndex = 5;
            this.rbtnAddition.TabStop = true;
            this.rbtnAddition.Text = "+";
            this.rbtnAddition.UseVisualStyleBackColor = true;
            this.rbtnAddition.CheckedChanged += new System.EventHandler(this.rbtnAddition_CheckedChanged);
            // 
            // rbtnSubtraction
            // 
            this.rbtnSubtraction.AutoSize = true;
            this.rbtnSubtraction.Location = new System.Drawing.Point(49, 36);
            this.rbtnSubtraction.Name = "rbtnSubtraction";
            this.rbtnSubtraction.Size = new System.Drawing.Size(28, 17);
            this.rbtnSubtraction.TabIndex = 6;
            this.rbtnSubtraction.Text = "-";
            this.rbtnSubtraction.UseVisualStyleBackColor = true;
            this.rbtnSubtraction.CheckedChanged += new System.EventHandler(this.rbtnSubtraction_CheckedChanged);
            // 
            // rbtnMultiplication
            // 
            this.rbtnMultiplication.AutoSize = true;
            this.rbtnMultiplication.Location = new System.Drawing.Point(92, 36);
            this.rbtnMultiplication.Name = "rbtnMultiplication";
            this.rbtnMultiplication.Size = new System.Drawing.Size(29, 17);
            this.rbtnMultiplication.TabIndex = 7;
            this.rbtnMultiplication.Text = "*";
            this.rbtnMultiplication.UseVisualStyleBackColor = true;
            this.rbtnMultiplication.CheckedChanged += new System.EventHandler(this.rbtnMultiplication_CheckedChanged);
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(137, 36);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(30, 17);
            this.rbtnDivision.TabIndex = 8;
            this.rbtnDivision.Text = "/";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            this.rbtnDivision.CheckedChanged += new System.EventHandler(this.rbtnDivision_CheckedChanged);
            // 
            // RandomTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnDivision);
            this.Controls.Add(this.rbtnMultiplication);
            this.Controls.Add(this.rbtnSubtraction);
            this.Controls.Add(this.rbtnAddition);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblNumber1);
            this.Name = "RandomTest";
            this.Size = new System.Drawing.Size(169, 55);
            this.Load += new System.EventHandler(this.RandomTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.RadioButton rbtnAddition;
        private System.Windows.Forms.RadioButton rbtnSubtraction;
        private System.Windows.Forms.RadioButton rbtnMultiplication;
        private System.Windows.Forms.RadioButton rbtnDivision;
    }
}
