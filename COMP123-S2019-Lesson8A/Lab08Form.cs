using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8A
{
    public partial class Lab08Form : Form
    {

        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// this is constructor for Lab08Form
        /// </summary>
   
        public Lab08Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the Lab08Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// This is the Event Handler for the SubmitButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + "" + AgeTextBox.Text;
            ClearForm();

        }
        /// <summary>
        /// This method clears the text boxes on the form
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            Submitbutton.Enabled = false;
        }

   

        /// <summary>
        /// This is the event handler for the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                Submitbutton.Enabled = true;
            }
            catch
            {
                Submitbutton.Enabled = false;
            }
            
        }

        /// <summary>
        /// This is the Event Handler for the NameTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Submitbutton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
