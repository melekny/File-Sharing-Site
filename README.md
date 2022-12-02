# Dosya Paylaşım Sitesi 
## Proje Tanımı

- Ziyaretçiler bir e-posta adresi ve şifre ile üyelik oluşturabilmelidir.
- Üyeler kendi üyelikleri altında sanal klasörler oluşturabilmeli, bilgilerini değiştirebilmeli ve silebilmelidirler.
Bir sanal klasör silindiğinde tüm alt dosyaları da silinmelidir.
- Üyeler belirledikleri sanal klasörler altına dosya yükleyebilmeli, dosya adını değiştirebilmeli ve silebilmelidir.

- Üyeler istedikleri bir dosya için tek seferlik kullanılabilen bir link oluşturabilmelidir.
- Tek seferlik linkler, üyelik gerektirmeden herhangi bir kişi tarafından da kullanılabilmelidir.
- Üyeler herhangibir dosya için istedikleri kadar tek seferlik link oluşturabilmeli ve oluşturduğu linkleri istediği zaman 
silebilmelidir. Ayrıca kullanılmış linklerin, ne zaman kullanıldığını görebilmelidir.

## Dosyaların Saklanma Şekli

Dosyalar "App_Data" klasörünün altında her bir üye için açılmış klasörler altında depolanacaktır.
- (App_Data/Üye Kimliği/Dosya Kimliği)