using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_color_model
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int iFCR, iFCG, iFCB;

        private void hSBG_Scroll(object sender, ScrollEventArgs e)
        {
            iFCG = hSBG.Value;
            LG.Text = iFCG.ToString();
            lab_Opt.ForeColor = Color.FromArgb(iFCR,iFCG,iFCB);
        }

        private void hSBB_Scroll(object sender, ScrollEventArgs e)
        {
            iFCB = hSBB.Value;
            LB.Text = iFCB.ToString();
            lab_Opt.ForeColor = Color.FromArgb(iFCR, iFCG, iFCB);
        }


        private void hSBR_Scroll(object sender, ScrollEventArgs e)
        {
            iFCR = hSBR.Value;
            LR.Text = iFCR.ToString();
            lab_Opt.ForeColor = Color.FromArgb(iFCR, iFCG, iFCB);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            iFCR = iFCG = iFCB = 0;
            hSBR.Minimum = hSBG.Minimum = hSBB.Minimum = 0;
            hSBR.Maximum = hSBG.Maximum = hSBB.Maximum = 274;
            hSBR.SmallChange = hSBG.SmallChange = hSBB.SmallChange = 5;
            hSBR.LargeChange = hSBG.LargeChange = hSBB.LargeChange = 20;

        }

    }
}
