using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istatistik_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int baslangic = 0, son = 0, adet = 0, sonuc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                baslangic = int.Parse(textBox1.Text);
                son = int.Parse(textBox2.Text);
                adet = int.Parse(textBox3.Text);
                Random rnd = new Random();
                for (int i = 0; i < adet; i++)
                {
                    sonuc = rnd.Next(baslangic, son);
                    listBox1.Items.Add(sonuc);
                }
            }
            catch (Exception)
            {
                if (son < baslangic)
                {
                    MessageBox.Show("Başlangıç değeri Son değerinden büyük!", "Yanlış Değer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (son == baslangic) MessageBox.Show("Başlangıç değeri Son değerine eşit!", "Yanlış Değer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Herhangi bir değer girmediniz!", "Boş Değer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
            
        }
    }
}
