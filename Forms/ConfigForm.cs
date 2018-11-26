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
