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


        bool _moveRight, _moveLeft;
        int _LastWidh = 0;

        int speed = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void MoveTrashbackivent(object sender, EventArgs e)
        {
            _LastWidh = this.Size.Width;
            speed = this.Size.Width / 2 - 50;
            if (_moveLeft == true && TrashBack.Left > 0)
            {
                if (!(TrashBack.Left - speed < 1))
                {
                    TrashBack.Left -= speed;
                }
            }
            if (_moveRight == true && TrashBack.Right < this.Width -50)
            {
                if (!(TrashBack.Left + speed > this.Width - 50))
                {
                    TrashBack.Left += speed;
                }
            }

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                _moveRight = true;
            }
        }

        private void ResizeEvent(object sender, EventArgs e)
        {
            if (TrashBack.Left == 1)
            {

            TrashBack.Left = 1;
            }
            else if (TrashBack.Left == this._LastWidh /2)
            {
                TrashBack.Left = this.Width  /2  ;
            }
            else if (TrashBack.Left == this._LastWidh -50)
            {
                TrashBack.Left = this.Width -50;
            }
            TrashBack.Top = this.Height - 130;
            
           

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                _moveRight = false;
            }
        }
    }
}
