using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstatistik__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double N = 0, n = 0, k = 0, sonuc = 0;
        double k1;
        private void button1_Click(object sender, EventArgs e)
        {
            try 
	         {	        
		    N = int.Parse(textBox1.Text);
                    n = int.Parse(textBox2.Text);
                    k1 = N / n;
                    k =Convert.ToInt16(Math.Ceiling(k1));
                    label5.Text = k.ToString();
                    Random rnd = new Random();
                    sonuc = rnd.Next(0,(int)k);
                    for (int i = 0; i < n; i++)
                    {
                        listBox1.Items.Add(sonuc);
                        sonuc += k;
                    }
	         }
	        catch (Exception)
	            {
                   
                MessageBox.Show("Herhangi bir değer girmediniz!", "Boş Değer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
	            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
