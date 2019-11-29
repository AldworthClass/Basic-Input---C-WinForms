using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Part 3 - Basic Input Solution.
namespace Basic_Input
{
    public partial class BasicInput : Form
    {
        int age;
        int averageLife = 82;
        string name;
        double height;
        double tallestHeight = 2.72;
        public BasicInput()
        {
            InitializeComponent();
        }
        private void TrkAgeSelect_Scroll(object sender, EventArgs e)
        {
            //Whenever the trackbar is moved, age is updated.
            age = Convert.ToInt32(trkAgeSelect.Value);
            //Puts value of age into Label so user knows what the TrackBar has selected.
            lblAgeSelected.Text = age + "";             
        }    
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Note that age is updated as the TrackBar is moved and does not need to be done in this submit Button.
            //Gets name from TextBox.
            name = txtName.Text;
            //Keeps program from crashing if no number is entered, sets height to zero.
            Double.TryParse(txtHeight.Text, out height);    
            //Adds output text to Label.
            lblMessage.Text = "Hi " + name + ".  You are " + (averageLife - age) + " years below life expectancy.\nYou are " + (tallestHeight - height) + "m shorter than the tallest person.";
        }
    }
}
