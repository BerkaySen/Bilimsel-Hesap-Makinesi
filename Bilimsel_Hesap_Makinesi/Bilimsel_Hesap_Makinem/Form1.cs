using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilimsel_Hesap_Makinem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double s1 = 0;
        double s2 = 0;
        //int cıkıs = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button12.BackColor = Color.Black;
            button12.ForeColor = Color.Green;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Green;
            label2.Text = ("0");
            label2.ForeColor = Color.Blue;
            groupBox1.Visible = true;
        }
       // int aratpl = 0;
        Double sontpl = 0;
        int btnmod = 0;
        int btnsin = 0 , btnsinh =0;
        int btncos = 0;
        int btntan = 0;
        int btntanh = 0;
        int btncosh = 0;
        int btnlog = 0;
        int btnus = 0, btnPi=0;
        int btnkare = 0, btnfak=0;
        int btnint = 0 , btnin =0;
        int butonInv = 0;
        int hafıza = 0 , tıklıhafıza =0;
        int hafıza2, tıklıhafıza2;
        int btnonuzeri = 0;
        private void btnTanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                s1 = int.Parse(textBox1.Text);
                double tanh = Math.Tanh(s1);
                label2.Text = (tanh).ToString();
                btntanh = 0;
                s1 = 0;
                s2 = 0;
                //btntanh = 1;
                textBox1.Focus();
                textBox1.ResetText();

            }
            
        }

        private void btnOnUzeri_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
                textBox1.ResetText();
            }
            else
            {
                s1 = double.Parse(textBox1.Text);
               // double tanh = Math.Tanh(s1);
                //label2.Text = (tanh).ToString();
                btnonuzeri = 0;
               // s1 = 0;
                //s2 = 0;
                btnonuzeri = 1;
                textBox1.Focus();
                textBox1.ResetText();

            }

           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = ("0");
            textBox1.Text = "";
            int sontpl = 0;
            int btnmod = 0;
            int btnsin = 0, btnsinh = 0;
            int btncos = 0;
            int btntan = 0;
            int btntanh = 0;
            int btncosh = 0;
            int btnlog = 0;
            int btnus = 0, btnPi=0;
            int btnkare = 0,btnfak;
            int btnint = 0, btnin = 0;
            Double s1 = 0;
            double s2 = 0;
            int butonInv = 0;
            int hafıza = 0;
            int hafıza2, tıklıhafıza2;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           //tboxcıkıs = textbox + gi;

            //if (textBox1.Text != "")
            //{
              //  groupBox1.Visible = true;
            //}
           // else
             //   groupBox1.Visible = false;
        }
        int textbox = 0;
        int textboxcıkıs = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1).ToString();
            textBox1.Focus();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = (4).ToString();
            textBox1.Focus();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = (7).ToString();


            textBox1.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                textBox1.Text = (2).ToString();
                textBox1.Focus();

            
            
            


            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = (5).ToString();


            textBox1.Focus();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = (8).ToString();

            textBox1.Focus();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (3).ToString();

            textBox1.Focus();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = (6).ToString();

            textBox1.Focus();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = (9).ToString();

            textBox1.Focus();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = (0).ToString();

            textBox1.Focus();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                s1 = int.Parse(textBox1.Text);
                label2.Text = (s1 * s1).ToString();
                btnkare = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btnkare = 1;
                textBox1.Focus();
                textBox1.ResetText();
            }
            
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {

                s1 = int.Parse(textBox1.Text);
               // label2.Text = (Math.PI * Math.Pow(s1, s1)).ToString();
                //btnus = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btnus = 1;
                textBox1.Focus();
                textBox1.ResetText();
            }
           
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                s1 = double.Parse(textBox1.Text);
                label2.Text = (Math.Log10((double)s1).ToString());//ssssssssssssssssssssssssssssssssssssssssssssss
                btnlog = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btnlog = 1;
                textBox1.Focus();
                textBox1.ResetText();
            }
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {

                s1 = int.Parse(textBox1.Text);
                double sinh = Math.Sinh(s1);
                label2.Text = (sinh).ToString();
                btnsinh = 0;
                s1 = 0;

                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btnsinh = 1;
                textBox1.Focus();
                textBox1.ResetText();
            }

        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                s1 = int.Parse(textBox1.Text);
                double cosh = Math.Cosh(s1);
                label2.Text = (cosh).ToString();
                btncosh = 0;
                s1 = 0;

                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btncosh = 1;
                textBox1.Focus();
                textBox1.ResetText();

            }
            
        }

        private void btnFaktoriyel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {

                s1 = int.Parse(textBox1.Text);
                int i, fakt = 1;
                for (i = 1; i <= s1; i++)
                {
                    fakt = fakt * i;
                }
                label2.Text = (fakt).ToString();
                btnin = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btnfak = 1;
                textBox1.Focus();
                textBox1.ResetText();

            }
            textBox1.ResetText();
        }
        
        
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
                textBox1.Focus();
            }
            else
            {
                
                s1 = int.Parse(textBox1.Text);
                /*sontpl = s1 % s2;
                label2.Text = (sontpl).ToString();
                btnmod = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();*/
                btnmod = 1;
                textBox1.Focus();
                textBox1.ResetText();
                
            }
            
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                
                s1 = int.Parse(textBox1.Text);
                label2.Text = (Math.Sin(Math.PI * s1 / 180)).ToString();//**************************
                btnsin = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btnsin = 1;
                textBox1.Focus();
                textBox1.ResetText();
            }
            
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                s1 = int.Parse(textBox1.Text);
                label2.Text = (Math.Cos(Math.PI * s1 / 180)).ToString();//*************************
                btncos = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btncos = 1;
                textBox1.Focus();
                textBox1.ResetText();

            }
            
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                s1 = int.Parse(textBox1.Text);
                label2.Text = (Math.Tan((Math.PI * s1) / 180)).ToString();//************************************
                btntan = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btntan = 1;
                textBox1.Focus();
                textBox1.ResetText();
                textBox1.ResetText();

            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
             if (btnmod ==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                    else if (tıklıhafıza == 1)
                    {
                        s2 = int.Parse(textBox1.Text);

                        sontpl = s1 % s2;
                        sontpl = sontpl + hafıza2;
                        label2.Text = (sontpl).ToString();
                        btnmod = 0;
                        s1 = 0;
                        s2 = 0;
                        sontpl = 0;
                        textBox1.Focus();
                        textBox1.ResetText();
                        tıklıhafıza = 0;
                    }
                  else if (tıklıhafıza2 == 1)
                {
                    sontpl = s1 % s2;
                    sontpl = sontpl - hafıza2;
                    label2.Text = (sontpl).ToString();
                    btnmod = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza2 = 0;

                }
                
                 else
                {
                    s2 = int.Parse(textBox1.Text);

                   sontpl = s1 % s2;
                    label2.Text = (sontpl = s1 % s2).ToString();
                    btnmod = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
                 else if (btnonuzeri ==1)
             {
                 if (textBox1.Text == "")
                 {
                     MessageBox.Show("Boş Değer Girilemez !!");
                 }
                     else
                 {
                     label2.Text = ((Math.Pow(10,s1)).ToString());//**************************
                     btnsin = 0;
                     s1 = 0;
                     s2 = 0;
                     sontpl = 0;
                     textBox1.Focus();
                     textBox1.ResetText();

                 }

             }
            else if (btnsin ==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    label2.Text = (Math.Sin(Math.PI * s1 / 180)+ hafıza).ToString();//**************************

                    btnsin = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza = 0;
                }
                    else if (tıklıhafıza2 ==1)
                {
                    sontpl = sontpl - hafıza2;
                    btnsin = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza2 = 0;

                }
                else
                {
                   // s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    
                    label2.Text = (Math.Sin(Math.PI * s1 / 180)).ToString();//**************************
                    btnsin = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
            else if (btncos ==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    label2.Text = (Math.Cos(Math.PI * s1 / 180)).ToString();//*************************
                    btncos = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza = 0;
                }
                    else if(tıklıhafıza2 ==1)
                {
                    s1 = s1 - hafıza2;
                    label2.Text = (Math.Cos(Math.PI * s1 / 180)).ToString();//*************************
                    btncos = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza2 = 0;

                }
                else
                {
                    //s2 = int.Parse(textBox1.Text);
                    // sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.

                    label2.Text = (Math.Cos(Math.PI * s1 / 180)).ToString();//*************************
                    btncos = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
             else if (btnPi ==1)
             {
                  if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else
                {
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    //double pi = s1() * 180 / Math.PI;
                    //double pi = (Math.PI(s1)).tostring;
                    //label2.Text = (pi).ToString();
                    btntanh = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
             }
            else if (btntan ==1)
            {
                //s2 = int.Parse(textBox1.Text);
                 //sontpl = s1+s2;
                //+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    label2.Text = (Math.Tan((Math.PI * s1) / 180)).ToString();//************************************
                    btntan = 0;
                    hafıza = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza = 0;
                }
                    else if(tıklıhafıza2 == 1)
                {
                    s1 = s1 - hafıza2;
                    label2.Text = (Math.Tan((Math.PI * s1) / 180)).ToString();//************************************
                    btntan = 0;
                    hafıza2 = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza2 = 0;

                }
                else
                {
                label2.Text = (Math.Tan((Math.PI * s1) / 180)).ToString();//************************************
                btntan = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                }

            }
            else if (btntanh ==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    double tanh = Math.Tanh(s1);
                    label2.Text = (tanh).ToString();
                    btntanh = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    tıklıhafıza = 0;
                }
                    else if(tıklıhafıza2 ==1)
                {
                    s1 = s1 - hafıza2;
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    double tanh = Math.Tanh(s1);
                    label2.Text = (tanh).ToString();
                    btntanh = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    tıklıhafıza2 = 0;

                }
                else
                {
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    double tanh = Math.Tanh(s1);
                    label2.Text = (tanh).ToString();
                    btntanh = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
            else if (btncosh==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    double cosh = Math.Cosh(s1);
                    label2.Text = (cosh).ToString();
                    btncosh = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    tıklıhafıza = 0;
                }
                    else if (tıklıhafıza2 ==1)
                {
                    s1 = s1 - hafıza2;
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    double cosh = Math.Cosh(s1);
                    label2.Text = (cosh).ToString();
                    btncosh = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    tıklıhafıza2 = 0;

                }
                else
                {
                    s2 = int.Parse(textBox1.Text);
                    
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    double cosh = Math.Cosh(s1);
                    label2.Text = (cosh).ToString();
                    btncosh = 0;
                    s1 = 0;
                    
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
            else if (btnsinh == 1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    double sinh = Math.Sinh(s1);
                    label2.Text = (sinh).ToString();
                    btnsinh = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza = 0;
                }
                    else if(tıklıhafıza2 ==1)
                {
                    s1 = s1 - hafıza2;
                    double sinh = Math.Sinh(s1);
                    label2.Text = (sinh).ToString();
                    btnsinh = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza2 = 0;
                }
                else
                {
                    //s2 = int.Parse(textBox1.Text);
                   // sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    
                    double sinh = Math.Sinh(s1);
                    label2.Text = (sinh).ToString();
                    btnsinh = 0;
                    s1 = 0;
                    
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
            else if (btnlog ==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    s1 = s1 + hafıza;
                    //double alan = Math.PI * Math.Pow(s1, s2);
                    label2.Text = (Math.Log10((double)s1).ToString());//ssssssssssssssssssssssssssssssssssssssssssssss
                    btnlog = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza = 0;
                }
                    else if(tıklıhafıza2 == 1)
                {
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    s1 = s1 - hafıza2;
                    //double alan = Math.PI * Math.Pow(s1, s2);
                    label2.Text = (Math.Log10((double)s1).ToString());//ssssssssssssssssssssssssssssssssssssssssssssss
                    btnlog = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza2 = 0;

                }
                else
                {
                    s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    
                    //double alan = Math.PI * Math.Pow(s1, s2);
                    label2.Text = ( Math.Log10((double) s1).ToString());//ssssssssssssssssssssssssssssssssssssssssssssss
                    btnlog = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
            else if (btnus ==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s2 = int.Parse(textBox1.Text);
                    // sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    s1 = s1 + hafıza;
                    label2.Text = (Math.PI * Math.Pow(s1, s1)).ToString();
                    btnus = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();

                    tıklıhafıza = 0;
                }
                    else if (tıklıhafıza2 ==1)
                {
                    s2 = int.Parse(textBox1.Text);
                    // sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                    s1 = s1 - hafıza;
                    label2.Text = (Math.PI * Math.Pow(s1, s1)).ToString();
                    btnus = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();

                    tıklıhafıza2 = 0;

                }
                else
                {
                    s2 = int.Parse(textBox1.Text);
                   // sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.

                    label2.Text = (Math.PI * Math.Pow(s1, s2)).ToString();
                    btnus = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
            else if (btnkare==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    label2.Text = (s1 * s1).ToString();
                    btnkare = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();

                    tıklıhafıza = 0;
                }
                    else if (tıklıhafıza2==1)
                {
                    s1 = s1 - hafıza2;
                    label2.Text = (s1 * s1).ToString();
                    btnkare = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();

                    tıklıhafıza2 = 0;

                }
                else
                {
                   // s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.

                    label2.Text = (s1*s1).ToString();
                    btnkare = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
            else if (btnint ==1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    label2.Text = (Math.Log((double)s1).ToString());
                    btnint = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();

                    tıklıhafıza = 0;
                }
                    else if (tıklıhafıza2 ==1)
                {
                    s1 = s1 - hafıza2;
                    label2.Text = (Math.Log((double)s1).ToString());
                    btnint = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();

                    tıklıhafıza2 = 0;

                }
                else
                {
                    //s2 = int.Parse(textBox1.Text);
                    //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.

                    label2.Text = (Math.Log((double) s1).ToString());
                    btnint = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
            else if (btnin == 1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                else if (tıklıhafıza == 1)
                {
                    s1 = s1 + hafıza;
                    label2.Text = (Math.Log((double)s1).ToString());
                    btnint = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza = 0;
                }
                    else if (tıklıhafıza2 ==1)
                {
                    s1 = s1 - hafıza2;
                    label2.Text = (Math.Log((double)s1).ToString());
                    btnint = 0;
                    s1 = 0;
                    s2 = 0;
                    hafıza2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                    tıklıhafıza2 = 0;

                }
                else
                {
                    //kurcalama çalışıyor.
                    label2.Text = (Math.Log((double)s1).ToString());
                    btnint = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
            }
             else if (butonInv == 1)
             {
                  if (textBox1.Text == "")
                {
                    MessageBox.Show("Boş Değer Girilemez !!");
                }
                  else if (tıklıhafıza == 1)
                  {
                      s1 = s1 + hafıza;



                      btnint = 0;
                      s1 = 0;
                      hafıza = 0;
                      s2 = 0;
                      sontpl = 0;
                      textBox1.Focus();
                      textBox1.ResetText();
                      tıklıhafıza = 0;
                  }
                      else if (tıklıhafıza2 ==1)
                  {
                      s1 = s1 - hafıza2;
                      btnint = 0;
                      s1 = 0;
                      hafıza2 = 0;
                      s2 = 0;
                      sontpl = 0;
                      textBox1.Focus();
                      textBox1.ResetText();
                      tıklıhafıza2 = 0;

                  }
                else
                {
                    
                   // label2.Text = (Math.((double)s1).ToString());
                    btnint = 0;
                    s1 = 0;
                    s2 = 0;
                    sontpl = 0;
                    textBox1.Focus();
                    textBox1.ResetText();
                }
             }
            else if(btnfak ==1)
             {

                 if (textBox1.Text == "")
                 {
                     MessageBox.Show("Boş Değer Girilemez !!");
                 }
                 else if (tıklıhafıza == 1)
                 {
                     s1 = s1 + hafıza;
                     int i, fakt = 1;
                     for (i = 1; i <= s1; i++)
                     {
                         fakt = fakt * i;
                     }
                     label2.Text = (fakt).ToString();
                     btnin = 0;
                     s1 = 0;
                     s2 = 0;
                     hafıza = 0;//dwds654ad56as456d465as4d564as65d456sa4564d56sa465d4sa654d65as465d4a65
                     sontpl = 0;
                     textBox1.Focus();
                     textBox1.ResetText();
                     tıklıhafıza = 0;
                 }
                     else if (tıklıhafıza2 ==1)
                 {
                     s1 = s1 - hafıza2;
                     int i, fakt = 1;
                     for (i = 1; i <= s1; i++)
                     {
                         fakt = fakt * i;
                     }
                     label2.Text = (fakt).ToString();
                     btnin = 0;
                     s1 = 0;
                     s2 = 0;
                     hafıza2 = 0;
                     sontpl = 0;
                     textBox1.Focus();
                     textBox1.ResetText();
                     tıklıhafıza2 = 0;

                 }
                 else
                 {
                     //s2 = int.Parse(textBox1.Text);
                     //sontpl = s1 + s2;//+ yerine işlem işaretleri veya komutlar yazılacak diger ayarları tamamlandı.
                     int i, fakt = 1;
                     for (i = 1; i <= s1; i++)
                     {
                         fakt = fakt * i;
                     }
                     label2.Text = (fakt).ToString();
                     btnin = 0;
                     s1 = 0;
                     s2 = 0;
                     sontpl = 0;
                     textBox1.Focus();
                     textBox1.ResetText();
                 }
             }
                   
            
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("lütfen öncelikle deger giriniz !!!");
            }
            else
            {
                s1 = int.Parse(textBox1.Text);
                label2.Text = (Math.Log((double)s1).ToString());
                btnint = 0;
                s1 = 0;
                s2 = 0;
                sontpl = 0;
                textBox1.Focus();
                textBox1.ResetText();
                btnint = 1;
                textBox1.Focus();
                textBox1.ResetText();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                
                s1 = int.Parse(textBox1.Text);
                btnin = 1;
                textBox1.Focus();
                textBox1.ResetText();
            }
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                s1 = int.Parse(textBox1.Text);
                butonInv = 1;//**********************************
                textBox1.Focus();
                textBox1.ResetText();
            }
            textBox1.ResetText();
        }
       
        private void button12_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/berkay.sen.121");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            
                e.Handled = false;//eğer rakamsa  yazdır.
            
 
            else if ((int)e.KeyChar == 8)
            
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            
            else
            
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez !!");
            }
            else
            {
                s1 = double.Parse(textBox1.Text);
                btnPi = 1;
                textBox1.Focus();
                textBox1.ResetText();
            }
        }

        private void btnMArti_Click(object sender, EventArgs e)
        {
             hafıza = int.Parse(label2.Text);
             tıklıhafıza = 1;
        }

        private void btnMEksi_Click(object sender, EventArgs e)
        {
            hafıza2 = int.Parse(label2.Text);
            tıklıhafıza2 = 1;
        }

        
    }
}
