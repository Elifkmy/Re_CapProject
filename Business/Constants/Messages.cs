using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarAdded = "Araç Eklendi.";
        public static string CarRegistrationInvalid = "Ekleme İşlemi Geçersiz.";
        public static string CarDailyPriceInvalid = "Arabanın günlük fiyatı 0'dan büyük olmalıdır";
        public static string CarDeleted = "Araç Silindi.";
        public static string CarUpdated = "Araç Güncelleme Başarılı.";
        public static string CarsListed = "Araçlar Listelendi";
        
        public static string ColorAdded = "Renk Eklendi.";
        public static string ColorDeleted = "Renk Silindi.";
        public static string ColorUpdated = "Renk Güncelleme Başarılı.";
        public static string ColorListed = "Renkler Listelendi";

        public static string BrandDeleted = "Marka Silindi.";
        public static string BrandUpdated = "Marka Güncelleme Başarılı.";
        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandRegistrationInvalid = "Marka Ekleme İşlemi Geçersiz.";
        public static string BrandListed = "Markalar Listelendi";

        public static string UserAdded = "Yeni kullanıcı eklendi.";
        public static string UserDeleted = "Sisteme kayıtlı kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı.";
        public static string UserListed = "Kullanıcılar Listelendi";

        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerDeleted = "Müşteri Silinmiştir.";
        public static string CustomerUpdated = "Müşteri Güncellenmiştir.";
        public static string CustomerListed = "Müşteriler Listelendi";

        public static string RentalAdded = "Kiralama işlemi başarılı.";
        public static string RentalAddFailed = "Araç teslim edilmeden kiralama yapılamaz.";
        public static string RentalUpdated = "Kiralama bilgileri güncellendi.";
        public static string RentalDeleted = "Kiralama bilgileri silindi";
        public static string RentalListed = "Kiralanan araçlar listelendi";

        public static string CarImageAdded = "Araç resimleri eklendi";
        public static string CarImageDeleted = "Resimler silindi";
        public static string CarImageUpdated = "Resimler güncellendi";
        public static string CarImageListed = "Resimler Listelendi";
        public static string CarImageLimit = "Bir araca ait görüntü limiti(5) aşıldı";

        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
