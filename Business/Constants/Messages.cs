using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme Başarılı";
        public static string Deleted = "Silme Başarılı";
        public static string Updated = "Güncelleme Başarılı";
        public static string NameError = "İsim en az 2 karakterli olmalıdır.";
        public static string PriceError = "Günlük Fiyat 0 dan büyük olmak zorundadır.";
        public static string Listed = "Listeleme Başarılı";
        public static string SuccessRent = "Kiralama Başarılı";
        public static string ErrorRent = "Kiralama Başarısız";
        public static string ToManyCarImage = "Araba Resimleri 5 Taneden Fazla Olamaz.";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Parola Yanlış";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token  Oluşturuldu";
    }
}
