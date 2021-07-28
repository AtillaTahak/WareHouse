# DepoProjesi
Depo ve stok takip etmek için yazılmış basit bir uygulama 

* System.Data.SqlClient sınıfı kullanarak daha sonra işimize lazım olacak sınıflarımızı tanımladık 
SqlConnection
SqlDataAdapter
DataSet 
SqlCommand

*Programımız Açıldığında direk grid dolmasını istediğimiz için Forum Load Kısmına bir gridDoldur diye bir metot oluşturduk geriye değer döndürmeyeceği için bu metodumuzu void olarak tanımladık burada sqlConnection sınıfımızı tanımladık ve connectStringimizi yazdık dataAdapter sınıfıza çalışak sorgumuzu ve bağlantı bildiğilerimizin olduğu SqlConnection sınıfından oluşturduğumuz connection değişkenmizi gönderdik dataSet ile gridview'imizin sourcesine istediğimiz UrunListesi tablosunu gönderdik 
gridDoldur metodunda aynı zamanda projemizde olan toplam maliyet ve toplam satış labellerini doldurduk gridte ve tabloda yaptığımız her değişiklikte bu ikisi değişeceği için aynı metotda olması daha mantıklı olarak gördüm 

*Tablomuzda aynı isimli ürün olmasını istemedim düzenle ve ürün çıkışında herhangi bir karışıklık olmaması için aynı ürün kontrolunu sağlayabileceğim bir method oluşturdum 

*Baglantı açma işlemini her sorguda tekrar connecstring belirtmeme adına bir baglantiAc diye void türünde bir method oluşturdum 

*Formumun anasayfasında sadece ürün girişi olmasını istedim bunun için label ve textboxlar ile formumun tasarımını yaptım UrunAdet, UrunMaliyet , UrunSatis için oluşturduğum textboxları sadece sayı girilmesini istediğim için textbox'un KeyPress eventine bu olayları kontrol edip bu textBoxların hiç harf almamasını sağladım 


*Formum Tasarımda en alta admin giriş butonu koydum bu buttona tıklandığında girisAdmin diye oluşturduğum form'un showdialog ile gösterdim burada showdialog seçme sebebim show ile gösterdiğimiz zaman alta ki forma ulaşım sağlanabiliyordu bunu istemediğim için showdialog ile gösterdim 

*girisAdmin formu için dataAdapter ile bir sorgu çalıştırdım bu sorguda kullanıcı adı ile şifresini tablomuzda olup olmadığını gösteren bir sorgu idi eğer kullanıcı var ise sorgumuz çalışacak ve DataTable sınıfından oluşturduğumuz dataTable değişkenimiz içi dolacak ve ilk satırında  1 değerini getirecek bunu kullanarak bir if satırında kontrolunu sağladım 1 değer geldiği zaman adminPanel formunu yine showDialog ile göstermesini istedim 

*adminPanel formun tasarımı için burada ürün çıkışı, ürün silme, üründüzenleme ve grid alanlarının olmasını istedim bunun için ürün düzenlemede ürün id'si ile arama yaparak arama yaptığımız ürünün verilerinin ürün düzenleme için oluşturduğum textbox'lara olan değerlerine atadım güncelle metodu ile textboxta ki verileri update sql sorgusu ile tablomuza aktardım buradan yine boş değer gönderilmemesi için textboxların boş olup olmadığını kontrol ettim 

*adminPanelinde yine gridDoldur metodunu ve bu metodun içinde label dolurması için gereken kodları kullandım 

*adminPanelinde Ürün çıkışı için comboBox kullandım farklı elementler kullanarak daha göze güzel gelip ve kullanışlı olması comboBoxda ürünlerin isimleri formLoad'da doldurulması için bir metor yazdım ComboboxDoldur adında burada select sorgusunu kullanarak UrunListesinde ki UrunAd'larını aldım ve dataRead'ı bir while döngüsünde butun verileri aldım bu metotda her değişiklikte güncellemesini istediğim için method olarak oluşturdum ve Ürün Çıkışı ve Ürün Silmesi de ikisi içinde comboBoxlar dolmasını sağladım 

*adminPanelinde Aynı isimli kontrolu için metot yazdım sonra onun yerine textBoxda ürün adını aldığım textBox'ın Enable özeliğini değiştirip false yaptım bu şekilde bir nevi label gibi çalışmasını sağladım 
*Form1 de kullandığım gibi burada da sayısal verileri aldığım textboxların KeyPress Event'lerine metinsel ifade girilmemesi için bu eventte kontroller sağladım 
