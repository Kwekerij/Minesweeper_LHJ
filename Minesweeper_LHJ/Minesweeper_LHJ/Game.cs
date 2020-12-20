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
        private int _status;

        private Panel _panel;
        private Square[,] _squares;
        private int _difficulty;

        private int _width;
        private int _height;
        private int _mines;

        public Game(Panel panel, int difficulty)
        {
            _panel = panel;
            switch(difficulty)
            {
                case 0:
                    _width = 10;
                    _height = 8;
                    _mines = 10;
                    break;
                case 1:
                    _width = 18;
                    _height = 14;
                    _mines = 40;
                    break;
                case 2:
                    _width = 24;
                    _height = 20;
                    _mines = 99;
                    break;
            } 
        }

        public void Start()
        {
            Panel.Enabled = true;

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








        public Panel Panel
        {
            get { return (this._panel); }
        }
        public int Difficulty
        {
            get { return (this._difficulty); }
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
