using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Hello WOrld!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.ControlBox = false;
            //this.Text = string.Empty;
        }

        private Point mousePoint;
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool move = false;
 
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //move = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //move = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           if ((e.Button & MouseButtons.Left) == MouseButtons.Left) //마우스 왼쪽 클릭 시에만 실행
            {
                //폼의 위치를 드래그중인 마우스의 좌표로 이동 
                Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Font = new Font(Label.DefaultFont, FontStyle.Bold);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(Label.DefaultFont, FontStyle.Regular);
        }

        private void Form1_MouseLeave_1(object sender, EventArgs e)
        {

        }
    }
}
