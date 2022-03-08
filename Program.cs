using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation yani Kapsülleme kavramı bir özeliği başka sınıflardan saklamak yada korumaktır.
             
             //ogrenci sınıfından bir instance yaratalım 
             Ogrenci ogrenci = new Ogrenci();
             ogrenci.Isim ="Ayse ";
             ogrenci.Soyisim="Yılmaz";
             ogrenci.OgrenciNo=245678;
             ogrenci.Sinif=3;
             ogrenci.OgrenciBilgileriGetir();

             ogrenci.SinifAtlat();
             ogrenci.OgrenciBilgileriGetir();
             Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
             ogrenci1.SinifDusur();
             ogrenci1.SinifDusur();
             ogrenci1.OgrenciBilgileriGetir();

        }
    }
    class Ogrenci
    {
        
        private string isim;
        private string soyisim;
        private int ogrenciNo;

        private int sinif;

        public string Isim { get => isim; set => isim = value; }// get i return et isime deger ata diyor.
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { get => sinif;
         set 
         {
             if(value <=1){
                 Console.WriteLine(" Sinif en az bir olabilir!");
                 sinif=1;
             }else{
                 sinif= value;

             }
            sinif = value; 
         } 
         }
        public Ogrenci(){
            // bos olan kurucu
        }
        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            // parametre alan kurucu
            this.isim=isim;
            this.soyisim = soyisim;
            this.ogrenciNo = ogrenciNo;
            this.sinif = sinif;

        }
        public void OgrenciBilgileriGetir(){
            // ögrenci bilgislerini geri donduren bir metot yazmak istiyorum.
            Console.WriteLine("*****ögrenci bilgileri");

            Console.WriteLine("Ögrenci Adi :{0}",this.Isim);
            Console.WriteLine("Ögrenci Adi :{0}",this.soyisim);
            Console.WriteLine("Ögrenci Adi :{0}",this.ogrenciNo);
            Console.WriteLine("Ögrenci Adi :{0}",this.sinif);


        }
        public void SinifAtlat(){
            this.Sinif=this.Sinif +1;
        }
        public void SinifDusur(){
            this.Sinif=this.Sinif -1;
        }
    }
}
