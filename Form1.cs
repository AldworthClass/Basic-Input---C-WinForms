using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Part 3 - Basic Input Solution
namespace Basic_Input
{
    public partial class BasicInput : Form
    {
        int age;
        string name;
        double height;
        public BasicInput()
        {
            InitializeComponent();
        }
        private void TrkAgeSelect_Scroll(object sender, EventArgs e)
        {
            age = Convert.ToInt32(trkAgeSelect.Value);  //whenever the trackbar is moved, age is updated
            lblAgeSelected.Text = age + "";             //puts value of age into Label so user knows what the TrackBar has selected
        }    
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //note that since age is updated as the TrackBar is moved
            name = txtName.Text;                            //gets name from TextBox  
            Double.TryParse(txtHeight.Text, out height);    //keeps program from crashing if no number is entered.
            //adds output text to label
            lblMessage.Text = "Hi " + name + ".  You are " + (82 - age) + " years below life expectancy.\nYou are " + (2.72 - height) + "m shorter than the tallest person.";
        }
    }
}
