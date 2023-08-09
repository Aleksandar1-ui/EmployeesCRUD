using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Models
{
    public class Oddeli
    {
        [Key]
        public int OddelId { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        [DisplayName("Ime na oddel")]
        public string ImeOddel { get; set; }
        [DisplayName("Broj na vraboteni")]
        public int BrojVraboteni { get; set; }

    }
}
