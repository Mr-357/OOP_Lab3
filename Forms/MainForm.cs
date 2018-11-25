using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<10;j++)
                {
                    tblPlayingGrid.Controls.Add(new PictureBox(), i, j);
                    PictureBox p = tblPlayingGrid.GetControlFromPosition(i, j) as PictureBox;
                    p.ImageLocation = "./test.jpg";
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }
        private void InitTable()
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.Location = new Point(10, 40);
            Table.Size = new Size(620, 100);
            Table.AutoSize = true;
            Table.Name = "Desk";
            Table.ColumnCount = 2;
            Table.RowCount = 0;
            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.Controls.Add(Table);
        }
        private void LoadImages()
        {

        }
    }
}
