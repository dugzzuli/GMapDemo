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
    public partial class addPointRoute : Form
    {
        public string start1, end2;
        public Color c = Color.Red;
        public addPointRoute()
        {
            InitializeComponent();
            
        }

        private void addPointRoute_Load(object sender, EventArgs e)
        {
            var dict = MapForm.dictPlace;
            if (dict.Keys.Count > 0)
            {
                IList<Info> list = new List<Info>();
                dict.ToList().ForEach(model =>
                {

                    list.Add(new Info() { count = model.Key, place = model.Value });
                });

                comboBox1.DataSource = list;
                comboBox1.ValueMember = "count";
                comboBox1.DisplayMember = "place";
            }

        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string startPointText = comboBox1.SelectedValue.ToString();
            startPoint.Text = startPointText;
            start1 = startPointText;
            start_show.Text = MapForm.dictPlace[startPointText];
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btncolor.BackColor = colorDialog1.Color;
                c = colorDialog1.Color;
            }
        }

        private void btncolor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                this.Hide();
            }
        }

        private void start2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.Hide();
            }
        }

        private void start2_Click(object sender, EventArgs e)
        {
            string endpointText = comboBox1.SelectedValue.ToString();
            endpoint.Text = endpointText;
            end2 = endpointText;
            end_show.Text = MapForm.dictPlace[endpointText];
        }
    }
    class Info
    {
        public string count { get; set; }
        public string place { get; set; }

    }
}
