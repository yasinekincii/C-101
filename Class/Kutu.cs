using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Kutu
    {
        //Field(Alan)= Sınıf içerisinde tanımlanan değişkenlere denir.(Field'lar dışarıya kapalı olmalıdır.)
        private double uzunluk;
        double genislik;
        double yukseklik;
        //SINIF İÇERİSİNDEKİ NESNELER VARSAYILAN OLARAK DIŞARIYA KAPALIDIR.
        //BİZİM BUNLARA DIŞARIYA ERİŞİME İZİN VERMEMİZ GEREKİR

        //izin verme olayını da biz erişim belirleyiciler ile yapıyoruz

        //bir sınıf içerisindeki nesnesin başında erişim belirleyicisi yoksa(bir şey tanımlanmadıysa)bu private dır.
        //field lar dışarıya private dır.


        //constructor(Yapıcı metot)(Diğer metotlardan tek farkı:Geri dönüş tipi yoktur)(sınıfın adıyla aynı isimde olması gerekir)
        public Kutu()
        {
            Console.WriteLine("Nesne Kuruldu.");

            //constructordan önce bir işlem olmaz
            // constructor sizin new ile üretilen nesneniz hafızada oluşturulurken xaten k'yı üreterek bize veren yapıdır.
        }


        //Constructor overload kullanılır.
        public Kutu(double uzunluk, double genislik, double yukseklik)
        {
            //eşitliğin sağı dışarıdan gelen değerler
            //parametre ve fieldın adları aynı olursa bu constructorda öncelik her zaman parametrededir.Dışarıdan geliyor çünkü
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yukseklik = yukseklik;

            //This HER ZAMAN BU SINIFI TEMSİL EDER
            //this parametreyi temsil etmez                   

        }

        //destructor(Yıkıcı metot)
        ~Kutu()
        {
            //constructor nesne örneği hafızada oluşturulurken kullanılır.
            //destructor(Yıkıcı metot)= aşağıdaki işlemleri yöneten kısıma da destructor diyoruz

            //uygulamayı(console uygulaması) kapattığım anda nesne ölüyor.

            //klavyeden altgr+ü=tilda işaretini çıkartın ~ sonrasında ise sınıfın adını yazın 
            Console.WriteLine("Sınıf Yıkılıyor.");
            Console.ReadLine();//sınıf yıkılmaya başladığında readline da bunu durduramaz sadece biraz bekletebilir
        }

        //Kapsülleme(Encapsulation)

        //programcılık best practice kurallarında fieldları dışarıya açmamamı söyleniyor.Bunlar dışarıya kapalı olmalıdır.Çünkü gelen veriyi kontrol edemezsin
        //o zaman bunları kapsülleme yöntemiyle kontrol ediceğiz

        //yani bir kapsül düşünün bu kapsül içerisinde koruduğunuz bir field var o fielda giriş çıkışları siz kontrol ederek izin veriyorsunuz ya da vermiyorsunuz
        //bunun da 2 yönetmi var = #region(GETTER && SETTER METHODS(alma ve set etme işlemleri))

        //public yapıyoruz çünkü encapsulation içerideki fieldı dışarıya açmak için kullanılan bir yöntemdir.Ve bu nedenle Publictir.
        public double GetUzunluk()
        {
            return uzunluk;//mesela uzunluk *3 diyerek 3 ile çarpımını dönderebiliriz
        }


        //set=Değer atama işlemi nasıl yapılacak
        //değer atamada geriye bir değer dönmiyeceğiz o yüzden void
        public void SetUzunluk(double uzunluk)
        {
            if (uzunluk >= 2)
            {
                this.uzunluk = uzunluk;
            }
            else
            {
                this.uzunluk = 2;
            }
        }
        //kapsülleme bunu sağlıyor dışarıdan gelen veriyi istediğimiz gibi yönetiriz
        //içeriden dışarıya istediğiniz gibi gönderirsiniz



        //Microsoft iki metot yazma unut o metotu diyor.
        //ben sana property diye bir nesne oluştururum kapsüllemeyi bununla yap

        public double Genislik//get ya da set diye bir şey yok çünkü tek bir property hem set hem de get yapabilir
        {
            get { return genislik; }//bu satır get işlemini yönetir 
            set
            {
                if (value >= 2)
                {
                    this.genislik = value;
                }
                else
                {
                    this.genislik = 2;
                }
            }//bu satır set işlemini yönetir

            //value nedir? setter metotlarda dışarıdan gelen veri parametre olarak geliyor.(property'de böyle parametre alanı olmadığı için onun yerine set işleminde bize value diye bir keyword veriyor)
            //propertyde parametre alanı olmadığı için onun yerine set işleminde size value diye bir keyword veriyor diyor ki propertynin tipi neyse (burada double)sana set olarak gelecek olan herhangi bir veriyi valur nesnesi,keywordu üzerinden alabilirsin diyor

        }

        //prop(prop yazıp 2 kere taba basıyorum)
        public double Yukseklik { get; set; }
        //bunun diğerinden farkı bu yöntemde kontrol yapamazsınız.Fieldın dışarıya açık versiyonudur.

        //dışarıdan gelicek bir değeri kontrol etmemiz gerekiyorsa yani kapsülleme yapıcaksak bu bizim işimizi görmez



        //ctrl r+e ile otomatik oluşturuyor

    }


}

