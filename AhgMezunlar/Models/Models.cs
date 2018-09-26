using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models
{
    public class RegisterModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }

    public class UserInfoModel
    {
        public string Id;
        public string Email;
        public string Role;

    }


    public class SliderImage
    {
        public int Id { get; set; }
        public string Path { get; set; }

        //foto seçerken boyut ve tekrarlı isim uyarısı bulundur

    }

    public class Moments
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SenderName { get; set; }
        public bool ShowState { get; set; }
        public string Email { get; set; }
        public string CoverPhotoPath { get; set; }
        public string Content { get; set; }
    }

    public class Events
    {
        public int Id { get; set; }
        public string IconName { get; set; }
        public string Title { get; set; }
        public string PhotoPath { get; set; }
        public bool ShowOnPage { get; set; }
        public string Content { get; set; }
        public bool PopupState { get; set; }
    }

    public class ContactForm
    {
        public int Id { get; set; }
        public string Object { get; set; }
        public string SenderName { get; set; }
        public string ContactEmail { get; set; }
        public int Phone { get; set; }
        public string Content { get; set; }
        public bool IsRead{ get; set; }
    }
    


}
