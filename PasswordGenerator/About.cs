using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            txtAbout.Text = "Copyright (c) 2017 TechElevator, LLC" + System.Environment.NewLine +
                System.Environment.NewLine +
                "Version " + Application.ProductVersion + System.Environment.NewLine +
                System.Environment.NewLine +
               "Permission is hereby granted, free of charge, to any person obtaining a copy of this" + System.Environment.NewLine +
               "software and associated documentation files(the \"Software\"), to deal in the Software without " + System.Environment.NewLine + 
                "restriction, including without limitation the rights to use, copy, modify, merge, publish, " + System.Environment.NewLine +
                "distribute, sublicense, and/ or sell copies of the Software, and to permit persons to whom " + System.Environment.NewLine +
                "the Software is furnished to do so, subject to the following conditions:" + System.Environment.NewLine +
                 System.Environment.NewLine +
                "The above copyright notice and this permission notice shall be included in all copies or substantial " + System.Environment.NewLine + 
                "portions of the Software." + System.Environment.NewLine +
                 System.Environment.NewLine +
                "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED " + System.Environment.NewLine + 
                "TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO " + System.Environment.NewLine +
                "EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, " + System.Environment.NewLine + 
                "WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH " + System.Environment.NewLine +
                "THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE." + System.Environment.NewLine +
                System.Environment.NewLine +
                "John Fulton" + System.Environment.NewLine +
                 System.Environment.NewLine;
 
            btnOk.Focus();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAbout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
