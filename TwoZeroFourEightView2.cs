using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightView2 : Form,View
    {
        public TwoZeroFourEightView2()
        {
            InitializeComponent();
        }

        private void TwoZeroFourEightViewcs_Load(object sender, EventArgs e)
        {

        }
        public void Notify(Model m)
        {
            int s = (((TwoZeroFourEightModel)m).Updatescore());
            label2.Text = Convert.ToString(s);
        }
    }
}
