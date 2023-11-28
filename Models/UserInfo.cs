using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        /*
            bu kısmı formdan gelen bilgileri taghelper ile alıp kullanmak 
        */

        //apply.cshtml de "novalidate" yaparak hata mesajını kendim yazdım
        
        //Required yaparak kullanıcıya bu alan zorunlu olduğunu ve bir giriş yapmasını söylüyorum
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alanı zorunlu")] 
        public string? Name { get; set; }//null

        [Required(ErrorMessage ="Telefon alanı zorunlu")] 
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Email alanı zorunlu")] 
        [EmailAddress(ErrorMessage ="Hatalı email")] //email formatında da olmasını kontrol et dedim
        public string? Email { get; set; }

        [Required(ErrorMessage ="Katılım durumunuzu belirtiniz.")] 
        public bool? WillAttend { get; set; }//true,false,null
    }
}