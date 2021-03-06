using System.ComponentModel.DataAnnotations;

namespace Rankings.Web.Models
{
    public class GameTypeViewModel
    {
        [Display(Name = "Code")]
        [StringLength(30)]
        [Required]
        public string Code { get; set; }

        [Display(Name = "Display Name")]
        [StringLength(30)]
        [Required]
        public string DisplayName { get; set; }
    }
}