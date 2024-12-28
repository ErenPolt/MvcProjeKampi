# Mvc Proje Kampı

# Genel Bakış
 Bu projede popüler sözlük uygulamalarının işleyişi baz alınarak bir Ekşi Sözlük benzeri site geliştirildi. Kullanıcıların sözlük başlıklarını görebileceği ve istediği başlığa bir entry girebileceği, kendisine diğer kullanıcılar tarafından gelen mesajları görebileceği bir kullanıcı paneli oluşturuldu. Admin tarafında başlıkların kategorilerini düzenleme, başlıkların ve içeriklerin yönetimi, mesajlaşma modülü gibi bir çok özellik eklendi.
# 1-Vitrin
Projenin tanıtımı amacıyla bir Vitrin paneli tasarlandı. Proje hakkında bilgi verildi.
# 2-Admin Paneli
✦  Kategoriler: Sitede bulunacak başlıkların eklendiği kategoriler listelenir.

✦  Ekle/Sil/Güncelle işlemleri uygulanabilir ve kategoriye ait başlıklar listelenir.

✦  Başlıklar: Sitede bulunan başlıklar listelenir ve içerikleri görüntülenebilir.

✦  Ekle/Sil/Güncelle işlemleri uygulanabilir. Aktif/Pasif Yap butonu ile başlığın görüntülenme durumu değiştirilebilir.

✦  Yazılar: Sitedeki tüm entry'ler listelenir ve arama filtresi uygulanabilir.

✦  Yazarlar: Siteye kayıt olan kullanıcılar listelenir ve yeni kullanıcı eklenebilir.

✦  Grafikler: Her kategorinin kaç başlığa sahip olduğu pie chart ile, başlıklara eklenen entry'lerin sayısı line chart ile görselleştirilir.

✦  İstatistikler: Siteye ait veriler listelenir.

✦  Hakkımda: Site için hakkımda yazısı güncelleme ve ekleme özelliği.

✦  Raporlar: Sitedeki başlıkları Excel, CSV veya PDF olarak kaydetme özelliği.

✦  İletişim & Mesajlar: Admin, gelen mesajları görüntüleyebilir ve yeni mesajlar oluşturabilir.

✦  Yeni mesaj oluşturma, gelen mesajları görüntüleme, gönderdiği mesajları listeleme özellikleri.

✦  Taslak mesaj kaydedebilir ve Çöp Kutusuna mesaj gönderebilir.

✦  Yetkilendirmeler: Admin yetkileri güncellenebilir ve yeni admin eklenebilir.

✦  A yetkisine sahip admin, B yetkisine sahip adminin bilgilerini güncelleyemez. 'Yetkiniz yok' uyarısı alır.

✦  Galeri: Sitedeki görseller listelenir.

✦  Hata Sayfası: 404 hata sayfası eklendi.

# 3-Yazar Paneli
✦ Profilim: Kullanıcı bilgilerini güncelleyebilir.

✦ Başlıklarım: Kullanıcının sözlüğe eklediği başlıklar listelenir.

✦ Eklediği başlığa diğer kullanıcıların yaptığı entry'leri İçerik butonu ile görebilir.

✦ Düzenle ile başlık adını ve kategorisini değiştirebilir.

✦ Tüm Başlıklar: Sitede bulunan tüm başlıklar listelenir.

 ✦Başlığın içeriğini görüntüleyebilir, başlığa yeni bir entry girebilir.

✦ Mesajlar: Kullanıcı, diğer kullanıcılara yeni mesaj gönderebilir, gelen mesajlarını görüntüleyebilir, gönderdiği mesajları görebilir.

✦ Taslak Mesaj oluşturabilir, biçimlendirebilir ve dilerse tekrar iletebilir.

✦ Çöp Kutusu, mesajları tekli veya çoklu olarak silebilir, çöp kutusuna taşıyabilir.

✦ Yazılarım: Başlıklara eklediği entry'leri burada görür.

✦Siteye Git: Siteye gidebilir, içerikleri görüntüleyebilir.

# Veri Tabanı İlişkileri

![Ekran görüntüsü 2024-12-28 235343](https://github.com/user-attachments/assets/d3c32970-2770-4514-832b-7db773fdd13a)
# Kullanılan Teknolojiler
|✦Asp.Net MVC ile hazırlanmıştır.|✦Repository Design Pattern kullanıldı.|
|:---------------------------------|:--------------------------------------|
|✦Entity Framework kullanılmıştır.|✦DbFirst yaklaşımı uygulanmıştır. |
|✦N Katmanlı Mimari ile oluşturuldu.|✦CRUD işlemleri|
|✦MSSQL veri tabanı kullanılmıştır.|✦ChartJS ile chartlar oluşturuldu.|
|✦LINQ sorguları.|✦Partial Views, Paging ve Search işlemleri uygulandı.|
|✦Error Page Kullanımı|✦Dropdown ile veri listeleme|
|✦Data Annotations|✦Validation Rules uygulandı.|
|✦Session Yönetimi|✦Authentication ve Authorize işlemleri|


# Görseller
![Ekran görüntüsü 2024-12-29 001751](https://github.com/user-attachments/assets/62b639cc-9ce3-4e08-98de-2dfa56c16cb6)
![Ekran görüntüsü 2024-12-29 002220](https://github.com/user-attachments/assets/287c8091-98f0-4fce-88e3-e4ebcd3b147f)
![Ekran görüntüsü 2024-12-29 002237](https://github.com/user-attachments/assets/e9493072-f4d7-4b25-9c15-daac6610c85d)
![Ekran görüntüsü 2024-12-29 002249](https://github.com/user-attachments/assets/b5cd23f3-fab7-467d-9624-3a79e17f69b6)
![Ekran görüntüsü 2024-12-29 002309](https://github.com/user-attachments/assets/16b6228a-f9bf-4b39-b508-dcc7637c4b58)
![Ekran görüntüsü 2024-12-29 002441](https://github.com/user-attachments/assets/6cb55a4b-13de-4afd-b20b-8564f72b21ac)

# Admin Paneli
![Ekran görüntüsü 2024-12-29 003100](https://github.com/user-attachments/assets/ba9bc889-3aa7-4f70-93d9-5b9c2d4b376e)
![Ekran görüntüsü 2024-12-29 003124](https://github.com/user-attachments/assets/edcd3dc1-9c2f-4dbc-a9c3-39c4b0399ff8)
![Ekran görüntüsü 2024-12-29 003506](https://github.com/user-attachments/assets/8215d154-d8f6-47fb-9f81-9258122063c0)
![Ekran görüntüsü 2024-12-29 003535](https://github.com/user-attachments/assets/586f2c56-04af-4fa3-8f63-b43ededd5e4c)
![Ekran görüntüsü 2024-12-29 003550](https://github.com/user-attachments/assets/bd7681c9-37bd-4376-81ce-0d627fe23257)
![Ekran görüntüsü 2024-12-29 003604](https://github.com/user-attachments/assets/098f26dd-f9e9-446d-8b07-a85623465004)
![Ekran görüntüsü 2024-12-29 003622](https://github.com/user-attachments/assets/7af7ff0b-336c-47a7-9bbe-21a0635be134)
![Ekran görüntüsü 2024-12-29 003640](https://github.com/user-attachments/assets/a4441490-f241-492f-985f-86cae2aca360)
![Ekran görüntüsü 2024-12-29 003652](https://github.com/user-attachments/assets/77fd96c6-a29c-44c9-92de-21f22e6e818d)
![Ekran görüntüsü 2024-12-29 003804](https://github.com/user-attachments/assets/84d95112-2d33-4da6-9364-411bff4f2eb2)
![Ekran görüntüsü 2024-12-29 003931](https://github.com/user-attachments/assets/f7a79f2e-62cb-4f07-b6c9-52d9051c478e)
![Ekran görüntüsü 2024-12-29 003905](https://github.com/user-attachments/assets/70c22918-c8a3-414d-8f3a-85c245655d50)
![Ekran görüntüsü 2024-12-29 003956](https://github.com/user-attachments/assets/e1141e65-ca36-49ac-a322-e1649d18275e)
![Ekran görüntüsü 2024-12-28 ](https://github.com/user-attachments/assets/fef20ae7-a1db-4d6e-a3dd-2dbbd7546e00)
![Ekran görüntüsü 2024-12-29 004034](https://github.com/user-attachments/assets/5e6b581c-d718-4252-91ec-e1c0ff213b60)
![Ekran görüntüsü 2024-12-29 004046](https://github.com/user-attachments/assets/c24e0cb4-bdfd-424b-b829-59dd1b927ff1)

# Yazar Paneli
![Ekran görüntüsü 2024-12-29 004954](https://github.com/user-attachments/assets/e815094a-a5b4-4739-9871-20eb8c6f3b38)
![Ekran görüntüsü 2024-12-29 005021](https://github.com/user-attachments/assets/a28357c9-4e40-4f8e-89b2-5d268f417eb9)
![Ekran görüntüsü 2024-12-29 005031](https://github.com/user-attachments/assets/eada47b5-f65c-44d7-a02c-5dc1cdf8502a)
![Ekran görüntüsü 2024-12-29 005226](https://github.com/user-attachments/assets/d39ea936-26af-414b-aab1-7fbe4d7fa473)
![Ekran görüntüsü 2024-12-29 005907](https://github.com/user-attachments/assets/1391c466-178b-4e34-a147-2197f87e3abd)
![Ekran görüntüsü 2024-12-29 005332](https://github.com/user-attachments/assets/e38b7c59-b097-4668-b2d5-ed0489da48e6)
![Ekran görüntüsü 2024-12-29 005312](https://github.com/user-attachments/assets/583782fe-806a-4ae3-8944-94ae453125d9)
![Ekran görüntüsü 2024-12-29 005332](https://github.com/user-attachments/assets/4b6f265c-ea88-4651-9468-3a22ebf669bd)
![Ekran görüntüsü 2024-12-29 005415](https://github.com/user-attachments/assets/5dd9f4ee-fd05-4cf2-b43b-d7305ac24ba2)
![Ekran görüntüsü 2024-12-29 005430](https://github.com/user-attachments/assets/662e2716-b71b-4974-94dc-e063daa3f82c)
![Ekran görüntüsü 2024-12-29 005520](https://github.com/user-attachments/assets/0bae0b62-0b8d-4378-8af2-aacf9bed0d3b)













