using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneFrom
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        List<PhoneWF> phoneWFs = new List<PhoneWF>();

        private void button1_Click(object sender, EventArgs e)
        {
            PhoneWF test = new PhoneWF();
            test.Show();
            phoneWFs.Add(test);
        }
    }
}
