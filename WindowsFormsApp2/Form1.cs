using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        bool _moveRight, _moveLeft, _Open, _esc;
        int  _posBin = 0, _Point =0, _posBotle = 0;

        int _speed = 0, _SmoothSpeedForBottles = 0;
        public Form1()
        {
            InitializeComponent();
            _Open= false;
            Points.Text = "Point" + _Point;
            OpenBin.Location = TrashBack.Location;
            TimerBottles.Interval /= 50; 
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        #region Games
        private void MoveTrashbackivent(object sender, EventArgs e)
        {
            OpenBin.Location = TrashBack.Location;
            _speed = this.Size.Width / 2 - 50;
            if (_moveLeft == true && TrashBack.Left > 0&& !_Open)
            {
                if (!(TrashBack.Left - _speed < 1))
                {
                    TrashBack.Left -= _speed;
                    _posBin--;
                }
            }
            if (_moveRight == true && TrashBack.Right < this.Width -50&& !_Open)
            {
                if (!(TrashBack.Left + _speed > this.Width - 50))
                {
                    TrashBack.Left += _speed;
                    _posBin++;
                }
            }
            if (_Open)
            {
                OpenBin.Visible = true;
            }
            if (!_Open)
            {
                OpenBin.Visible = false;
            }
            if (_esc)
            {
                _esc = false;
                BoxMenu.Visible = true;
                button1.Visible = true ;
                button1.Enabled = true ;
                TimerBottles.Enabled = false ;
                TimerTrashback.Enabled = false ;
            }
           


        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _moveLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                _moveRight = true;
            }
            if (e.KeyCode ==  Keys.E)
            {
                _Open = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                _esc = true;
            }
        }


      

        private void ResizeEvent(object sender, EventArgs e)
        {
            if (_posBin == 0)
            {

            TrashBack.Left = 1;
                
            }
            if (_posBin == 1)
            {
                TrashBack.Left = _speed;
                
            }
            if (_posBin == 2)
            {
                TrashBack.Left = _speed*2;
            }

            TrashBack.Top = this.Height - 130;
            
           

        }

        private void EventTimerBottle(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next();
            _SmoothSpeedForBottles = (this.Height / 5) / 50 + _Point;
            pictureBox1.Top +=_SmoothSpeedForBottles;
            if (pictureBox1.Top >= TrashBack.Top -50 && _Open&& _posBotle == _posBin )
            {
            num = rnd.Next();
                _Point += 1;
                Points.Text = "Point" + _Point;
                pictureBox1.Left= _speed*(num % 3);
                pictureBox1.Top = 0;
                _posBotle = num % 3;
            }
            else if (pictureBox1.Top >= TrashBack.Top - 50 && !_Open)
            {
                num = rnd.Next();
                _Point -= 1;
                Points.Text = "Point" + _Point;
                pictureBox1.Left = _speed * (num % 3);
                pictureBox1.Top = 0;
                _posBotle = num % 3;
            }
            
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                _moveRight = false;
            }
            if (e.KeyCode == Keys.E)
            {
                _Open= false;
            }
        }
        #endregion Game
        #region Menu

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            BoxMenu.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
            TimerBottles.Enabled = true;
            TimerTrashback.Enabled = true;  
        }

        #endregion Menu
    }
}
