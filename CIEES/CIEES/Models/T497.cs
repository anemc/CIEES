using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T497")]
    public class T497
    {
        [Key]
        public int T497ID { get; set; }
        public string Lista { get; set; } //sin contador
        public string Lineamientos { get; set; }
        public string Valor { get; set; }    
       
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}