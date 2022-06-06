using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_21
{
    public partial class Form1 : Form
    { //нарисовали фигуры и задали координаты
        Rectangle Rectangle = new Rectangle(30, 50, 200, 100);
        bool RectangleClick = false;//проверка на клик
        int RestangleX, RestangleY = 0;

        Rectangle Circle = new Rectangle(275, 50, 150, 150);
        bool CircleClick = false;
        int CircleX, CircleY = 0;

        Rectangle Square = new Rectangle(500, 50, 150, 150);
        bool SquareClick = false;
        int SquareX, SquareY = 0;

        int X, Y, dX, dY, LastClick= 0;

        private void vid_lbl_Click(object sender, EventArgs e)
        {

        }

        private void info_lbl_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void fon_pctbx_Click(object sender, PaintEventArgs e)
        {//раскрасили фигуры
         e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
         e.Graphics.FillEllipse(Brushes.Red, Circle);
         e.Graphics.FillRectangle(Brushes.Blue, Square);    
        }

        private void fon_pctbx_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))//е-параметр для событий мыши; 
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    RectangleClick = true;
                    LastClick = 1;
                    RestangleX = e.X - Rectangle.X;
                    RestangleY = e.Y - Rectangle.Y;
                    return;
                }
            }

            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleClick = true;
                    LastClick = 2;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                    return;
                }
            }

            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    LastClick = 3;
                    SquareClick = true;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;
                    return;
                }
            }
            if ((vid_lbl.Location.X < Square.X + Square.Width) && (vid_lbl.Location.X > Square.X))
            {
                if ((vid_lbl.Location.Y < Square.Y + Square.Height) && (vid_lbl.Location.Y > Square.Y))
                {
                    info_lbl.Text = "Квадрат синий";
                }
            }

            if ((vid_lbl.Location.X < Rectangle.X + Rectangle.Width) && (vid_lbl.Location.X > Rectangle.X))
            {
                if ((vid_lbl.Location.Y < Rectangle.Y + Rectangle.Height) && (vid_lbl.Location.Y > Rectangle.Y))
                {
                    info_lbl.Text = "Прямоугольник желтый";
                }
            }

            if ((vid_lbl.Location.X < Circle.X + Circle.Width) && (vid_lbl.Location.X > Circle.X))
            {
                if ((vid_lbl.Location.Y < Circle.Y + Circle.Height) && (vid_lbl.Location.Y > Circle.Y))
                {
                    info_lbl.Text = "Круг красный";
                }
            }

        }
        private void fon_pctbx_MouseUp(object sender, MouseEventArgs e)//замена фигур
        {
            if ((forma_lbl.Location.X < Rectangle.X + Rectangle.Width) && (forma_lbl.Location.X > Rectangle.X))
            {
                if ((forma_lbl.Location.Y < Rectangle.Y + Rectangle.Height) && (forma_lbl.Location.Y > Rectangle.Y))
                {
                   X = Rectangle.X;
                   Y = Rectangle.Y;
                   dX = RestangleX;
                   dY = RestangleY;
                   Rectangle.X = Circle.X;
                   Rectangle.Y = Circle.Y;
                   RestangleX = CircleX;
                   RestangleY = CircleY;

                   Circle.X = X;
                   Circle.Y = Y;
                   CircleX = dX;
                   CircleY = dY;

                }
            }
                       
                    
            if ((forma_lbl.Location.X < Circle.X + Circle.Width) && (forma_lbl.Location.X > Circle.X))
            {
                if ((forma_lbl.Location.Y < Circle.Y + Circle.Height) && (forma_lbl.Location.Y > Circle.Y))
                {
                    X = Circle.X;
                    Y = Circle.Y;
                    dX = CircleX;
                    dY = CircleY;
                    Circle.X = Square.X;
                    Circle.Y = Square.Y;
                    CircleX = SquareX;
                    CircleY = SquareY;

                    Square.X = X;
                    Square.Y = Y;
                    SquareX = dX;
                    SquareY = dY;
                }
            }

                        
                    
             if ((forma_lbl.Location.X < Square.X + Square.Width) && (forma_lbl.Location.X > Square.X))
             {
                 if ((forma_lbl.Location.Y < Square.Y + Square.Height) && (forma_lbl.Location.Y > Square.Y))
                 {
                     X = Square.X;
                     Y = Square.Y;
                     dX = SquareX;
                     dY = SquareY;
                     Square.X = Circle.X;
                     Square.Y = Circle.Y;
                     SquareX = CircleX;
                     SquareY = CircleY;

                     Circle.X = X;
                     Circle.Y = Y;
                     CircleX = dX;
                     CircleY = dY;
                 }
             }
                       

            SquareClick = false;
            CircleClick = false;
            RectangleClick = false;
        }
        private void fon_pctrbx_MouseMove(object sender, MouseEventArgs e)//определение координат
        {
            if (CircleClick)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
            }
            if (RectangleClick)
            {
                Rectangle.X = e.X - RestangleX;
                Rectangle.Y = e.Y - RestangleY;
            }
            if (SquareClick)
            {
                Square.X = e.X- SquareX;
                Square.Y = e.Y - SquareY;
            }
            fon_pctbx.Invalidate();
        }
        private void fon_pctbx_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
