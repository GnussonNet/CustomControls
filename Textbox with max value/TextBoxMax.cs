using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Textbox_with_max_value
{
    public partial class TextBoxMax : UserControl
    {
        public TextBoxMax()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Custom properies
        /// </summary>
        #region Properties
        // Set description and category for maxchars custom property
        private int _MaximumCharacters = 140;
        [Description("The max allowed characters"), Category("Behavior")]
        public int MaximumCharacters
        {
            get { return _MaximumCharacters; }
            set { _MaximumCharacters = value; }
        }

        // Characters remaining before max lenght
        private int CharsRemaining { get; set; }
        #endregion

        /// <summary>
        /// Events to update lable and max length
        /// </summary>
        #region Events
        private void TextBoxMax_Load(object sender, EventArgs e)
        {
            // Set max lenght to maxChars property
            txtMax.MaxLength = MaximumCharacters;

            // Update label
            lblRemaining.Text = "Remaining characters: " + MaximumCharacters.ToString();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            // Calculate remaining characters
            CharsRemaining = MaximumCharacters - txtMax.TextLength;

            // Update label with remaining characters value
            lblRemaining.Text = "Remaining characters: " + CharsRemaining.ToString();
        }
        #endregion
    }
}
