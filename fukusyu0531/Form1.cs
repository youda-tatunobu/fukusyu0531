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
            //pictureBox1.ImageLocation = @"brook2.png";
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Text = MousePosition.X + "" + MousePosition.Y;
            Point p = PointToClient(MousePosition);

            textBox2.Left = p.X - textBox2.Width / 2;
            textBox2.Top = p.Y - textBox2.Height / 2;


            label1.Left += vx;
            label1.Top += vy;

      

            if (label1.Left >= ClientSize.Height - label1.Height)
            {
                vx = -Math.Abs(vx);
                label1.Left += vx;
                label1.Top += vy;
                count++;
            }

            if (label1.Left <= 0)
            {
                vx = -vx;
                label1.Left += vx;
                label1.Top += vy;
                count++;
            }

            if (label1.Top >= ClientSize.Width - label1.Width)
            {
                vy = -Math.Abs(vy);
                label1.Left += vx;
                label1.Top += vy;
                count++;
            }

            if (label1.Top <= 0)
            {
                vy = -vy;
                label1.Left += vx;
                label1.Top += vy;
                count++;
            }

            textBox1.Text = "跳ね返り" + count + "回です";

            f++;
            
            if(f==30)
            {
                s++;
                f=0;

            }else if(s==60){

                m++;
                s = 0;
                
            }
            textBox3.Text = m+"分" + s　+"秒";

            if ((label1.Left < textBox2.Right) && (label1.Right >textBox2.Left) && (label1.Top < textBox2.Bottom) && (label1.Bottom > textBox2.Top))
            {
               vx = -vx;
               vy = -vy;
               label1.Left += 5*vx;
               label1.Top += 5*vy;
               count++;
               
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
