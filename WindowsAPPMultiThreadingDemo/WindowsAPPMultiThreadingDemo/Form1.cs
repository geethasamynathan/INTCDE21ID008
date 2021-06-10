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

namespace WindowsAPPMultiThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingwork_Click(object sender, EventArgs e)
        {
           // btnTimeConsumingwork.Enabled = false;
          //  btnPrintnumbers.Enabled = false;
            //approach:1
            // DoSomeTimeConsuming();
            //Approach:2 MultiThreading demo
            //Thread myttask = new Thread(DoSomeTimeConsuming);
            // myttask.Start();
            // Approach:3 Threadstart delegate
            Form1 form = new Form1();
            Thread t1 = new Thread(() => { form.PrintNumbers(); });
          t1.Start();
           
            //btnTimeConsumingwork.Enabled = true;
            //btnPrintnumbers.Enabled = true;
        }
        public void DoSomeTimeConsuming()
        {
            Thread.Sleep(5000);
        }

        public  void   PrintNumbers()
        {
            int result=0;
            for (int i = 100; i < 110; i++)
            {
              //  listView1.Items.Add(i.ToString());
                result = i;
            }
            MessageBox.Show(result.ToString());
        }
        private void btnPrintnumbers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                listView1.Items.Add(i.ToString());
            }
           
        }
    }
}
