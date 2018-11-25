using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    class PlayingField
    {
        private List<Tile> _tiles; //maybe not needed?
        private List<Tile> _matching;
        private List<string> _images;
        private PlayingField()
        {
            LoadImages();
            _tiles = new List<Tile>();
            _matching = new List<Tile>();
            _images = new List<string>();
        }
        private void LoadImages()
        {

            foreach (string f in Directory.GetFiles("./data/", "*.jpg"))
            {
                if (f != "background.jpg")
                {
                    _images.Add(f);
                }
            }
        }
        private static PlayingField _instance;

        public static PlayingField Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PlayingField();
                return _instance;
            }
        }
    }
}
