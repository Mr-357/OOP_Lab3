using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataClasses
{
    public class Tile : PictureBox
    {
        private string bkg;
        private string img;
        private Timer timer;
        Tile(string bkg,string img)
        {
            this.ImageLocation = bkg;
            timer.Interval = 1500;
            timer.Tick += new EventHandler(TimerEnd);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            
            timer.Start();
        }
        private static void TimerEnd(object source, EventArgs e)
        {
            Tile t = source as Tile;
            t.ImageLocation = t.bkg;
            
        }
    }
}
