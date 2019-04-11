using ColorSwapper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSwapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRandomizeColor_Click(object sender, EventArgs e)
        {
            RandomizeColor rColor = new RandomizeColor();
            int[] button_color = rColor.NewColor();

            button1.BackColor = Color.FromArgb(button_color[0], button_color[1], button_color[2], button_color[3]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
