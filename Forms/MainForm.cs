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
            Table.Location = new Point(0, 24);
            Table.Size = new Size(100, 100);
            Table.AutoSize = true;
            Table.Name = "Desk";
            Table.ColumnCount = 6;
            Table.RowCount = 10;

            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.Controls.Add(Table);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Table.Controls.Add(new PictureBox(), i, j);
                    PictureBox p = Table.GetControlFromPosition(i, j) as PictureBox;
                    
                    p.ImageLocation = "./test.jpg";
                    p.Dock = DockStyle.Fill;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            Table.Location = new Point(0, 24);
            Table.Dock = DockStyle.Fill;
        }
     
    }
}
