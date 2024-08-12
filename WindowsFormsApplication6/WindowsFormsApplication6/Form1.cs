using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            b = Convert.ToDouble(a) * Convert.ToDouble(textBox3.Text);

            textBox4.Text = b.ToString();
        }





        int i;


        private void button2_Click(object sender, EventArgs e)
        {

            for (i = 1; i <= 200; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0)) listBox1.Items.Add("zig");
                if ((i % 5 == 0) && (i % 3 != 0)) listBox1.Items.Add("zag");
                if ((i < 100) && (i % 15 == 0)) listBox1.Items.Add("zigzag");
                if ((i >= 100) && (i % 15 == 0)) listBox1.Items.Add("zagzig");

                if ((i % 3 != 0) && (i % 5 != 0) && (i % 15 != 0))
                    listBox1.Items.Add(i);


            }
        }

        int seri;
        int T1, T2;

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            a = Int32.Parse(textBox6.Text);

            for (int k = 1; k <= a; k++)

            {

                for (int l = 1; l <= a; l++)

                {

                    listBox3.Items.Add(k + " x " + l + " = " + k * l);

                }
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "metin Dosyası |*.docx;*.txt|  Tüm Dosyalar |*.* ";

            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            try
            {
                //string[] parcalar  = File.ReadAllLines(DosyaYolu);
                StreamReader tuba = new StreamReader(DosyaYolu);
                String line = tuba.ReadLine();
                String[] parcalar = line.Split(' ');


                // string metin;
                //metin = oku.ReadLine();

                int toplam = parcalar.Length;


                for (int i = 0; i < toplam-1; i++)
                {

                    for (int j = i+1; j < toplam ; j++)
                    {
                        if (Int32.Parse(parcalar[j]) < Int32.Parse(parcalar[i]))
                        {
                            String aradeger = parcalar[i];
                            parcalar[i] = parcalar[j];
                            parcalar[j] = aradeger;
                        }
                    }

                    listBox4.Items.Add(parcalar[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            T1 =0 ;
            T2 = 1;
            if (float.Parse(textBox5.Text) == 0) seri = 1;//text'e girilen 0 ise seri 1 olsun
            else if (float.Parse(textBox5.Text) == 1) seri = 1;//text'e girilen 1 ise seri 1 olsun
            else//0 ve 1 dışında ise
            {
                
                for (int i = 0; i <=float.Parse(textBox5.Text)-2; i++) // i sıfırdan bir bir text'e girilen değerden küçük olduğu sürece
                {
                    seri = T1 + T2;
                    T1 = T2;
                    T2 = seri;
                }
            }
            listBox2.Items.Add(seri);
           
            seri = 0;
        }
    }
   
        
    
}
