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


namespace SimpleThreads
{
    public partial class Form1 : Form
    {

        String text;
        public Form1()
        {
            InitializeComponent();
        }

        private void threadOne_Click(object sender, EventArgs e)
        {
            if (getText())
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    MessageBox.Show("Tread one "+text);
                
                }).Start();
            }
        }

        private void threadTwo_Click(object sender, EventArgs e)
        {
            if (getText())
            {
                Thread t = new Thread(MyThread);
                t.Start();
            }
        }

        public void MyThread()
        {
            MessageBox.Show("Thread two "+text);
        }

        public Boolean getText()
        {
            if (txt.Text.Equals(""))
            {
                MessageBox.Show("Introduce algun texto");
                return false;
            }
            else
            {
                text = txt.Text;
                return true;
            }
        }
    }
}
