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


        bool _moveRight, _moveLeft, _Open;
        int  _posObj = 0, _Point =0;

        int speed = 0;
        public Form1()
        {
            InitializeComponent();
            _Open= false;
            Points.Text = "Point" + _Point;
            OpenBin.Location = TrashBack.Location;
        }

        private void MoveTrashbackivent(object sender, EventArgs e)
        {
            OpenBin.Location = TrashBack.Location;
            speed = this.Size.Width / 2 - 50;
            if (_moveLeft == true && TrashBack.Left > 0)
            {
                if (!(TrashBack.Left - speed < 1))
                {
                    TrashBack.Left -= speed;
                    _posObj--;
                }
            }
            if (_moveRight == true && TrashBack.Right < this.Width -50)
            {
                if (!(TrashBack.Left + speed > this.Width - 50))
                {
                    TrashBack.Left += speed;
                    _posObj++;
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
        }

        private void OpenBin_Click(object sender, EventArgs e)
        {

        }

        private void ResizeEvent(object sender, EventArgs e)
        {
            if (_posObj == 0)
            {

            TrashBack.Left = 1;
            }
            if (_posObj == 1)
            {
                TrashBack.Left = speed;
                
            }
            if (_posObj == 2)
            {
                TrashBack.Left = speed*2;
            }
            TrashBack.Top = this.Height - 130;
            
           

        }

        private void EventTimerBottle(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next();

            pictureBox1.Top += this.Height  /5;
            if (pictureBox1.Top >= TrashBack.Top -100 && _Open )
            {
                _Point += 1;
                Points.Text = "Point" + _Point;
                pictureBox1.Left= speed*(num % 3);
                pictureBox1.Top = 0;
            }
            else if (pictureBox1.Top >= TrashBack.Top - 100 && !_Open)
            {
                _Point -= 1;
                Points.Text = "Point" + _Point;
                pictureBox1.Left = speed * (num % 3);
                pictureBox1.Top = 0;
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
    }
}
