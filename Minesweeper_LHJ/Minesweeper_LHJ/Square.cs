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
		private Button _button;
		private Game _game;
		private int _x;
		private int _y;

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
			_button.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			if ((X+Y)%2==0)
            {
				_button.BackColor = Color.FromArgb(170, 215, 81);
			}
			else
            {
				_button.BackColor = Color.FromArgb(162, 209, 73);
			}
			

			_game.Panel.Controls.Add(Button);
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
	}
}
