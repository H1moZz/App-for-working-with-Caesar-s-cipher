using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Vzlom_Shifra_Cezarya
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            textBox1.TabStop = false;
        }

        private void About_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
