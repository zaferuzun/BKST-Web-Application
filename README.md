# BKST-Web-Application
Uygulama Wep Api Kısmı Uygulama test olarak http://testbkst.tarbil.gov.tr/Service/  wep apisine bağlıdır. Test için username TestUser password TestPass@ olarak alınmıştır.  
Bearer Token alınması için  
new KeyValuePair<string, string>( "grant_type", "password" ), new KeyValuePair<string, string>( "username", TestUser), new KeyValuePair<string, string> ( "Password", TestPass@) 
kullanılmıştır. 
Bearer Token ile istenilen işlemler yapılması öngörülmüştür. Lakin GlnNo ve Key değerleri test için bulunmamaktadır. İstenilen bildirim ve bildirim listeme işlemleri Bakanlığın kılavuzundan bakılarak gerçekleştirilmiş olup tam test yapılamamıştır. 
Bildirim gönderme; Gerekli bilgiler kullanıcıdan tarafından verildikten sonra filtreleme işlemlerinden geçer. Veritabanından veriler detay olarak eklendikten sonra bildirim wep apisine bildiriliyor. 
public ActionResult DetailsConfirmed(UrunlerVM urunVM) { 
 //Gerekli bilgilerin hazırlanıp bildirim için oluşturulan fonksiyona gönderilmesi işlemi 
} 
public static JsonTypeResult sendNotificationAndDetail(string Gln, string Key, string HeaderText, string DetailText) { 
 //Verileri Bearer Token kullanarak wep apisine gönderim işlemi ve wep apisinden gelen veriyi belirtilen formata çevirmesi 
} 
public class JsonTypeResult {  //Wep apisinden gelen verinin neye göre parse edilmesini sağlayan sınıf } 
Bildirim listeleme; public ActionResult Notification(string str) { 
 //bildirim listelemek için gerekli bilgilerin kullanıcıdan alınıp wep apisine gönderilerek gelen cevabın parse edilip model aracılığı ile kullanıcıya gösterilmesidir. 
} 
public static JsonTypeResult getTransactionList(string Gln, string Key, string DocumentNumber, DateTime StartDate, DateTime EndDate, string NotificationType) { 
 ////Verileri Bearer Token kullanarak wep apisine gönderim işlemi ve wep apisinden gelen veriyi belirtilen formata çevirmesi 
} 

 
 
public class JsonTypeResult {  //Wep apisinden gelen verinin neye göre parse edilmesini sağlayan sınıf } 
public class NotificationHistory { 
 //JesonTypeResult sınıfında oluşturulan bir List ile apinin data içerisinde gönderilen bilgileri alan sınıftır. Bu sınıf Notification fonksiyonunda view olarak gönderilerek bilgiler kullanıcıya ulaştırılır. 
} 
Ülkelerin Listelenmesi Projede böyle bir şey istenilmemişti fakat yaptığım denemeler sonucunda wep apiden kayıtlı ülkelerin test kullanıcıyla erişilebildiğini tespit ettim. Bildirim geçmişi gibi bir mantıkta bu bilgileri kullanıcıya sundum. 
Web Uygulama Veritabanı Kısmı Veritabanı istenildiği üzere Mysql kullanılarak oluşturulmuştur. Mailde belirtildiği gibi aynı değişkenlerle  değişiklik yapılmadan oluşturulmuştur. remotemysql.com üzerinden ücretsiz mysql veritabanı oluşturulup projeye bağlandı. Kullanıcı CRUD işlemleri yaparken, kullanıcı ile veritabanı iletişimi ViewModel ile sağlandı.  
Web Uygulama Görüntü Kısmı Uygulama için hazır bir template olan https://www.free-css.com/free-csstemplates/page168/agroplus kullanıldı. Gerekli yerlerde css kısımları eklendi. Gerekli yerlerde javascript kullanıldı. 
 
Web Uygulama Yapım Kısmı Uygulama yapılırken Get, POST, PUT istekleri gözlemlenebilmesi için Postman, veritabanı gerekli işlemleri için Navicat kullanıldı. Uygulama geliştirilirken github ile senkron çalışıldı. https://github.com/zaferuzun/BKST-Web-Application.   
