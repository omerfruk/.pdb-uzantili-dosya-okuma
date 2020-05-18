using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Globalization;

namespace Atom
{   

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();  // openfiledialog ekranını açıyoruz.
            file.InitialDirectory = "C:";
            string DosyaYolu = file.FileName;
            
            FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            string tempYazi = "";
            double sayi = 1.0, tempSayi = 0.0;
            String dizi = sw.ReadLine();
            int atomSayac = 0; // atomlari saymak icin olusturulan degisken 
            while (yazi != null) // burada list box a atomlarimizi yazdiriken ayni zamanda atomlarimizi sayiyoruz
            {
                ArrayList temp = explode(yazi);

                if (temp[0].ToString() == "ATOM")
                {
                    sayi = Convert.ToDouble(temp[6].ToString(), CultureInfo.InvariantCulture);
                    if (sayi > tempSayi)
                        tempSayi = sayi;
                    listBox1.Items.Add(yazi);
                    atomSayac++;
                }
                yazi = sw.ReadLine();
                textBox3.Text = (""+tempSayi); 

            }

            
            textBox2.Text = ("protegin toplam "+atomSayac+" atomdan oluşmaktadır");
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();


           
        }
        public ArrayList explode(string row)
        {
            ArrayList myRow = new ArrayList();
            string[] temp;
            int i = 0;
            do
            {
                row = row.TrimEnd();
                row = row.TrimStart();
                temp = row.Split(' ');
                myRow.Add(temp[0]);
                row = "";
                for (int j = 1; j < temp.Length; j++)
                {
                    row += temp[j] + " ";
                }
            } while (temp.Length > 1);

            return myRow;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

    
        }
        /* for(int i=0; i <= temp.Length; i++)
                {
                    double gelenSayi = Convert.ToDouble(temp[6]);
                    atomSayac++;
                    if (gelenSayi >= enBuyuk)
                    {
                        enBuyuk = gelenSayi;
                        enBuyukAtomNo = temp[1]

                    }
                    else
                        break; 
                }*/



        /* foreach (var item in temp[0])
         {
             int degisken = 0;
             for (int i = 0; i<temp.Length;i++ )
             {
                 if (degisken < temp[i])
                 {

                 }
             }

         }*/
         
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }
	

