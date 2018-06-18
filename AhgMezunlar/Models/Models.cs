using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models
{
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
        public string Oject { get; set; }
        public string SenderName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Content { get; set; }
    }
    
}
