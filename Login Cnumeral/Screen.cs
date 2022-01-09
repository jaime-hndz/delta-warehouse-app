using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Cnumeral
{
    public partial class Screen : Form
    {
        public Screen()
        {
            InitializeComponent();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            while (this.Opacity > 0)
            {
                this.Opacity -= 0.0001;

            }
           
           this.Hide();
           Form1 f1 = new Form1();
           f1.Show();
           timer1.Stop();
                
            

        }
    }
}
