//Zach Evans -- Halloween card -- 09-26-17
//Simple halloween card with audio and graphics
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace spooky_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
  
        private void button1_Click(object sender, EventArgs e)
        {//getting rid of the title
            button1.Dispose();
            pictureBox1.Dispose();
            label1.Dispose();
            Refresh();
            
            //brushes
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.LightGray, 10);
            SolidBrush drawBrush = new SolidBrush(Color.LightGray);
            //audio
            SoundPlayer player = new SoundPlayer(Properties.Resources.mgs);
            player.Play();
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.ws);
            

            //spooky scary skeleton drawing
            formGraphics.FillEllipse(drawBrush, 160, 50, 120, 120);
            Thread.Sleep(500);
            drawBrush.Color = (Color.Black);
            formGraphics.FillEllipse(drawBrush, 170, 70, 30, 30);
            formGraphics.FillEllipse(drawBrush, 235, 70, 30, 30);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 207, 100, 10, 10);
            formGraphics.FillEllipse(drawBrush, 220, 100, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillRectangle(drawBrush, 180, 130, 80, 20);
            drawBrush.Color = (Color.LightGray);
            formGraphics.FillRectangle(drawBrush, 182, 130, 10, 7);
            formGraphics.FillRectangle(drawBrush, 195, 130, 10, 7);
            formGraphics.FillRectangle(drawBrush, 220, 130, 10, 7);
            Thread.Sleep(500);
            formGraphics.FillRectangle(drawBrush, 210, 160, 20, 110);
            //shoulders
            formGraphics.FillRectangle(drawBrush, 170, 172, 100, 10);
            //arms
            formGraphics.FillRectangle(drawBrush, 170, 172, 10, 70);
            formGraphics.FillRectangle(drawBrush, 260, 172, 10, 70);
            //ribs
            formGraphics.FillRectangle(drawBrush, 185, 185, 70, 6);
            Thread.Sleep(50);
            formGraphics.FillRectangle(drawBrush, 185, 195, 70, 6);
            Thread.Sleep(50);
            formGraphics.FillRectangle(drawBrush, 185, 205, 70, 6);
            Thread.Sleep(50);
            formGraphics.FillRectangle(drawBrush, 185, 215, 70, 6);
            //pelvis
            formGraphics.DrawRectangle(drawPen, 190, 240, 60, 30);
            Thread.Sleep(10);
            //legs
            formGraphics.FillRectangle(drawBrush, 235, 270, 10, 70);
            formGraphics.FillRectangle(drawBrush, 196, 270, 10, 70);
            Thread.Sleep(1500);

            spookyText.Visible = true;
            spookyText.Refresh();
            Thread.Sleep(4000);
            spookyText.Visible = false;
            spookyText.Refresh();
            Thread.Sleep(500);
            booText.Visible = true;
            booText.Refresh();

            player2.Play();
            drawBrush.Color = (Color.Red);
            formGraphics.FillEllipse(drawBrush, 170, 70, 30, 30);
            formGraphics.FillEllipse(drawBrush, 235, 70, 30, 30);   
        }
    }
}
