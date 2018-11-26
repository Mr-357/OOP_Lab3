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
        private Tile old;
        private int m, n, i, p;
        private int countm;
        public MainForm()
        {
            InitializeComponent();
            InitTable();
            mainMenu.BringToFront();
            lblTimer.BringToFront();
            label1.BringToFront();
            countm = 0;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitTable();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ConfigForm(m,n,i,p);
            
            f.ShowDialog();
            InitTable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalTime++;
            // DateTime tmp = new DateTime(totalTime);
            // lblTimer.Text = tmp.ToLongTimeString().ToString();
            lblTimer.Text = totalTime.ToString();
            if (PlayingField.Instance.Won())
            {
                Winner();
            }
            MoveDuck();

        }
        private void MoveDuck()
        {
           Tile t = (Tile)panel1.Controls[0].Controls[(countm)];
            while (t.flipped)
            {
                t = (Tile)panel1.Controls[0].Controls[(++countm)];
                CheckRange();
            }
            if (old != null && !old.flipped && !(old.ImageLocation==old.img ))
            {
                old.ImageLocation = old.bkg;
            }
           
            if (t.ImageLocation == t.img)
            {
                t = (Tile)panel1.Controls[0].Controls[(++countm)];
                CheckRange();
            }
            t.ImageLocation = "./data/zadatak.jpg";
            old = t;
            countm++;
            CheckRange();
        }
        private void CheckRange()
        {
            if (countm >= m * n)
            {
                countm = 0;
            }
        }
        private void Winner()
        {
            timer1.Stop();
            foreach (var tile in panel1.Controls[0].Controls)
            {
                Tile t = (Tile)tile;
                t.Flip();
            }
            MessageBox.Show("Time: " + lblTimer.Text, "You WON", MessageBoxButtons.OK);
            InitTable();
        }
        private void revealTilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (var tile in panel1.Controls[0].Controls)
            {
                Tile t = (Tile)tile;
                t.Flip();
            }
            MessageBox.Show("Time: " + lblTimer.Text,"You failed",MessageBoxButtons.OK);
            InitTable();
        }

        private void InitTable()
        {
            countm = 0;
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
            timer1.Enabled = true;
            timer1.Start();
            lblTimer.Visible = true;
            totalTime = 0;
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
                p = 10;
            }
        }

        private void StartTimer()
        {
            totalTime = 0;
        }
    }
}
