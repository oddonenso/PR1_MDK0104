using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class UserDetail
    {
        [Key]
        [Column("ID")]

        public int ID { get; set; }

        [Column("UserID")]
        [ForeignKey("Users")]
        public int UserID { get; set; }

        [Column("Surname", TypeName = "varchar(50)")]
        public string Surname { get; set; } = string.Empty;

        [Column("Name", TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column("Patronymic", TypeName = "varchar(50)")]
        public string Patronymic { get; set; } = string.Empty;

        public Users? Gender { get; set; }
    }
}
