# .pdb-uzantili-dosya-okuma

#### 2. sınıf 2. dönem görsel programlama ödevidir 

Projemizde girilen .pdb uzantılı proteinimizi almak için bir Folder Browser drobumuz bulunmaktadır.
Dosyamızı ordan kolayca seçtikten sonra herhangi bir şey yapmanıza gerek kalmadan hemen programımız çalışmaya başlıyor ve herhangi bir proteinimizi hafızaya alıyor sonra bir ArrayListe’e sanki bir exel tablosuna benzetmeye çalışıyoruz burada ise 2 işlem yapıyoruz bunlardan biri satırların arasındaki sütünları parçalamak, parçaladıktan sonra aralarındaki boşlukları siliyoruz ki  kelimeler Arraylist’te indexlerle rahatça hareket edelim yapılan işlemden sonra aslında elde etmek istediğimiz tüm veriler elimize geçiyor orda 

##### Neler yapıyoruz 

**ListBox1** = proteinin içindeki tüm atomları bir listBox a yazarak sizlere başka hangi atomların olduğunu yazdırıyoruz ve atomların sadece isimleri değil tüm verileriyle sunuma seriyoruz 

**TextBox1** = Girilen proteinin ismini döndürüyor bizlere fakat ben bu klasörde proteinin ismin nerde olduğunu anlayabilmek için biraz araştırma yaptım ve ilk satırda HEADER kısmındaki satırın 2. İndexi olduğunu anladım ve onu sizlere geri çevirdim temp[0] == “HEADER” burada yazmaya çalıştığımız code parçası bizlere “temp” isimli değişkenin  “0”ınci indexteki veri “HEADER” sitring değerine eşitmi diye bir if yapısına sokularak bulunabilir oradan da if’imizin içine TextBox1.Text=temp[1]; yazarsak bizlere ismi döndürür  

**TextBox2** = burada sizlere seçilen proteinin kaç adet atomdan oluştuğunu ufak bir for yapısıyla sizlere sunuyoruz yapmış olduğumuz işlemler orada anlatılmıştır toplam++; şeklinde bulunabilir bir for göngüsü ile her bir dönüşte toplamı bir arttır diyerek atomları sayabiliriz

**TextBox3** = yukarıda dediğim gibi bir for döngüsü içine bir değiken atarız X koordinatı en büyük olan atomunu buluruz sonrasında o satırın 1. Ve 2. İndexinin çekip yazdırıyoruz

Programın çalışışı fotoğraflarla desteklenmiştir.




