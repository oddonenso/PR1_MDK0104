using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Users
    {
        [Key]
        [Column("UserID")]
        public int UserID { get; set; }

        [Column("Login", TypeName = "varchar(150)")]
        public string Login { get; set; } = string.Empty;

        [Column("Password", TypeName = "varchar(65535)")]
        public string Password { get; set; } = string.Empty;
    }
}
