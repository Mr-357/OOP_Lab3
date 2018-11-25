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
            InitTable();

        }
        private void InitTable()
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.Location = new Point(10, 24);
            //Table.Size = new Size(100, 100);
            Table.AutoSize = true;
            Table.Name = "Desk";
            for (int i = 0; i < 6; i++)
                Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 /6));
            for (int i = 0; i < 10; i++)
               Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100 /10));

            /*Table.ColumnCount = 6;
            Table.RowCount = 10;*/

            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.Controls.Add(Table);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   
                    PictureBox p = new PictureBox();
                    p.ImageLocation = "./test.jpg";
                    p.Dock = DockStyle.Fill;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    Table.Controls.Add(p, i, j);
                }
            }
            // Table.Location = new Point(0, 24);
            Table.Anchor = AnchorStyles.Top;
            Table.Dock = DockStyle.Fill;
        }
     
    }
}
