using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public class PlayingField
    {
        private List<Tile> _tiles; //maybe not needed?
        private Tile[] _matching;
        private List<string> _images;
        private int _numTiles;
        private string _background;
        private int _numImage;
        private int _requiredPairs;
        private int _flipped;
        Random rng = new Random();
        private PlayingField()
        {
           
            _tiles = new List<Tile>();
            _matching = new Tile[2];
            _images = new List<string>();
            _numTiles = 0;
            LoadImages();
        }
        private void LoadImages()
        {
            _images.Clear();
            foreach (string f in Directory.GetFiles("./data/", "*.jpg"))
            {
                if (f != "./data/background.jpg")
                {
                    _images.Add(f);
                }
                else if (f == "./data/background.jpg")
                {
                    _background = f;
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
        public void Match()
        {
            if (_matching[0].ImageLocation == _matching[1].ImageLocation)
            {
                _matching[0].flipped = _matching[1].flipped = true;
                _flipped++;
            }
        }
        public Tile[] Matching { get => _matching; set => _matching = value; }
        public void AddToMatch(Tile t)
        {
           
            if(_matching[0]==null)
            {
                t.Flip();
                _matching[0] = t;
                return;
            }
            if (_matching[1] == null)
            {
                _matching[1] = t;
                t.Flip();
                Match();
            }

        }
        public void ShiftMatching()
        {
            if (_matching[1] != null)
            {
                if (!_matching[1].flipped)
                {
                    _matching[1].Flip();
                }
                _matching[0] = _matching[1];
                _matching[1] = null;
            }
            else
            {
                if (!_matching[0].flipped)
                {
                    _matching[0].Flip();
                }
                _matching[0] = null;
            }
        }
        public void Generate(int dim,int img,int req)
        {
            _numImage = img;
            _requiredPairs = req;
            _flipped = 0;
            LoadImages();
            while (_tiles.Count < _numImage)
            {
                Tile t = new Tile(_background, _images[_numTiles]);
                Tile t2 = new Tile(_background, _images[_numTiles++]);
                _tiles.Add(t);
                _tiles.Add(t2);
            }
            while (_tiles.Count/2 < _requiredPairs)
            {
                Tile t = new Tile(_background, _images[_numTiles%_numImage]);
                Tile t2 = new Tile(_background, _images[_numTiles++%_numImage]);
                _tiles.Add(t);
                _tiles.Add(t2);
            }
            while (_tiles.Count < dim)
            {
                Tile t = new Tile(_background, null);
                _tiles.Add(t);
            }
            _numTiles = dim;
        }
        public Tile NewField()
        {
            int ret = rng.Next(0, _numTiles);
            Tile retval = _tiles[ret];
            _tiles.RemoveAt(ret);
            _numTiles--;
            return retval;
        }
        
    }

}
