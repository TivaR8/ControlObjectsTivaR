using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 13-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Control Objects
 * This program changes the colour of a button and label when a button is clicked
*/

namespace ControlObjectsTivaR
{
    public partial class frmControlObjects : Form
    {
        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            //Loop to change the colour
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;

                // if the object is a label then it shall become purple
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }
            }

           /* // if the object is a label then it shall become purple
            if (aControlObject.GetType()==typeof(Label))
            {
                aControlObject.BackColor = Color.Purple;
            }
            */
        }
    }
}
