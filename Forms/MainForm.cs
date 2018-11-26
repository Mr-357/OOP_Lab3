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
using DataClasses;

namespace Forms
{
    
    public partial class MainForm : Form

    {
        private uint totalTime;
        private int m, n, i, p;
        public MainForm()
        {
            InitializeComponent();
            InitTable(); // ZAMENI OVO SA LOADFROMFILE??
            mainMenu.BringToFront();

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitTable();
        }

        private void InitTable()
        {
            LoadFromFile();
            panel1.Controls.Clear();
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
            
            PlayingField.Instance.Generate(m * n,i,p);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Table.Controls.Add(PlayingField.Instance.NewField(), i, j);
                }
            }
            Table.Anchor = AnchorStyles.Top;
            Table.Dock = DockStyle.Fill;
            StartTimer();
        }

        private void LoadFromFile()
        {
            try
            {
                using (StreamReader s = new StreamReader("./data/config.txt"))
                {
                    m = int.Parse(s.ReadLine());
                    n = int.Parse(s.ReadLine());
                    i = int.Parse(s.ReadLine());
                    p = int.Parse(s.ReadLine());
                }
            }
            catch (Exception ex)
            {
                m = 6;
                n = 10;
                i = 5;
                p = 5;
            }
        }

        private void StartTimer()
        {
            totalTime = 0;
        }
    }
}
