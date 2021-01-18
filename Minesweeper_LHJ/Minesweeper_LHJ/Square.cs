using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper_LHJ
{
    class Square
    {
		public event EventHandler Dismantle; //Dismantle Event für Kommunikation mit game class
		public event EventHandler Explode; //Explode Event für Kommunikation mit game class

		private bool _dismantled = false; //Initialisierung für "rechtsgeklickt" gleich false
		private bool _opened = false; //Initialisierung für "aufgedeckt" gleich false

		private Button _button; //Objektvariable _button erstellt
		private Game _game; //Objektvariable _game erstellt
		private int _x; //x-Koordinate des squares
		private int _y; //y-Koordinate des squares

		Random rand = new Random(); //random Funktion für Farbauswahl

		public bool IsMine { get; set; } //get set Method für IsMine Eigenschaft

		/// <summary>
		/// constructor for the Square class, creates Square
		/// </summary>
		/// <param name="game">game object from game class</param>
		/// <param name="x">x-coordinate of square</param>
		/// <param name="y">y-coordinate of square</param>
		public Square(Game game, int x, int y) 
		{
			_game = game; //speichert das game in eigene Variable ab
			_x = x; //speichert x in eigene Variable ab
			_y = y; //speichert y in eigene Variable ab
			_button = new Button(); //Instanziierung eines neuen Buttons
			Button.Text = ""; //setzt den Text auf null

			int w = _game.Panel.Width / _game.Width; //wird für die verschiedene Skalierung der Größen der squares benötigt
			int h = _game.Panel.Height / _game.Height; //

			_button.Width = w + 1; //Breite des Buttons gesetzt
			_button.Height = h + 1; //Höhe des Buttons gesetzt
			_button.Left = w * X; // Position vom Button
			_button.Top = h * Y;
			_button.FlatStyle = FlatStyle.Flat; //nimmt 3D-Effekt raus, optische Verbesserung
			_button.FlatAppearance.BorderSize = 0; //der Rand wird eleminiert, optische Verbesserung
			_button.TabStop = false;
			_button.Font = new System.Drawing.Font("Arial Black", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))); // Font setzten
			if ((X+Y)%2==0) //nach Karomuster sortieren, optische Verbesserung
            {
				_button.BackColor = Color.FromArgb(170, 215, 81); //helles grün
			}
			else
            {
				_button.BackColor = Color.FromArgb(162, 209, 73); //dunkelgrün
			}
			_button.Click += new EventHandler(Click); //Wenn button geklickt wird, wird Click method ausgeführt
			_button.MouseDown += new MouseEventHandler(DismantleClick); //DismantleClick method an MouseDown abonniert

			_game.Panel.Controls.Add(Button); //der nun definierte Button wird dem Panel hinzugefügt
		}

		/// <summary>
		/// method when square is clicked one
		/// </summary>
		/// <param name="sender">reference to the control that raised the event</param>
		/// <param name="e">contains event data</param>
		private void Click(object sender, System.EventArgs e)
		{
			_game.Timer.Enabled = true; //startet erst den Timer wenn man auf ein Square geklickt hat
			if (!Dismantled) //wenn nicht dismantled/markiert
			{
				if (IsMine) //wenn Mine in Square
				{
					Button.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); //setzt Hintergrund des Squares auf eine random Farbe
					Button.Font = new Font("Microsoft Sans Serif", 18); //Button wird Font gegeben um Text später wiederzugeben
					Button.TextAlign = ContentAlignment.MiddleCenter; //um das * mehr mittig anzuzeigen
					Button.Text = "*"; //• hier wird das alte * Symbol verwendet, wie bei dem Ur-Minesweeper game
					OnExplode(); //OnExplode method aufgerufen um Event zu setzen, das Spiel wurde verloren
					Button.Enabled = false; //Button wird deaktiviert
				}
				else
				{
					this.Open(); //die Open method wird aufgerufen
				}
			}
		}

		/// <summary>
		/// Method to flag a square
		/// </summary>
		/// <param name="sender">reference to the control that raised the event</param>
		/// <param name="e">contains event data</param>
		private void DismantleClick(object sender, MouseEventArgs e)
		{
			if (!Opened && e.Button == MouseButtons.Right) //noch nicht geöffnet und rechte Maustaste wird verwendet
			{
				if (Dismantled)
				{
					_dismantled = false; //erneuter rechtsklick setzt dismantled zurück
					if ((X + Y) % 2 == 0) //optische Zurücksetzung im Karomuster
					{
						Button.BackColor = Color.FromArgb(170, 215, 81); //helles grün
						Button.Image = null;
					}
					else
					{
						Button.BackColor = Color.FromArgb(162, 209, 73); //dunkel grün
						Button.Image = null;

					}
				}
				else
				{
					_dismantled = true; //Setzt die dismantled Eigenschaft des Squares auf true
					if ((X + Y) % 2 == 0) //im Karomuster werden die Flaggen gesetzt
					{
						Button.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Bilder\Flagge_hell.png"); //Bild wird reingeladen
					}
					else
					{
						Button.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Bilder\Flagge_dunkel.png");
					}					
				}
				OnDismantle(); //method für dismantle Event aufgerufen
			}
		}

		/// <summary>
		/// method to open the square
		/// </summary>
		public void Open()
		{
			if (!Opened && !Dismantled)
			{
				_opened = true; //opened Eigenschaft wird auf true gesetzt
				// Bomben im Umkreis werden gezählt
				int c = 0;
				if (_game.IsBomb(X - 1, Y - 1)) c++;
				if (_game.IsBomb(X - 0, Y - 1)) c++;
				if (_game.IsBomb(X + 1, Y - 1)) c++;
				if (_game.IsBomb(X - 1, Y - 0)) c++;
				if (_game.IsBomb(X - 0, Y - 0)) c++;
				if (_game.IsBomb(X + 1, Y - 0)) c++;
				if (_game.IsBomb(X - 1, Y + 1)) c++;
				if (_game.IsBomb(X - 0, Y + 1)) c++;
				if (_game.IsBomb(X + 1, Y + 1)) c++;

				if (c > 0) //wenn mindestens eine Bombe im Umfeld ist
				{
					Button.Text = c.ToString(); //Anzahl der Bomben anzeigen
					switch (c) //für jede Zahl wird eine eigene Farbe definiert
					{
						case 1:
							Button.ForeColor = Color.FromArgb(25, 118, 210); //hell blau
							break;
						case 2:
							Button.ForeColor = Color.FromArgb(56, 142, 60); //grün
							break;
						case 3:
							Button.ForeColor = Color.FromArgb(211, 47, 47); //rot
							break;
						case 4:
							Button.ForeColor = Color.FromArgb(123, 31, 162); //violet
							break;
						case 5:
							Button.ForeColor = Color.FromArgb(255, 143, 0); //orange
							break;
						case 6:
							Button.ForeColor = Color.LightBlue; //noch nicht aufgetaucht
							break;
						case 7:
							Button.ForeColor = Color.Blue; //unwahrscheinlich
							break;
						case 8:
							Button.ForeColor = Color.White; //theoretisch möglich aber auch noch nie gesehen
							break;
					}
					if ((X + Y) % 2 == 0) //nach Karomuster wird Farbe in ein Braun gewechselt
					{
						Button.BackColor = Color.FromArgb(229, 194, 159); //helles braun
					}
					else
					{
						Button.BackColor = Color.FromArgb(215, 184, 153); //dunkelbraun
					}
				}
				else //keine Minen in der nähe
				{
					if ((X + Y) % 2 == 0) //Hintergrund wird auch hier in ein Braun geändert
					{
						Button.BackColor = Color.FromArgb(229, 194, 159);
					}
					else
					{
						Button.BackColor = Color.FromArgb(215, 184, 153);
					}
					Button.Enabled = false; //vorallem für den visuellen Effekt, Button "leuchtet" nicht mehr auf

					//hier werden alle umliegenden Squares geöffnet, indem sie erst von der Gameclass überprüft werden
					_game.OpenSpot(X - 1, Y - 1);
					_game.OpenSpot(X - 0, Y - 1);
					_game.OpenSpot(X + 1, Y - 1);
					_game.OpenSpot(X - 1, Y - 0);
					_game.OpenSpot(X - 0, Y - 0);
					_game.OpenSpot(X + 1, Y - 0);
					_game.OpenSpot(X - 1, Y + 1);
					_game.OpenSpot(X - 0, Y + 1);
					_game.OpenSpot(X + 1, Y + 1);
				}
			}
		}

		/// <summary>
		/// method to set Dismantle event
		/// </summary>
		protected void OnDismantle()
		{
			if (Dismantle != null)
			{
				Dismantle(this, new EventArgs());
			}
		}

		/// <summary>
		/// Method to set Explode event
		/// </summary>
		protected void OnExplode()
		{
			if (Explode != null)
			{
				Explode(this, new EventArgs());
			}
		}

		/// <summary>
		/// get method for Button
		/// </summary>
		public Button Button
		{
			get { return (this._button); }
		}
		/// <summary>
		/// get method for X
		/// </summary>
		public int X
		{
			get { return (this._x); }
		}

		/// <summary>
		/// get method for Y
		/// </summary>
		public int Y
		{
			get { return (this._y); }
		}
		/// <summary>
		/// get method for Dismantled
		/// </summary>
		public bool Dismantled
		{
			get { return (this._dismantled); }
		}
		/// <summary>
		/// get method for Opened
		/// </summary>
		public bool Opened
		{
			get { return (this._opened); }
		}

		/// <summary>
		/// method to unsubrscribe events
		/// </summary>
		public void RemoveEvents()
		{
			_button.Click -= new EventHandler(Click);
			_button.MouseDown -= new MouseEventHandler(DismantleClick);
		}
	}
}
