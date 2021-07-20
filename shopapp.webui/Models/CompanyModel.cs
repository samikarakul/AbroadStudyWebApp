using System.ComponentModel.DataAnnotations;

namespace shopapp.webui.Models
{
    public class CompanyModel
    {
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyNumber { get; set; }
        [Required]
        public string CompanyEmail { get; set; }
        [Required]
        public string CompanyAdress { get; set; }
    }
}