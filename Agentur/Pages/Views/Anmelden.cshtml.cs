using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Agentur.Pages
{
    public class AnmeldenModel : PageModel
    {
        [Required]
        [Display(Name = "Vorname")]
        public string Vorname { get; set; }

        [Required]
        [Display(Name = "Nachname")]
        public string Nachname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Geburtsdatum")]
        public DateTime Geburtsdatum { get; set; }

        [Required]
        [Display(Name = "Geschlecht")]
        public string Geschlecht { get; set; }

        [Required]
        [Display(Name = "Mobil-Nr.")]
        [Phone]
        public string MobilNr { get; set; }

        [Display(Name = "Telefon-Nr.")]
        [Phone]
        public string TelefonNr { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Zustimmung Datenschutzvereinbarung")]
        public bool ZustimmungDatenschutz { get; set; }

        public void OnGet()
        {
        }
    }
}
