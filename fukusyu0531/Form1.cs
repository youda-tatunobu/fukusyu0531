using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0531
{
    public partial class Form1 : Form
    {
        int vx=3, vy=4;

        int count=0,m=0,s=0,f=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Text = MousePosition.X + "" + MousePosition.Y;
            Point p = PointToClient(MousePosition);

            label2.Left = p.X - label2.Width/2;
            label2.Top = p.Y - label2.Height/2;


            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left >= ClientSize.Height - label1.Height)
            {
                vx = -vx; //Math.Abs(vx);
                count++;
            }

            if (label1.Left <= 0)
            {
                vx = -vx;
                count++;
            }

            if (label1.Top >= ClientSize.Width - label1.Width)
            {
                vy = -vy;//Math.Abs(vy);
                count++;
            }

            if (label1.Top <= 0)
            {
                vy = -vy; 
                count++;
            }

            textBox1.Text = "跳ね返り" + count + "回です";

            f++;
            
            if(f==60)
            {
                s++;
                f=0;

            }else if(s==60){

                m++;
                s = 0;
                
            }
            textBox3.Text = m+"分" + s　+"秒";

            if ((label1.Left <= p.X )&&(label1.Right>=p.X)&&(label1.Top<=p.Y)&&(label1.Bottom>=p.Y))
            {
                label1.Left -= vx;
                label1.Top -= vy;
               
            }

        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + ClientSize.Width + " " + ClientSize.Height);
            //MessageBox.Show("" + label1.Width + " " + label1.Height);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
