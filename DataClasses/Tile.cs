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
        public bool flipped;
        public string bkg;
        public string img;
        public Timer timer;
        public Tile(string bkg,string img)
        {
            flipped = false;
            this.bkg = bkg;
            this.img = img;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ImageLocation = bkg;
            base.Click += new EventHandler(NewClick);
            
            timer = new Timer();
            timer.Interval = 749;
            timer.Tick += new EventHandler(TimerEnd);
        }
        public void Flip()
        {
            if (this.ImageLocation == bkg && this.img != null)
            {
                this.ImageLocation = this.img;
            
                return;
            }
            else if (this.ImageLocation == img)
            {
                this.ImageLocation = bkg;
                return;
            }
            this.ImageLocation = null;
        }
        private void NewClick(object source,EventArgs e)
        {
            // base.OnClick(e);
           

            Tile t = (Tile)source;
            if (t.img != null&& !t.flipped)
            {
                
               // t.ImageLocation = t.img;
                PlayingField.Instance.AddToMatch(t);
                
                
            }
            else if (t.img==null)
            {
               t.ImageLocation = null;
               t.flipped = true;
            }
        }
        private static void TimerEnd(object source, EventArgs e)
        {
            Timer t = (Timer)source;
            PlayingField.Instance.ShiftMatching();
            //PlayingField.Instance.ShiftMatching();
            t.Stop();
        }
    }
}
