using System.ComponentModel.DataAnnotations;

namespace shopapp.webui.Models
{
    public class ServeModel
    {
        public int ServeId { get; set; }
        
        [Required]
        public string ServeName { get; set; }
        
        [Required]
        public string ServeDescription { get; set; }

        [Required]
        public string ServeImageUrl { get; set; }
    }
}