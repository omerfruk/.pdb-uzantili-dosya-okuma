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
            double sayi = 1,tempSayi=0;
            String dizi = sw.ReadLine();
            while (yazi != null)
            {
                string[] temp = yazi.Split(' ');
  
                if (temp[0] == "ATOM")
                   listBox1.Items.Add(yazi);
                    
                yazi = sw.ReadLine();
              

            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
           
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

    
        }
    }
    }
	

