using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Обложување_на_кучиња
{
    public partial class Statistics : Form
    {
        public int wins1;
        public int wins2;
        public int wins3;
        public int wins4;
        public int wins5;
        public int wins6;
        public Statistics(int w1, int w2, int w3, int w4, int w5, int w6)
        {
            InitializeComponent();
            this.wins1 = w1;
            this.wins2 = w2;
            this.wins3 = w3;
            this.wins4 = w4;
            this.wins5 = w5;
            this.wins6 = w6;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Pen myPen10;
            myPen10 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics10 = this.CreateGraphics();
            formGraphics10.DrawLine(myPen10, 160, 0, 160, 800);
            myPen10.Dispose();
            formGraphics10.Dispose();
            System.Drawing.Pen myPen11;
            myPen11 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics11 = this.CreateGraphics();
            formGraphics11.DrawLine(myPen11, 238, 0, 238, 800);
            myPen11.Dispose();
            formGraphics11.Dispose();
            System.Drawing.Pen myPen12;
            myPen12 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics12 = this.CreateGraphics();
            formGraphics12.DrawLine(myPen12, 316, 0, 316, 800);
            myPen12.Dispose();
            formGraphics12.Dispose();
            System.Drawing.Pen myPen13;
            myPen13 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics13 = this.CreateGraphics();
            formGraphics13.DrawLine(myPen13, 393, 0, 393, 800);
            myPen13.Dispose();
            formGraphics13.Dispose();
            System.Drawing.Pen myPen14;
            myPen14 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics14 = this.CreateGraphics();
            formGraphics14.DrawLine(myPen14, 469, 0, 469, 800);
            myPen14.Dispose();
            formGraphics14.Dispose();
            System.Drawing.Pen myPen15;
            myPen15 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics15 = this.CreateGraphics();
            formGraphics15.DrawLine(myPen15, 546, 0, 546, 800);
            myPen15.Dispose();
            formGraphics15.Dispose();
            System.Drawing.Pen myPen16;
            myPen16 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics16 = this.CreateGraphics();
            formGraphics16.DrawLine(myPen16, 623, 0, 623, 800);
            myPen16.Dispose();
            formGraphics16.Dispose();
            System.Drawing.Pen myPen17;
            myPen17 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics17 = this.CreateGraphics();
            formGraphics17.DrawLine(myPen17, 700, 0, 700, 800);
            myPen17.Dispose();
            formGraphics17.Dispose();
            System.Drawing.Pen myPen18;
            myPen18 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics18 = this.CreateGraphics();
            formGraphics18.DrawLine(myPen18, 776, 0, 776, 800);
            myPen18.Dispose();
            formGraphics18.Dispose();
            if (wins1 < 10)
            {
                if (wins1 == 1)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 60, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
                else if (wins1 == 2)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 138, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
                else if (wins1 == 3)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 216, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
                else if (wins1 == 4)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 293, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
                else if (wins1 == 5)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 369, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
                else if (wins1 == 6)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 446, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
                else if (wins1 == 7)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 523, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
                else if (wins1 == 8)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 600, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
                else if (wins1 == 9)
                {
                    System.Drawing.SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    System.Drawing.Graphics formGraphics1 = this.CreateGraphics();
                    formGraphics1.FillRectangle(myBrush1, new Rectangle(100, 28, 676, 43));
                    myBrush1.Dispose();
                    formGraphics1.Dispose();
                }
            }
            if (wins2 < 10)
            {
                if (wins2 == 1)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 60, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
                else if (wins2 == 2)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 138, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
                else if (wins2 == 3)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 216, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
                else if (wins2 == 4)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 293, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
                else if (wins2 == 5)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 369, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
                else if (wins2 == 6)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 446, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
                else if (wins2 == 7)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 523, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
                else if (wins2 == 8)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 600, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
                else if (wins2 == 9)
                {
                    System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                    System.Drawing.Graphics formGraphics2 = this.CreateGraphics();
                    formGraphics2.FillRectangle(myBrush2, new Rectangle(100, 92, 676, 43));
                    myBrush2.Dispose();
                    formGraphics2.Dispose();
                }
            }
            if (wins3 < 10)
            {
                if (wins3 == 1)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 60, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
                if (wins3 == 2)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 138, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
                if (wins3 == 3)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 216, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
                if (wins3 == 4)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 293, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
                if (wins3 == 5)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 369, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
                if (wins3 == 6)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 446, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
                if (wins3 == 7)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 523, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
                if (wins3 == 8)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 600, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
                if (wins3 == 9)
                {
                    System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    System.Drawing.Graphics formGraphics3 = this.CreateGraphics();
                    formGraphics3.FillRectangle(myBrush3, new Rectangle(100, 156, 676, 43));
                    myBrush3.Dispose();
                    formGraphics3.Dispose();
                }
            }
                if (wins4 < 10)
                {
                    if (wins4 == 1)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 60, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                    if (wins4 == 2)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 138, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                    if (wins4 == 3)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 216, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                    if (wins4 == 4)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 293, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                    if (wins4 == 5)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 369, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                    if (wins4 == 6)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 446, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                    if (wins4 == 7)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 523, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                    if (wins4 == 8)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 600, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                    if (wins4 == 9)
                    {
                        System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.Graphics formGraphics4 = this.CreateGraphics();
                        formGraphics4.FillRectangle(myBrush4, new Rectangle(100, 221, 676, 43));
                        myBrush4.Dispose();
                        formGraphics4.Dispose();
                    }
                }
                if (wins5 < 10)
                {
                    if (wins5 == 1)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 60, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                    if (wins5 == 2)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 138, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                    if (wins5 == 3)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 216, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                    if (wins5 == 4)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 293, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                    if (wins5 == 5)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 369, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                    if (wins5 == 6)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 446, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                    if (wins5 == 7)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 523, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                    if (wins5 == 8)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 600, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                    if (wins5 == 9)
                    {
                        System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
                        System.Drawing.Graphics formGraphics5 = this.CreateGraphics();
                        formGraphics5.FillRectangle(myBrush5, new Rectangle(100, 285, 676, 43));
                        myBrush5.Dispose();
                        formGraphics5.Dispose();
                    }
                }
                if (wins6 < 10)
                {
                    if (wins6 == 1)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 60, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 60, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                    if (wins6 == 2)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 138, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 138, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                    if (wins6 == 3)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 216, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 216, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                    if (wins6 == 4)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 293, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 293, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                    if (wins6 == 5)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 369, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 369, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                    if (wins6 == 6)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 446, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 446, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                    if (wins6 == 7)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 523, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 523, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                    if (wins6 == 8)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 600, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 600, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                    if (wins6 == 9)
                    {
                        System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        System.Drawing.Graphics formGraphics6 = this.CreateGraphics();
                        System.Drawing.Graphics formGraphics7 = this.CreateGraphics();
                        formGraphics6.FillRectangle(myBrush6, new Rectangle(100, 350, 676, 22));
                        formGraphics7.FillRectangle(myBrush7, new Rectangle(100, 372, 676, 21));
                        myBrush6.Dispose();
                        myBrush7.Dispose();
                        formGraphics6.Dispose();
                        formGraphics7.Dispose();
                    }
                }
            if(wins1 > 9 || wins2 > 9 || wins3 > 9 || wins4 > 9 || wins5 > 9 || wins6 > 9 )
            {
                MessageBox.Show("Not valid number of wins ");
            }
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
