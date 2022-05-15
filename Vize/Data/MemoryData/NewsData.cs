using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vize.Models;

namespace Vize.Data.MemoryData
{
    public class NewsData
    {
        public List<News> _news = new List<News>();
        public NewsData()
        {

            _news.Add(new News()
            {
                NewsId = 1,
                NewsTitle = "Sainz'ın aracında yaşanan arıza, kısa sürede çözüldü",
                NewsArticle = @"Sainz, dün gerçekleştirilen sıralama turlarını 3. sırada tamamlamıştı. Sainz, sıralama turlarının ardından verdiği demeçlerde bugünkü yarış için heyecanlı olduğunu belirtmişti.

                Ancak yarış günü, Sainz için iyi başlamadı. Yarıştan önce, her zaman olduğu gibi pit yolu açıldı ve pilotlar piste çıktılar. Sainz'ın aracında bir sorun bulundu ve mekanikerler, araç üzerinde çalışmaya başladılar. Ferrari takım patronu Mattia Binotto, endişeli duruyordu ancak basına aracın yarışa yetişeceğini belirtti. 

                Binotto'nun söylediği gibi de oldu ve araçtaki sorun çözüldü. Sainz, araç üzerindeki çalışmaların bitmesinin ardından piste çıktı ve araç iyi göründü. İspanyol pilot, 20.00'de başlayacak Suudi Arabistan GP'ye üçüncü sıradan başlayabilecek gibi duruyor. 

                Sky Germany, Sainz'ın aracındaki sorunun yakıt pompasıyla alakalı olduğunu öne sürdü. Sorunun kaynağı hakkında henüz takımdan bir açıklama gelmedi. Red Bull pilotlarının Bahreyn'de yolda kalmasına neden olan sorun da yakıt pompasıyla alakalıydı.

                Mekanikerler, Sainz'ın aracını 3. cebe götürdüler ve araç yarışa başlamaya hazır görünüyor. ",
                Image = new Image() { ImageId = 1, Height = 20, Width = 40, ImgPath = "Images/carlos-sainz-jr-ferrari-1.jpg" },
                Serie = new Serie()
                { SeriesId = 1, Name = "Car Series", Race = new Race() { RaceId = 1, Name = "Formula 1" } }
            }
            );
            _news.Add(new News()
            {
                NewsId = 2,
                NewsTitle = "Herta: \"Eğer fırsat olursa büyük olasılıkla F1'de yarışırım\"",
                NewsArticle =
                    "Herta, Andretti'nin planı işe yarasaydı FIA süper lisansı aldığında F1'e geçecekti ve onun IndyCar ekibindeki yerini Indy Lights şampiyonu Kyle Kirkwood alacaktı.\r\n\r\nBunun yerine, Herta geçen sezon üç galibiyet elde ettiği 26 numaralı AA-Honda'da kalacak.\r\n\r\n21 yaşındaki Herta bu hamle hakkında, \"Formula 1'de yarışmak istemiyorum deseydim yalan söylemiş olurdum, kariyerimde yapmak istediğim birçok şey var.\"\r\n\r\n\"Ancak bunların belirli bir zamana ihtiyacı var. Formula 1 de bunlardan biri. Eğer 28 yaşındaysan, maalesef Formula 1'e gidemezsin. Bu böyle işliyor. Eğer fırsatım olursa şu an benim için doğru bir zaman. Üzerinde iyice düşünmem gerekir ama büyük olasılıkla bunu yapardım çünkü bir noktada Formula 1'de yarışmak istiyorum.\" dedi.\r\n\r\nHerta, \"21 yaşındayım ve beş yıl sonra geri gelip 15 yıl daha IndyCar'da yarışabilirim. \"Fırsatım olursa kesinlikle bir şans vermek isterim. Ancak IndyCar'da kesinlikle hayal kırıklığına uğramış değilim. Bu seriyi dünyadaki her seriden daha fazla seviyorum ve yarışmaktan çok keyif alıyorum. Sadece, yarış kariyerimde IndyCar dışında denemek istediğim çok şey var.\" diye ekledi.\r\n\r\nHerta, kariyerinde değişiklik yapmaya olan isteğini IMSA WeatherTech SportsCar Şampiyonası sırasında zaten göstermişti. 2019 ve 2020 sezonlarında Rahal Letterman Lanigan BMW için yarıştı ve ilk çıkışında Daytona'da Rolex 24 Saat'i kazanırken, geçen yıl Turner Motorsport'un BMW M6'sındaydı.\r\n\r\nHerta bu hafta sonu dördüncü Rolex 24 Saat yarışına çıkıyor ve DragonSpeed'de Eric Lux, yeni Andretti Autosport takım arkadaşı Devlin DeFrancesco ve eski Indy Lights takım arkadaşı Pato O'Ward ile LMP2 aracında olacak.\r\n\r\nHerta, önümüzdeki IndyCar sezonunda, şimdiye kadarki en iyi sonucunun 2020'de Gateway'de dördüncü olduğu oval pistlerde başarı kazanmak istediğini söyledi.\r\n\r\n2021'de aynı pistte galibiyet almak üzereydi ancak aracı onu hayal kırıklığına uğrattı.\r\n\r\n\"Geçtiğimiz yılki Gateway'i kaybedeceğimiz varmış.\"\r\n\r\n\"Maalesef aks kırılınca yarışı kazanamadık. Bunun dışında hızımız çok iyiydi. Herkesten daha iyi gidiyorduk ve onları geride bırakmıştık. Maalesef kaybedeceğimiz varmış. \"Bu, oval pistlerde kazandığım öz güveni gösterdi. Sanırım uzun bir süre Andretti'nin mücadele ettiği yer burasıydı.\"\r\n\r\nHerta, \"Farklı ovallerde farklı zamanlarda çok fazla hızımız oldu ama hiçbir zaman farkı kapatamamıştık. 2019'da Teksas'ta hızlıydım ama o zamandan beri takım olarak zorluklar yaşadık.\"\r\n\r\n\"Bunun üzerinde çalıştık ve şimdi Iowa'ya odaklanmış durumdayız. Yılın ilerleyen zamanlarında Iowa'da bir testimiz var, bu yüzden ilginç olacak.\" diye ekledi.\r\n\r\nHerta, ilk üç IndyCar sezonunu yedinci, üçüncü ve beşinci bitirdi ve toplam altı galibiyet elde etti. Bu sezon şampiyonluğu kazanmak için baskı hissedip hissetmediği konusunda, “21 yaşındayım, bu yüzden bolca zamanım olduğunu düşünüyorum.\"\r\n\r\n\"Ancak geç olmasındansa şimdi kazanmayı isterim. Bir baskı hissetmiyorum. Bu yıl almak zorunda olduğumu düşünmüyorum ama bu yıl almak istemeyeceğim anlamına da gelmiyor. Hedefim her zaman bu. dedi. ",
                Image = new Image()
                { ImageId = 2, Height = 20, Width = 40, ImgPath = "Images/colton-herta-andretti-autospor.jpg" },
                Serie = new Serie()
                { SeriesId = 1, Name = "Car Series", Race = new Race() { RaceId = 2, Name = "IndyCar" } }
            });
            _news.Add(new News()
            {
                NewsId = 3,
                NewsTitle = "MotoGP, Malezya ile kontrat yeniledi",
                NewsArticle =
                    "Dorna ve Sepang Uluslararası Pisti'nin organizatörleri, üç yıllık yeni bir anlaşma imzaladılar ve bu da 2024 sonuna kadar takvimde kalacakları anlamına geliyor.\r\n\r\nDorna'da Carmelo Ezpeleta, \"Nihayet Malezya Grand Prix'sinin 2024'ün sonuna kadar takvimde kalacağını açıklamaktan büyük memnuniyet duyuyoruz.\"\r\n\r\n\"Malezya, MotoGP için çok önemli bir pazar ve Sepang'a gelip, taraftarların tutkusunu hissetmek, bizim için büyük bir zevk.\" dedi.\r\n\r\nMalezya Grand Prix'si, korona krizi ve ülkedeki katı giriş kuralları nedeniyle son iki yıldır takvimde yer almıyor.\r\n\r\nMotoGP kış testi Şubat ayında tekrar Malezya'da yapıldı ve bu da Ekim ayında Malezya GP'nin yapılacağını doğrular nitelikteydi.\r\n\r\nEzpeleta, \"Malezya'da tekrar test yapabileceğimizi gördük ve orada tekrar yarışmayı sabırsızlıkla bekliyoruz. Malezya Grand Prix'si için sabırsızlanıyoruz.\" dedi.\r\n\r\nDorna, kontratın uzatılmasına ilişkin yaptığı açıklamada, 2025 ve 2026 için görüşmelerin başladığını da duyurdu.\r\n\r\nÖte yandan Malezyalı Petronas da yarışın isim sponsoru olacak. \r\n\r\nSuudi Arabistan'dan da MotoGP'ye ilgi var\r\n\r\nBu arada Suudi Arabistan da MotoGP'ye ilgi gösteriyor. Ülke, Qiddiyah'daki yeni piste MotoGP yarışını getirmenin olanaklarını araştırıyor.\r\n\r\nYeni pist, 2024'ün ortalarına doğru hazır hale getirilecek.\r\n\r\nSuudi Arabistan spor bakanı Abdulaziz bin Turki Al-Faisal, \"Bölgemiz, motor sporları için bir merkez haline geldi.\"\r\n\r\n\"Daha fazla şampiyonaya ev sahipliği yapmayı ve MotoGP'nin buraya gelmesini istiyoruz.\"\r\n\r\n\"Ancak bu, Cidde'de sahip olduğumuzdan farklı bir pist gerektirecek. Qiddiyah'daki yeni tesisler hazır olduğunda, kesinlikle MotoGP'yi düşüneceğiz.\" dedi.",
                Image = new Image() { ImageId = 3, Height = 20, Width = 40, ImgPath = "Images/alex-rins-team-suzuki-motogp-1.jpg" },
                Serie = new Serie()
                { SeriesId = 2, Name = "MotorBike Series", Race = new Race() { RaceId = 3, Name = "MotoGp" } }
            });
            _news.Add(new News()
            {
                NewsId = 4,
                NewsTitle = "Brown: \"O'Ward'ın Formula 1'e geçişinin en kolay yolu IndyCar'ı kazanmak\"",
                NewsArticle =
                    "O'Ward, Arrow McLaren SP ile IndyCar'da kazandığı ilk yarışın ardından ödül olarak Abu Dhabi'de McLaren'ın 2021 Formula 1 aracını test etmişti.\r\n\r\nMcLaren pilotu, IndyCar sezonunu üçüncü sırada tamamladı ve Teksas ile Detroit'teki zaferleriyle beraber, son yarışa kadar şampiyonluk mücadelesinde kaldı.\r\n\r\nAbu Dhabi testinin ardından konuşan O'Ward, F1'e geçiş için önünde iki yıllık bir aralık olduğunu ve \"bunu gerçekleştirmek için elinden gelen her şeyi yapacağını\" belirtti.\r\n\r\nMcLaren Racing CEO'su Zak Brown, uzun süredir O'Ward'ın IndyCar'daki işine odaklanmasının önemini vurguluyordu ve şampiyonluğu kazanmanın, gelecekte Formula 1'e geçebilmesinin en kolay yolu olacağını söyledi.\r\n\r\nBrown, \"Ona tam olarak 'F1'e giden en hızlı yol Juan Pablo Montoya, Alex Zanardi, Jacques Villeneuve ya da Michael Andretti'nin yaptığı gibi IndyCar'ı kazanmaktır' dedim.\"\r\n\r\n\r\n\r\n\"Formula 1'de yarışabilmek adına en iyi şansınız budur. İnanılmaz yetenekli bir sürücü ve harika bir karakteri var. Bence saf yetenek anlamında Formula 1 sürücüsü olmak için gerekenlere sahip.\"\r\n\r\n\"Açıkçası Formula 1 çok daha farklı bir seri, bu yüzden direksiyonun üzerindeki tüm tuşlar gibi öğrenecek çok şeyi var. Fakat bunları kesinlikle yapacak.\"\r\n\r\n\"Tamamen IndyCar'a odaklanması gerekiyor. F1'e giden en iyi rota bu olacak. Ortaya koyduğu iki yıllık zaman çizelgesinin doğru olduğunu düşünüyorum.” dedi.\r\n\r\nO'Ward'ın Formula 1'de yarışabilmesi için süper lisans alması da gerekiyor.",
                Image = new Image()
                { ImageId = 4, Height = 20, Width = 40, ImgPath = "Images/patricio-o-ward-mclaren-mcl35m.jpg" },
                Serie = new Serie()
                { SeriesId = 1, Name = "Car Series", Race = new Race() { RaceId = 2, Name = "IndyCar" } }
            });
            _news.Add(new News()
            {
                NewsId = 5,
                NewsTitle = "Binotto: \"Perez'in önde olmasına değil, Verstappen'in geride kalmasına şaşırdık\"",
                NewsArticle = "Cumartesi günü gerçekleştirilen sıralama turlarında Ferrari pilotları 2. ve 3. en iyi zamanı yaparken, pole pozisyonu Sergio Perez'e gitmişti\r\n\r\nCharles Leclerc antrenmanları zirvede tamamladığı için, genel olarak sıralama turlarında bir Verstappen-Leclerc savaşı olacağı düşünülüyordu.\r\n\r\nSeansın ardından konuşan Binotto, şöyle dedi: \"Sergio'nun harika bir tur çıkardığına hiç şüphe yok.\"\r\n\r\n\"Onun çok iyi bir tempoya sahip olduğunu ikinci seansta zaten gördük. Red Bull'un çok iyi bir aracı var, bu sebeple Sergio'nun aldığı sonucun bizim için sürpriz olduğunu söyleyemem. Aksine Max Verstappen'in daha hızlı olmasını beklemiştik.\"\r\n\r\n\"İki sürücümüzün de pole pozisyonu için mücadele etmesine sevindim. Bahreyn'den sonra yine ilk çizgiden başlıyoruz. Bu, hızlı bir aracımız olduğunu ve sürücülerin işlerini iyi yaptığını gösteriyor. Bu konuda gayet mutluyum.\"\r\n\r\n\"İlginç bir yarış bizi bekliyor. Cidde'de her şey olabilir. Kırmızı bayrak çıkabilir, güvenlik aracı piste girebilir. Her halükarda konsantrasyonu korumak ve her fırsattan en iyi şekilde faydalanmak gerekiyor.\"\r\n\r\n\"Bakalım hangi sonuçlar mümkün olacak? Sergio'nun yarışta çok güçlü olduğunu ve pole pozisyonundan başladığını unutmamak gerekiyor Pek çok şey olabilir.\"\r\n\r\nPilotların kişisel performansına da değinen Binotto, \"Bahreyn'de Carlos araçta tamamen rahat değildi ve tam potansiyelini ortaya koyamadığını biliyordu.\"\r\n\r\n\"Çok çalıştı, aradaki farkın nedenlerini anlamak adına telemetrilere baktı. Buraya geldiğinde direksiyon başında rahat hissetmek için her şeyi yaptı.\"\r\n\r\n\"Yapılan iş sonunda karşılığını verdi ve mücadeleye döndü. Bakalım yarıştaki temposu nasıl olacak? Birkaç yarış içerisinde daha da iyi bir tempoya çıkacağına eminim.\"\r\n\r\n\"Harika bir pilot kadromuz var. Birbirleri için çok faydalılar, bu da gelişmemize yardımcı oluyor.\" dedi.",
                Image = new Image()
                { ImageId = 5, Height = 20, Width = 40, ImgPath = "Images/carlos-sainz-jr-ferrari-charle.jpg" },
                Serie = new Serie()
                { SeriesId = 1, Name = "Car Series", Race = new Race() { RaceId = 1, Name = "Formula 1" } }
            }); 
            _news.Add(new News()
            {
                NewsId = 6,
                NewsTitle = "Russell: \"En fazla beşinci olabiliriz\"",
                NewsArticle = "Russell ve takım arkadaşı Lewis Hamilton, sıralama turlarında farklı ayarlara geçmişlerdi, fakat bunun büyük bir hata olduğu ortaya çıktı.\r\n\r\nHamilton aracının arkasını kontrol etmekte zorlanıyordu ve 16. olarak uzun bir süre sonra ilk defa Q1'de elendi. Russell ise daha iyi bir gün geçirdi ve günü altıncı sırada tamamladı.\r\n\r\nMercedes'in zaten Ferrari ve Red Bull'un gerisinde kalması bekleniyordu, fakat Russell aynı zamanda Alpine pilotu Esteban Ocon'un da gerisinde kaldı.\r\n\r\nMotorsport.com'a konuşan Russell, Q2'de ancak 10. olabilmesinin ardından sonucun onu rahatlatıp rahatlatmadığı sorulduğunda, \"hem onun hem de takımın beklentilerinin epey altında olduklarını\" söyledi.\r\n\r\nRussell, \"Sonuç beni rahatlatmadı çünkü 5. veya 6. sıra mücadelesi vermek için burada değiliz. Takım için oldukça zor bir gündü. Araç tam anlamıyla bıçak sırtındaydı, doğru aralıkları bulmakta zorlandık.\"\r\n\r\n\"Hem Lewis hem de ben sıralama turları için farklı ayarlara geçtik. Açıkça ortada olduğu üzere bu işe yaramadı. Bu verilerle de sabit.\"\r\n\r\n\"Takım olarak bu biraz utanç verici. Kişisel olarak, 5. sırayı elde etseydim bundan kesinlikle memnun kalırdım. Her şeyi bir araya getirseydim bu mümkün olabilirdi. Ama şu anda içinde bulunduğumuz durum bu.\"\r\n\r\n\"Koşullar aldatıcıydı, çünkü tüm odağımızı dalgalanmayı çözmeye vermiş durumdayız, dolayısıyla diğer alanlardaki sorunlarla ilgilenemiyoruz. Ben de pilot olarak sürüşe yeterince odaklanamıyorum. Doğru dengeyi yakalayamıyoruz, doğru ayarları bulamıyoruz, çünkü tüm odağımızı dalgalanmayı çözmeye verdik. Yapmamız gereken çok iş var.\"\r\n\r\nPazar günü damalı bayrağa ulaşmanın ne kadar önemli olduğu sorulduğunda Russell, \"Hasarı azaltmaya çalışacağız. Alabileceğimiz en iyi sonuç beşincilik.\"\r\n\r\n\"Ön grubun bir hayli uzağındayız. En iyi ihtimal beşinci olabiliriz. Hiç olmazsa bunu sağlayabileceğimizden emin olmalıyız.\"\r\n\r\nRussell en büyük sorunun ise dalgalanmayı aşmak için sürüş yüksekliğinin arttırılması olduğunu düşünüyor.\r\n\r\nİngiliz pilot, \"İlk günden beri durum aynı, dalgalanma sorunumuz var. Bunu aşmanın tek yolu sürüş yüksekliğini arttırmak, bu da yer etkisi döneminde olduğumuz için ciddi oranda yere basma gücü kaybına yol açıyor.\"\r\n\r\n\"Aracı yere yaklaştırmayı başarabilirsek büyük bir performans artışı yaşayacağız, fakat bunu şu anda gerçekleştiremeyiz. Potansiyelimiz olduğunu bilmek güzel, fakat fiziksel olarak şu anda bu imkansız. Yeniden düşünmemiz gerekecek.\" dedi",
                Image = new Image() { ImageId = 6, Height = 20, Width = 40, ImgPath = "Images/george-russell-mercedes-amg-is.jpg" },
                Serie = new Serie()
                { SeriesId = 1, Name = "Car Series", Race = new Race() { RaceId = 1, Name = "Formula 1" } }
            });
            _news.Add(new News()
            {
                NewsId = 7,
                NewsTitle = "Endonezya MotoGP yarışı şiddetli yağmur nedeniyle ertelendi",
                NewsArticle =
                    "MotoGP, 1997'den bu yana ilk kez Endonezya'ya dönüyor fakat yarışın başlamasına kısa bir süre kala pisti şiddetli yağmur vurdu ve bundan ötürü yarış ertelendi.\r\n\r\nYarış normalde TSi 10:00'da yapılacaktı ve ilk başta 10:10'a ertelendi.  Fakat yağmur dinecek gibi görünmüyor. Bu sebeple yarış en az 45 dakika ertelendi.\r\n\r\nYarış yönetimi şartlara bağlı olarak yarışı daha da erteleyebilir.\r\n\r\nBu sabah yarış yönetimi, sıcak pist şartları nedeniyle yarışın uzunluğunun 27 turdan 20 tura indirildiğini duyurmuştu. Çünkü 45 dereceyi aşan pist sıcaklığı, güvenlik endişelerine neden oluyordu.\r\n\r\nBöylelikle MotoGP'nin Endonezya'ya dönüşü başlangıçtan itibaren sorunlarla dolu geçmiş oldu.\r\n\r\nGeçen yılki Dünya Superbike Endonezya yarışı da yine yoğun yağmur nedeniyle kesintiye uğramıştı.",
                Image = new Image()
                { ImageId = 7, Height = 20, Width = 40, ImgPath = "Images/rain-in-the-pitlane-1.jpg" },
                Serie = new Serie()
                { SeriesId = 2, Name = "MotorBike Series", Race = new Race() { RaceId = 3, Name = "MotoGp" } }
            }); 
            _news.Add(new News()
            {
                NewsId = 8,
                NewsTitle = "Marquez büyük kaza sonrası Endonezya GP'de yarışamayacak!",
                NewsArticle =
                     "Pazar sabahı gerçekleştirilen 20 dakikalık ısınma seansında Marquez, 7. virajda büyük bir kaza yapmıştı.\r\n\r\nAltı kez MotoGP dünya şampiyonu, motosikletinin üzerinden fırlayarak büyük bir süratle yere çarptı ve hem sol tarafına hem de başına darbeler aldı.\r\n\r\nİspanyol sürücü, paramparça olmuş RC213V'sinin yanında bir süre duraksadı ve sonrasında sendeleyerek de olsa ayağa kalktı. Buna karşılık pek iyi durumda olmadığı görülebiliyordu.\r\n\r\nMarquez daha sonra tedbir amaçlı helikopterle hastaneye nakledildi ve yarışa katılıp katılmayacağı belirsizdi.\r\n\r\nYapılan kontrollerin ardından Marquez'in 1997'den bu yana yapılan ilk MotoGP Endonezya GP'ye katılmasının uygun görülmediği açıklandı.\r\n\r\nMotoGP, son dönemde bu alandaki kuralları sıkılaştırdı ve Marquez, beyin sarsıntısı geçirdiği için yarışta yer alamayacak.\r\n\r\nİspanyol sürücü, cumartesi günkü sıralama turlarında iki ayrı kaza yapmış ve ancak 15. olabilmişti.",
                Image = new Image() { ImageId = 8, Height = 20, Width = 40, ImgPath = "Images/marc-marquez-repsol-honda-team.jpg" },
                Serie = new Serie()
                { SeriesId = 2, Name = "MotorBike Series", Race = new Race() { RaceId = 3, Name = "MotoGp" } }
            });
            _news.Add(new News()
            {
                NewsId = 9,
                NewsTitle = "Endonezya MotoGP yarışı, güvenlik endişeleri nedeniyle kısaltıldı",
                NewsArticle = "MotoGP, Lombok adasında kurulan yeni pistin ev sahipliği altında, 1997'den beri ilk kez Endonezya'ya döndü ve şubat ayındaki testler epey sorunlu geçti.\r\n\r\nLastik tedarikçisi Michelin, aşırı sıcak nedeniyle  son olarak 2018 yılında kullanılan MotoGP lastiklerini Endonezya'ya getirme kararı aldı.\r\n\r\nDucati ve Yamaha sürücüleri, eski lastiklerde önemli bir sorun görmediklerini belirtirken, Honda ve Suzuki sürücüleri arka yol tutuş eksikliğinden şikayetçilerdi.\r\n\r\nHonda sürücüsü Pol Espargaro, Michelin'in bu lastikleri getirmesinin haksızlık olduğunu ve bunun RC213V'yi olumsuz etkilediğini belirtti. İspanyol sürücü hatta arka yol tutuş eksikliği nedeniyle ön tarafa daha fazla baskı bindiği için, yarışı bitiremeyeceğine inanıyordu.\r\n\r\nTakım arkadaşı Marc Marquez ise tüm hafta sonu ön tarafta sorunlar yaşadı ve pazar sabahı ısınma seansında çok büyük bir kaza yaptı.\r\n\r\nKontrol amaçlı hastaneye götürülen İspanyol sürücünün bugün yarışıp yarışmayacağı belirsiz.\r\n\r\nMoto2 yarışında pist sıcaklığı 43 dereceye ulaşmış durumda ve bu da işlerin daha da zor olacağı anlamına geliyor.\r\n\r\nTüm bu durumu göz önünde bulunduran MotoGP yönetimi, yaptığı toplantı sonrası aşırı sıcaktan kaynaklı güvenlik endişeleri nedeniyle, 25 yıl sonra yapılan ilk Endonezya GP'sinin süresini 27 turdan 20'ye indirdiğini duyurdu.\r\n\r\nFIA güvenlik sorumlusu Franco Uncini, \"Yüksek sıcaklıktan kaynaklı güvenlik sorunları nedeniyle mesafeyi kısaltmaya karar verdik.\" açıklamasını yaptı.",
                Image = new Image()
                { ImageId = 9, Height = 20, Width = 40, ImgPath = "Images/francesco-bagnaia-ducati-team-.jpg" },
                Serie = new Serie()
                { SeriesId = 2, Name = "MotorBike Series", Race = new Race() { RaceId = 3, Name = "MotoGp" } }
            });
            _news.Add(new News()
            {
                NewsId = 10,
                NewsTitle = "Rea: \"Motivasyonum hiç olmadığı kadar yüksek\"",
                NewsArticle =
                    "Geçtiğimiz yıl efsanevi bir mücadelede şampiyonluğu Toprak Razgatlıoğlu'na kaybeden Rea, 2022 sezonunda 2015'de Kawasaki sürücüsü olmasından bu yana ilk kez 1 numara ile yarışamayacak.\r\n\r\n35 yaşındaki Rea, geçtiğimiz yıl Chaz Davies'in emekli olmaya karar vermesinin ve Leon Haslam ve Tom Sykes'ın Honda ve BMW'deki koltuklarını kaybetmelerinin ardından, yeni sezonda griddeki en yaşlı sürücülerden biri olacak.\r\n\r\nRea, onun yaşındaki birçok sürücünün pist dışında bir hayatı düşünmeye başlamalarına rağmen, kendisinin gridde kalma ve şampiyonluklar alma isteğinin hâlâ güçlü olduğunu söyledi.\r\n\r\nRea, WSBK'nın resmi web sitesine verdiği demeçte, \"Kariyerimin bu noktasında motivasyonumun hiç olmadığı kadar yüksek olduğunu hissediyorum.\"\r\n\r\n\"Şu anda kazanmak, motosikletimin sınırlarını zorlamak, rakiplerimi yenmekten motive oluyorum. Ayrıca yeni yerlere seyahat etmekten ve arka planda takım ile sıkı çalışmaktan çok fazla keyif alıyorum.\"\r\n\r\n\"Geçtiğimiz yıl beni garip hissettiren şey Chaz'ın emekli olması oldu. O benim rakibimdi ve neredeyse Chaz'a gidip, 'Bu sezondan sezona ya da yarıştan yarışa içinden geçirdiğin bir şey miydi yoksa sadece bir gün aklına geliyor ve bitiyor mu?' demek istedim. Çünkü bir gün benim de zamanımın geleceğini biliyorum ve yolumu tamamlamak istiyorum. Şu anda böyle bir hissin olmadığını söyleyebilirim.\"\r\n\r\n\"Bu kazanmakla, Kawasaki'de elimden en iyisini yapmakla ve keyif almakla alakalı. Bu, evde ve sezon aralarında çok fazla çaba gerektiriyor. Eğer keyif almıyorsam geri adım atmak için mükemmel bir zaman ama kazanma şansım varsa ve eğleniyorsam kesinlikle gridde olacağım.\" dedi.\r\n\r\n\r\nRea, geçtiğimiz yıl şampiyonluğu Razgatlıoğlu'na kaybetmenin faydalarından birinin, kış arasındaki iş yükünün azalması olduğunu söyledi. İrlandalı, aralık ayındaki sezon sonrası testlerinden bu yana dinlenme ve yenilenme imkanı buldu.\r\n\r\n\"Bu kış arası oldukça iyi oldu. Şampiyonluk kazandığında TV, medya ve diğer şeyler için inanılmaz oluyor.\"\r\n\r\n\"Ancak arka plandaki pazarlama iş birliklerini ve bir sponsor, üretici veya ülkeyi görmek için her yere uçtuğumuzu görmüyorsunuz. Jerez'deki testten önceki son uçuşum Aralık ayında buraya geldiğim zamandı. Bu nedenle çok iyi bir ara oldu.\"\r\n\r\n\"Bazen 1 numara olmanın ağırlığı fazla oluyor. Dünya şampiyonu olmamanın pozitif yanlarından keyif aldım ama bu 1. olma isteğimin önüne geçmiyor. Bunu istiyorum ve bu sezon bunu başarmak için sıkı çalışacağım.\"\r\n\r\nBu yıl Kawasaki ZX-10RR'ında #65 ile yarışacak olan Rea, Razgatlıoğlu'nun yeni sezona yenilecek sürücü olarak girdiğini belirtti.\r\n\r\n\"Ona karşı bahse girmek aptallık olur ve yıla gerçekten favori olarak başladığını düşünüyorum. Bunun da onun etrafındaki ilgiye ve geleceği üzerindeki hazırlıklara yardımcı olduğunu düşünüyorum.\"\r\n\r\n\"2022'de nasıl performans göstereceğini merak ediyorum.\"",
                Image = new Image()
                { ImageId = 10, Height = 20, Width = 40, ImgPath = "Images/jonathan-rea-kawasaki-racing-t.jpg" },
                Serie = new Serie()
                { SeriesId = 2, Name = "MotorBike Series", Race = new Race() { RaceId = 4, Name = "World Superbike" } }
            });
        }
        public List<News> GetAll()
        {
            return _news;
        }
        public void AddNewsData(News addnews)
        {
            _news.Add(addnews);
        }
    }
}
