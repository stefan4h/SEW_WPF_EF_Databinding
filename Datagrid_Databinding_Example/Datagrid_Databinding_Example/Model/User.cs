using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagrid_Databinding_Example.Model
{
    [Table("users")]
    public partial class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Column("e-mail-adress")]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }
    }
}
