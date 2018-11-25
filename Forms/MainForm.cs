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
            
            mainMenu.BringToFront();

        }
        private void InitTable(int m,int n)
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.Location = new Point(10, 24);
            Table.AutoSize = true;
            Table.Name = "Playing Field";
            for (int i = 0; i < m; i++)
                Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 /m));
            for (int i = 0; i < n; i++)
               Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100 /n));
            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            panel1.Controls.Add(Table);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   
                    PictureBox p = new PictureBox();
                    p.ImageLocation = "./test.jpg";
                    p.Dock = DockStyle.Fill;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    Table.Controls.Add(p, i, j);
                }
            }
            Table.Anchor = AnchorStyles.Top;
            Table.Dock = DockStyle.Fill;
        }
     
    }
}
