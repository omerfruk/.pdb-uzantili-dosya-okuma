/*
 *
 * Omer Faruk Tasdeir 201713171068
 * 2.sinif 1. ogretim 
 * Gorsel programlama 
 *  projelerimin ilerleyişini github tan izleyebilrisiniz
 *  https://github.com/omerfruk/.pdb-uzantili-dosya-okuma.git
 * 
 */

using System;
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
                ArrayList temp = explode_Mr_Tasdermir(yazi); // indirgediğimiz db leri arrayliste atadık
                // protegin ismini bir yerden bulamadigimiz icin dosyalardaki header kısmındaki 2.indexli veriler olarak varsaydık
                if (temp[0].ToString() == "ATOM")
                {
                    sayi = Convert.ToDouble(temp[6].ToString(), CultureInfo.InvariantCulture);
                    if (sayi > tempSayi)
                    {
                        tempSayi = sayi;
                        textBox3.Text = ("X koordinati en buyuk olan atomu:\t\t  " + tempSayi + "\t \t  Atomun numarasi:   " + temp[1] + "\t   Atomun ismi:   " + temp[2]); //atomlar arasındaki en büyügünü buluyor 
                    }
                    listBox1.Items.Add(yazi);
                    atomSayac++;
                   
                }
                if (temp[0].ToString() == "HEADER")
                    textBox1.Text = temp[1].ToString();
                yazi = sw.ReadLine();
               

            }

            
            textBox2.Text = ("protegin toplam "+atomSayac+" atomdan oluşmaktadır");
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();


           
        }
        public ArrayList explode_Mr_Tasdermir(string row) // boslukları giderme metodu Mr_Tasdemir imzasiyla
        {
            ArrayList myRow = new ArrayList(); //arraylist olusturma 
            string[] temp;
            int i = 0;
            do
            { // do while yapmam ve ilk basta sondan almamın bosluk almamin sebebi baslangic bosluklu olacagından  
                row = row.TrimEnd();//bitis boslugunu aldiralim atayalim    
                row = row.TrimStart();//baslangıc boslugunu aldiralim atayalim    
                temp = row.Split(' ');
                myRow.Add(temp[0]);//Arrayliste ekeleyelim
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
    }
    }
	

