using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMapDemo_2
{
    public partial class addPoint : Form
    {
        public string text;
        public addPoint()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            text = placeText.Text;
            this.Hide();

        }

        private void addPoint_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void placeText_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
