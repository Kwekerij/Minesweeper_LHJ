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
        #region Init
        public event EventHandler DismantledMinesChanged; //Event um die Anzeige in Form1 zu aktualisieren
        public event EventHandler Tick; //Event um den Timer in Form1 zu aktualisieren

        private Panel _panel; //erstellt eigenes Panel um Panel aus Form1 übernehmen zu können
        private Square[,] _squares; //erstellt objektvariable _square

        private int _width; //Breite des Spielfeldes
        private int _height; //Höhe des Spielfeldes
        private int _mines; //Minen
        public int Time; //Zeit für den Counter
        private int _dismantledMines; //Anzahl korrekt markierte Minen
        private int _incorrectdismantledMines; //Anzahl inkorrekte markierte Minen


        Random rand = new Random(); //random Funktion für die Platzierung der Minen und random Farben
        private Timer _timer; //objektvariable _timer wird erstellt
        #endregion

        /// <summary>
        /// constructor of GameClass
        /// </summary>
        /// <param name="panel">Gameboard from Form1</param>
        /// <param name="difficulty">Selected difficulty from ComboBox</param>
        public Game(Panel panel, int difficulty)
        {
            _panel = panel; //speichert panel in eigene Variable

            switch(difficulty) //Hier werden mit den jeweilgen Schwierigkeitsgraden die festgelegten Werte gesetzt
            {
                case 0:
                    _width = 10;
                    _height = 8;
                    _mines = 10;
                    Panel.Width = 450; //45 Pixel Breite pro square
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
        #region Dismantle
        /// <summary>
        /// Method for the Dismantle click
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
        /// <param name="e">contains event data</param>
        private void Dismantle(object sender, EventArgs e)
        {
            Square s = (Square)sender;
            if (s.Dismantled)
            {
                if (s.IsMine)
                {
                    _dismantledMines++;
                }
                else
                {
                    _incorrectdismantledMines++;
                }
            }
            else
            {
                if (s.IsMine)
                {
                    _dismantledMines--;
                }
                else
                {
                    _incorrectdismantledMines--;
                }
            }

            OnDismantledMinesChanged();

            if (_dismantledMines == Mines) //Wenn alle Minen richtig markierten wurden, wird das Spiel direkt beendet
            {
                _timer.Enabled = false; //Timer wird gestoppt
                Panel.Enabled = false; 
                Winner winner = new Winner();
                winner.Show();
            }
        }
        /// <summary>
        /// method for event DismantledMinesChanged
        /// </summary>
        protected void OnDismantledMinesChanged()
        {
            if (DismantledMinesChanged != null) //um Fehler vorzubeugen
            {
                DismantledMinesChanged(this, new EventArgs());
            }
        }
        #endregion
        /// <summary>
        /// executed at start and restart of the game
        /// creates Squares, places Mines, creates Timer
        /// </summary>
        public void Start()
        {
            Panel.Enabled = true;
            Panel.Controls.Clear(); //für den Neustart wird das Panel bereinigt

            _squares = new Square[Width, Height]; //Instanziierung für neues Square
            for (int x = 0; x < Width; x++) //geht Höhe durch
            {
                for (int y = 0; y < Height; y++) //geht Breite durch
                {
                    Square s = new Square(this, x, y); //erstellt für jede Koordinate ein neues Square
                    _squares[x, y] = s; //erstelltes Square wird mit passendem x und y ordentlich abgespeichert

                    s.Explode += new EventHandler(Explode); //ermöglicht einfachen Übergang zwischen Klassen; Explode wird bei s.Explode ausgeführt (abboniert)
                    s.Dismantle += new EventHandler(Dismantle); //Dismantle wird bei s.Dismantle ausgeführt
                }
            }
            
            int i = 0;
            while (i < Mines) //alle Minen werden platziert
            {
                int x = rand.Next(Width); //random x wird gesetzt
                int y = rand.Next(Height); //random y wird gesetzt

                Square s = _squares[x, y]; //das random gefundene Square wird der einfach in s gespeichert (einfacher)
                if (!s.IsMine) //wird noch gecheckt ob das Square bereits eine Mine beinhaltet
                {
                    s.IsMine = true; //die bool Eigenschaft, dass sich da eine Mine befindet wird auf true gesetzt
                    i++; //Minencounter wird um 1 erhöht
                }
            }
            _timer = new Timer(); //Instanziierung vom Timer
            _timer.Interval = 1000; //Timerschritte von 1s
            _timer.Tick += new EventHandler(TimerTick); //bei jedem event Tick(1s) wird die method TimerTick ausgeführt
            //_timer.Enabled = true;
        }

        #region Timer
        /// <summary>
        /// Counter for Timer
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
        /// <param name="e">contains event data</param>
        private void TimerTick(object sender, EventArgs e)
        {
            Time++; //zählt um eins hoch um die Zeit ordentlich speichern zu können
            OnTick(); //ruft method OnTick auf
        }
        /// <summary>
        /// method to set Event Tick
        /// </summary>
        protected void OnTick()
        {
            if (Tick != null) //vorbeugung von NullReference
            {
                Tick(this, new EventArgs()); //fürht tick event aus
            }
        }
        #endregion

        /// <summary>
        /// Checks for square class, if square is in limits;
        /// executes _squares.Open
        /// </summary>
        /// <param name="x">x-coordinate of square</param>
        /// <param name="y">y-coordinate of square</param>
        public void OpenSpot(int x, int y)
        {
            if (x >= 0 && x < Width) //checkt ob x innerhalt der Breite ist
            {
                if (y >= 0 && y < Height) //checkt ob y innerhalb der Höhe ist
                {
                    _squares[x, y].Open(); //führt Open method für das bestimmte square aus
                }
            }
        }

        /// <summary>
        /// checks for square class, if square is in limtis and has Mine
        /// </summary>
        /// <param name="x">x-coordinate of square</param>
        /// <param name="y">y-coordinate of square</param>
        /// <returns>Bool for square has mine</returns>
        public bool IsBomb(int x, int y)
        {
            if (x >= 0 && x < Width) //checkt ob x innerhalt der Breite ist
            {
                if (y >= 0 && y < Height) //checkt ob y innerhalb der Höhe ist
                {
                    return _squares[x, y].IsMine; //gibt bool zurück, ob sich eine Mine in dem square befindet
                }
            }
            return false; //falls außerhalb der Limits gibt es false zurück
        }

        /// <summary>
        /// end of the game
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
        /// <param name="e">contains event data</param>
        private void Explode(object sender, EventArgs e)
        {
            //Panel.Enabled = false; //Nummern würden grau werden
            _timer.Enabled = false; //timer wird gestoppt

            foreach (Square s in _squares) //jedes square wird durchgegangen
            {
                s.RemoveEvents(); //deabboniert alle events
                if (s.IsMine) //checkt ob square Mine beinhaltet
                {
                    s.Button.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); //gibt jedem Bombensquare eine random colour
                    s.Button.Font = new Font("Microsoft Sans Serif", 18); //Button wird Font gegeben um Text später wiederzugeben
                    s.Button.TextAlign = ContentAlignment.MiddleCenter; //um das * mehr mittig anzuzeigen
                    s.Button.Text = "*"; //• hier wird das alte * Symbol verwendet, wie bei dem Ur-Minesweeper game
                }
            }
        }
        #region get methods
        /// <summary>
        /// get method for Timer
        /// </summary>
        public Timer Timer
        {
            get { return (this._timer); }
        }
        /// <summary>
        /// get method for Panel
        /// </summary>
        public Panel Panel
        {
            get { return (this._panel); }
        }
        /// <summary>
        /// get method for Width
        /// </summary>
        public int Width
        {
            get { return (this._width); }
        }
        /// <summary>
        /// get method for Height
        /// </summary>
        public int Height
        {
            get { return (this._height); }
        }
        /// <summary>
        /// get method for Mines
        /// </summary>
        public int Mines
        {
            get { return (this._mines); }
        }
        /// <summary>
        /// get method for DismantledMines
        /// </summary>
        public int DismantledMines
        {
            get { return _dismantledMines + _incorrectdismantledMines; }
        }
        #endregion
    }
}
