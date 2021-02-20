using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary;

namespace BookApp.Models
{
    public static class BookRepository

    {
        private static List<Kitap> kitaplar = null;
        static BookRepository()
        {
            kitaplar = new List<Kitap>()
            {
                new Kitap() { BookId = 1, BookName = "Satranç", BookType="Uzun Hikaye" ,AuthorName = "Stefan Zweig", Image = "1.jpg" , Description="Herkese merhaba! Bu gün sizlerle okumayı başladığım gün bitirdiğim nadide eserlerden biri olan Stefan Zweig'in Satranç adlı uzun öyküsünü paylaşacağım. Kitabın konusuna şöyle kısaca değinecek olursak; Bir yolcu gemisinde geçen uzun hikayemizde soğuk ve satranç dışında kafası pek bir şeye çalışmayan adamımız Mirko Czentovic ile aynı gemideki milyoner ücret karşılığında bir parti satranç oynamak isterler. Oyunun rövanşı esnasında oyuna karışan Dr. B. adında bir kişinin sayesinde de ilk elde yenildikleri oyunun rövanşında berabere kalmayı zorla da olsa başarırlar.Ancak bu Dr. B. oldukça belirsiz bir kişiliktir ve milyoner, dünya şampiyonuyla hayatında somut olarak hiç karşılıklı satranç oynamamış olan Dr. B.'den bir karşılaşma ister. Akabinde romanın anlatıcısının da içerisine girdiği mücadele gerçekten izlenmeye değer bir hal alır... "+ "\n" + "Konusuna hayran kaldığımı en başta söylemesem olmaz. Günümüzde bir çok farklı amacı tek bir ağızdan haykırma derdiyle dört yüz beş yüz sayfalar yazan yazarlara inat 77 sayfada ne de çok şey anlatmayı başarmış yazar diye hayret ettim açıkçası. Tebrikler..."},
                new Kitap() { BookId = 2, BookName = "Otomatik Portakal", BookType="Roman" ,AuthorName = "Anthony Burgess", Image = "2.jpg" , Description="25 Şubat 1917 doğumlu İngiliz yazar Anthony Burgess’ın en popüler romanı olan Otomatik Portakal, ilginç bir yazım sürecine sahip. 1959 yılında tümör nedeniyle 1 yıldan az ömrü kaldığını öğrenen Anthony Burgess, ölümünün ardından karısının geçimini sağlaması için kitaplar yazmaya başlar.Daha sonra ise yanlış tanı koyulduğu öğrenilir ancak Burgess artık dünyaca tanınan bir yazar olmuştur. Bu süreçte yazdığı kitapların başında gelen Otomatik Portakal’da yarattığı Alex karakteri de yazarın hastalığı öğrendiği zamandaki psikolojisini yansıtmaktadır. Roman yazarı, şair, besteci, eleştirmen, dil bilimci ve çevirmen gibi sıfatları bulunan Burgess’ın en büyük özelliklerinden birisi de eserlerindeki ortaya koyduğu nefret duygusudur.tomatik Portakal, Alex ve çetesi olarak adlandırabileceğimiz 4 karakteri konu alan bir hikayedir. Hikayenin merkezi konumunda olan Alex’e Dim, Georgie ve Pete eşlik etmektedir. Eser, Alex adlı gencin ağzından anlatılmaktadır. Bu nedenle Alex’in gençlerle, şiddetle, toplumsal yapıyla ilgili yaptığı yorumlar kitap için büyük önem taşımaktadır. Eser, 15 yaşındaki Alex’in çalkantılı gelişimini konu almaktadır. Günümüz toplum yapısını şiddet yanlı bir karakterle, sert bir dille eleştiren eser, ilgisiz aile yapısını ustalıkla incelemeyi başarıyor." },
                new Kitap() { BookId = 3, BookName = "Dönüşüm", BookType="Uzun Hikaye", AuthorName = "Franz Kafka", Image = "3.jpg" , Description="Franz Kafka’nın 1915’te yayınlanan Dönüşüm adlı öyküsü, yazarın, anlatım sanatının doruğuna ulaştığı eserdir. Küçük burjuva çevrelerindeki yozlaşmış aile ilişkilerini en ince ayrıntılarına kadar irdeleyen bu uzun öykü, aynı zamanda toplumun dayattığı, işlevini çoktan yitirmiş kalıplara bilinç düzeyinde baş kaldıran bireyin tragedyasını çarpıcı biçimde dile getirir. Diğer bir ifadeyle sistem içinde köleleşen, sürekli olarak bazı sorumlulukları yerine getirmesi istenen bu sorumluluklar yerine getirilmediğinde toplum tarafından dışarı atılan insanı resmettiği muhteşem öyküsüdür Dönüşüm. Dönüşüm kitabı ne anlatıyor diye kısaca soracak olursanız: Bir sabah kalkıyorsunuz ve bir böceğe dönüşmüş bir şekilde yatakta yatarken buluyorsunuz kendinizi. Yataktan kalkmaya çalışıyorsunuz fakat bunu yapmak, önceki sabah kadar kolay olmuyor. Her sabah işe gitmek için bindiği trenin saatinin çoktan geçtiğini fark eder. Başta çalar saatinin çalmadığını düşünür, fakat çalar saati her sabahki gibi çalmıştır. Ama o saati duymamıştır. Samsa yataktan kalkmak ister fakat artık sahip olduğu birbirinden bağımsız hareket eden çokça bacaklar buna izin vermemektedir." },
                new Kitap() { BookId = 4, BookName = "Cesur Yeni Dünya", BookType="Bilim Kurgu", AuthorName = "Aldous Huxley", Image = "4.jpg" , Description="Mutsuzluk yok, açlık yok, herkes oldukça sağlıklı ve dünyadaki tüm savaşlar sona ererek yerini barışa bırakmış. Bizden hayalimizdeki geleceğin nasıl olduğunu anlatmamız isterse çoğumuzun aşağı yukarı vereceği cevap budur sanırım. İyi niyet kokan bu yaklaşım daha ikinci dünya savaşının hemen öncesinde Aldous Huxley tarafından 1932 yılında ortaya atılarak ünlü roman Cesur Yeni Dünya’nın konusu olmuştur. Kitaba ana hatlarıyla bakıldığında Huxley’in ideal bir dünya düzeninden bahsettiği sanılsa da sayfalarda biraz ilerledikçe aslında yazdıklarıyla gelecek insanlarını uyarmayı hedeflediğini görüyoruz. Kitap boyunca bu mutluluğun bedelleri çarpıcı bir şekilde gözler önüne seriliyor."},
                new Kitap() { BookId = 5, BookName = "Doğu Ekspresinde Cinayet", BookType="Polisiye", AuthorName = "Agatha Christie", Image = "5.jpg" , Description="Agatha Christie’nin 1933 yılında İstanbul Beyoğlu Pera Palas’ta, orijinal ismi Murder on the Orient Express olan ve Orient Express’te işlenen gerçek bir cinayetten esinlenerek yazmış olduğu kitaptır. On Küçük Zenci adlı kitabından sonra en çok okunan kitabıdır. Olaylar, trendeki yolculardan birinin öldürülmesiyle başlar. Trenden sorumlu kişi varış noktasına gelmeden olayın çözülmesini ister. Neyse ki en yakın ve en iyi arkadaşı meşhur dedektifimiz Hercule Poirot da trendedir. Poirot çok istemese de arkadaşının katili bulma teklifini beyin antrenmanı olsun diye kabul eder ve katili bulmaya çalışır. Poirot, yolcuları tek tek vagon restorana alır ve sorgular. Bunu yaparken ince zekasını kullanır. Tüm mimiklerden çıkarım ve varsayımlar yapar. Yeri geldiğinde bilimden ve psikolojiden yararlanır. Kitapta karakter analizleri müthiş bir şekilde yapılmış, olay örgüsü o kadar olağanüstü işlenmiş ki bu da katili bulmamızı iyice zorlaştırıyor. Katili “Tamam şimdi buldum.” diyorsunuz ama ne fayda. Kitap ortalarından sonra daha da ateşleniyor ve merak dozu durmadan yükseliyor. Kitap, kısım ve bölümlere ayrıldığı için okunması da kolay. Son anlarını bir solukta okudum diyebilirim. Bittiğinde ise arkama yaslanıp “Bu kadın bunu nasıl yazdı?” diye dakikalarca düşündüm. Hayatım boyunca okuduğum kitaplar arasında şimdiden ilk ikiye girdi." },
                new Kitap() { BookId = 6, BookName = "İyi Hissetmek", BookType="Psikoloji", AuthorName = "David Burns", Image = "6.jpg" , Description="Dr. David Burns’un “İyi Hissetmek” adlı kitabında temel olarak değinilen durum,  otomatik bir biçimde bilincimize yerleşen düşüncelerimizi nasıl fark edebiliriz, nasıl değiştirebiliriz, otomatik düşüncelerimize karşı nasıl bu savaşı kazanabiliriz olmuştur. David Burns   kitabında, terapilerinde gerçekleştirdiği seanslarından bizlere kesitler sunmaktadır. Seanslarındaki hastalar otomatik düşüncelerine mahkum olan, depresyona girmiş veya depresyon eşiğindekilerdir. “İyi Hissetmek” kitabı, “Otomatik düşünce sistemini nasıl fark edebiliriz?”, “Kökeninde ne vardır ?” ,”Nasıl daha sağlıklı düşünebiliriz?” gibi konuları adeta bir öğretmen gibi öğretmiştir. Peki Dr. David Burns’un kitaptaki sistemleri ve teknikleri nelerdir? Öncelikle kendisine gelen hastalarına ve kitabı okuyan herkese şu mesajı vermektedir: İçinizde bulunduğunuz duruma insanoğlunun oluşturduğu kalıplar ve onlara ayak uydurmanız sebebiyle girdiniz. Şimdi bu durumdan da yine sizler çıkmalısınız. Dr. Burns, kitabının ve bilişsel terapinin  gücünden şöyle söz etmektedir: “Psikiyatrların genel olarak kullandıkları antidepresanlar, depresyon üzerinde bilişsel davranışçı yöntem kadar kesin ve etkili değildir.”  "},
                new Kitap() { BookId = 7, BookName = "Böyle Buyurdu Zerdüşt", BookType="Felsefe", AuthorName = "Friedrich Nietzsche", Image = "7.jpg" , Description="Kitabı belirli bir kategori içerisinde tanımlamak genelde zor olmuştur: Bir edebiyat eseri ve aynı zamanda felsefî bir çalışmadır. Nietzsche kendisi kitabı “yazılmış en derin” eser olarak tanımlamıştır. Eser, birçok farklı konu ve tarz barındırmaktadır. Nietzsche’nin felsefî görüşleri açısından önemli bir yer tutan kitap, birçok eleştiriye maruz kalmıştır.Ana karakter Zerdüşt her şeyden vazgeçerek dağlara çıkar orada ruhunun yalnızlığını çıkardı on sene boyunca güneşi ilham alarak dağdan inmeye karar verir. Hedefi insanlığın derinliğine inerek doğrulara ışık tutmak  insanlığın aşılması gereken bir varlık olduğunu üstün insana ulaşılması gerektiğini vurgular. "},
            };
            
        }

        public static List<Kitap> kitapListesi
        {
            get { return kitaplar; }
        }





        public static void AddBook(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }

        public static Kitap GetById(int id)
        {
            return kitaplar.FirstOrDefault(i => i.BookId == id);
        }



        
    }
}
