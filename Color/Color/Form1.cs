using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            ColorLabel.ForeColor = System.Drawing.Color.FromArgb((int)trackBarRed.Value, 
                                              (int)trackBarGreen.Value,
                                              (int)trackBarBlue.Value);
        }
    }
}
