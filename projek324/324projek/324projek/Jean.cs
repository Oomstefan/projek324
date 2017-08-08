using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _324projek
{
    public partial class Jean : Form
    {
        public Jean()
        {
            InitializeComponent();
        }
        public int val;
        public int[] range;

        private void button1_Click(object sender, EventArgs e)
        {
            random();
            string curVal;
            for (int k = 0; k < val; k++) {
                curVal = Convert.ToString(range[k]);
                label2.Text +=  " " + curVal ;
            }
            

        }

        public void random() {
            val = Convert.ToInt32(textBox1.Text);
            range = new int[val];
            Random r = new Random();
            ;
            for (int k = 0; k < val; k++) {
                range[k] = r.Next(5, 25);
            }

        //public int GCD() {



       // }


            
        }

    }
}
