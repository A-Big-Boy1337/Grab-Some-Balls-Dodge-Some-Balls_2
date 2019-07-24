using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grab_Some_Balls__Dodge_Some_Balls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show ("Press up to go up, press down to go down. Grab the blue balls, Dodge the red balls...Grab some balls, dodge some balls.");
       
        }

    }
}
