namespace Textbox_with_max_value
{
    partial class TextBoxMax
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
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMax
            // 
            this.txtMax.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMax.Location = new System.Drawing.Point(0, 0);
            this.txtMax.Multiline = true;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(304, 63);
            this.txtMax.TabIndex = 0;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // lblRemaining
            // 
            this.lblRemaining.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRemaining.Location = new System.Drawing.Point(0, 66);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(304, 23);
            this.lblRemaining.TabIndex = 1;
            this.lblRemaining.Text = "Remaining chars: 140";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.txtMax);
            this.Name = "TextBoxMax";
            this.Size = new System.Drawing.Size(304, 89);
            this.Load += new System.EventHandler(this.TextBoxMax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblRemaining;
    }
}
