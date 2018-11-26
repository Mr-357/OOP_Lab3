using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();

        }
        public ConfigForm(int m,int n,int i, int p)
        {
            InitializeComponent();
            numColumns.Value = m;
            numRows.Value = n;
            numPictures.Value = i;
            numPairs.Value = p;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter s = new StreamWriter("./data/config.txt"))
            {
                s.WriteLine(numColumns.Value.ToString());
                s.WriteLine(numRows.Value.ToString());
                s.WriteLine(numPictures.Value.ToString());
                s.WriteLine(numPairs.Value.ToString());
            }
            this.Close();
        }
    }
}
