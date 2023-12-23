using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Find : Form
    {
        Form1 _form;
        public Find(Form1 form)
        {
            InitializeComponent();
            _form = form;
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            _form.Find(textFind.Text);
        }
    }
}
