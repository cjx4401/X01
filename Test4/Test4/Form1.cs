using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //====太阳========================================================
            
            int Y1 = pictureBox1.Location.Y;
            while ( Y1!=0)
            {
                Y1 -= 50;
                System.Threading.Thread.Sleep(1000);
                //timer1_Tick()
                // -----------------------这里怎么用timer1_Tick() 设置时间间隔？------------------
                pictureBox1.Location = new System.Drawing.Point(631, Y1);             
            }
            pictureBox1.Visible = false;
            //========公鸡=======================================================
         
            pictureBox2.Visible = true;
            pictureBox2.Show();                  
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"D:\My Documents\Visual Studio 2015\Projects\Test4\01.wav";
            sp.Play();
           //农夫
            timer1.Start();
            //家畜
            timer2.Start();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
           

            
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(pictureBox2.Visible==true)
            {  
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
            }
        }
    }
}
