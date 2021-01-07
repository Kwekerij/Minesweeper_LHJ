using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Minesweeper_LHJ
{
    class Game
    {
        public event EventHandler DismantledMinesChanged;
        public event EventHandler Tick;

        private Panel _panel;
        private Square[,] _squares;

        private int _width;
        private int _height;
        private int _mines;
        public int Time;
        private int _dismantledMines;


        Random rand = new Random();
        private Timer _timer;

        public Game(Panel panel, int difficulty)
        {
            _panel = panel;
            switch(difficulty)
            {
                case 0:
                    _width = 10;
                    _height = 8;
                    _mines = 10;
                    Panel.Width = 450; //45
                    Panel.Height = 360;
                    break;
                case 1:
                    _width = 18;
                    _height = 14;
                    _mines = 40;
                    Panel.Width = 540; //30
                    Panel.Height = 420;
                    break;
                case 2:
                    _width = 24;
                    _height = 20;
                    _mines = 99;
                    Panel.Width = 600; //25
                    Panel.Height = 500;
                    break;
            }
        }

        public void Start()
        {
            Panel.Enabled = true;
            Panel.Controls.Clear();

            _squares = new Square[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Square s = new Square(this, x, y);
                    _squares[x, y] = s;

                    s.Explode += new EventHandler(Explode);
                }
            }
            //placing mines
            int i = 0;
            
            while (i < Mines)
            {
                int x = rand.Next(Width);
                int y = rand.Next(Height);

                Square s = _squares[x, y];
                if (!s.IsMine)
                {
                    s.IsMine = true;
                    i++;
                }
            }
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Enabled = true;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            Time++;
            OnTick();
        }
        protected void OnTick()
        {
            if (Tick != null)
            {
                Tick(this, new EventArgs());
            }
        }
        public void OpenSpot(int x, int y)
        {
            if (x >= 0 && x < Width)
            {
                if (y >= 0 && y < Height)
                {
                    _squares[x, y].Open();
                }
            }
        }
        public bool IsBomb(int x, int y)
        {
            if (x >= 0 && x < Width)
            {
                if (y >= 0 && y < Height)
                {
                    return _squares[x, y].IsMine;
                }
            }
            return false;
        }
        private void Explode(object sender, EventArgs e)
        {
            //Panel.Enabled = false; //numbers get grey
            _timer.Enabled = false;

            foreach (Square s in _squares)
            {
                s.RemoveEvents();
                if (s.IsMine)
                {
                    s.Button.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    s.Button.Font = new Font("Microsoft Sans Serif", 18);
                    s.Button.TextAlign = ContentAlignment.MiddleCenter;
                    s.Button.Text = "*"; //• 
                }
            }
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
        public int DismantledMines
        {
            get { return (this._dismantledMines); }
        }
    }
}
