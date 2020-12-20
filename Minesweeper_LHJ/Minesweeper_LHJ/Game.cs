using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_LHJ
{
    class Game
    {
        private Timer _timer;
        private int _FlaggedMines;
        private int _Difficulty;
        private int _status;

        private Panel _panel;
        private Square[,] _squares;

        private int _width;
        private int _height;
        private int _mines;

        public Game(Panel panel, int width, int height, int mines)
        {
            _panel = panel;
            _width = width;
            _height = height;
            _mines = mines;
        }

        public void Start()
        {
            Panel.Enabled = true;
            int Width = 10;
            int Height = 8;

            _squares = new Square[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Square s = new Square(this, x, y);
                    _squares[x, y] = s;
                }
            }
        }







        public int Difficulty
        {
            get { return (this._Difficulty); }
            set { this._Difficulty = value; }
        }
        public Panel Panel
        {
            get { return (this._panel); }
        }
        public int Width
        {
            get { return (this._width); }
        }
        public int Height
        {
            get { return (this._height); }
        }
        public int Mines
        {
            get { return (this._mines); }
        }
    }
}
