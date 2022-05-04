using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Models
{
    [Table("accounts")]
    public class User
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string permissao { get; set; }


    }
}
