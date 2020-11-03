using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form_Input : Form
    {
        public Form_Input()
        {
            InitializeComponent();
        }

        public string sRet = "";
        private void TB_input1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // [Enter] ==> <\r>, <13>, <0x0d>
            {
                sRet = TB_input1.Text;
                Close();
            }
            else if (e.KeyChar == 27)
            {
                sRet = "";
                Close();
            }
        }
    }
}
