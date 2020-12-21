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
		public event EventHandler Dismantle;
		public event EventHandler Explode;

		private bool _dismantled = false;
		private bool _opened = false;

		private Button _button;
		private Game _game;
		private int _x;
		private int _y;

		Random rand = new Random();

		public bool IsMine { get; set; }

		public Square(Game game, int x, int y)
		{
			_game = game;
			_x = x;
			_y = y;
			_button = new Button();
			Button.Text = "";

			int w = _game.Panel.Width / _game.Width;
			int h = _game.Panel.Height / _game.Height;

			_button.Width = w + 1;
			_button.Height = h + 1;
			_button.Left = w * X;
			_button.Top = h * Y;
			_button.FlatStyle = FlatStyle.Flat;
			_button.FlatAppearance.BorderSize = 0;
			_button.TabStop = false;
			_button.Font = new System.Drawing.Font("Arial Black", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			if ((X+Y)%2==0)
            {
				_button.BackColor = Color.FromArgb(170, 215, 81);
			}
			else
            {
				_button.BackColor = Color.FromArgb(162, 209, 73);
			}
			_button.Click += new EventHandler(Click);
			_button.MouseDown += new MouseEventHandler(DismantleClick);

			_game.Panel.Controls.Add(Button);
		}

		private void Click(object sender, System.EventArgs e)
		{
			if (!Dismantled)
			{
				if (IsMine)
				{
					Button.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
					Button.Font = new Font("Microsoft Sans Serif", 18);
					Button.Text = "B"; //•
					OnExplode();
					Button.Enabled = false;
				}
				else
				{
					this.Open();
				}
			}
		}

		private void DismantleClick(object sender, MouseEventArgs e)
		{
			if (!Opened && e.Button == MouseButtons.Right)
			{
				if (Dismantled)
				{
					_dismantled = false;
					if ((X + Y) % 2 == 0)
					{
						Button.BackColor = Color.FromArgb(170, 215, 81);
					}
					else
					{
						Button.BackColor = Color.FromArgb(162, 209, 73);
					}
					Button.ForeColor = Color.FromArgb(242, 54, 7);
					Button.Text = "?";
				}
				else
				{
					_dismantled = true;
					Button.BackColor = Color.Green;
					Button.Text = "";
				}
				OnDismantle();
			}
		}
		public void Open()
		{
			if (!Opened && !Dismantled)
			{
				_opened = true;
				// Count Bombs
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

				if (c > 0)
				{
					Button.Text = c.ToString();
					switch (c)
					{
						case 1:
							Button.ForeColor = Color.FromArgb(25, 118, 210); //light blue
							break;
						case 2:
							Button.ForeColor = Color.FromArgb(56, 142, 60); //green
							break;
						case 3:
							Button.ForeColor = Color.FromArgb(211, 47, 47); //red
							break;
						case 4:
							Button.ForeColor = Color.FromArgb(123, 31, 162); //violet
							break;
						case 5:
							Button.ForeColor = Color.FromArgb(255, 143, 0); //orange
							break;
						case 6:
							Button.ForeColor = Color.LightBlue;
							break;
						case 7:
							Button.ForeColor = Color.Orange;
							break;
						case 8:
							Button.ForeColor = Color.Ivory;
							break;
					}
					if ((X + Y) % 2 == 0)
					{
						Button.BackColor = Color.FromArgb(229, 194, 159);
					}
					else
					{
						Button.BackColor = Color.FromArgb(215, 184, 153);
					}
				}
				else
				{
					if ((X + Y) % 2 == 0)
					{
						Button.BackColor = Color.FromArgb(229, 194, 159);
					}
					else
					{
						Button.BackColor = Color.FromArgb(215, 184, 153);
					}
					Button.FlatStyle = FlatStyle.Flat;
					Button.Enabled = false;

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
		protected void OnDismantle()
		{
			if (Dismantle != null)
			{
				Dismantle(this, new EventArgs());
			}
		}
		protected void OnExplode()
		{
			if (Explode != null)
			{
				Explode(this, new EventArgs());
			}
		}

		public Button Button
		{
			get { return (this._button); }
		}
		public int X
		{
			get { return (this._x); }
		}

		public int Y
		{
			get { return (this._y); }
		}
		public bool Dismantled
		{
			get { return (this._dismantled); }
		}
		public bool Opened
		{
			get { return (this._opened); }
		}
	}
}
