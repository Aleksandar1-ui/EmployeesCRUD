using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Models
{
    public class Vraboteni
    {
        [Key]
        public int VrabotenId { get; set; }
        [Column(TypeName ="nvarchar(30)")]
        public string Ime { get;set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Prezime { get; set; }
        public decimal Plata { get; set; }
        [DisplayName("Oddel")]
        public int OddelId { get; set; }
    }
}
