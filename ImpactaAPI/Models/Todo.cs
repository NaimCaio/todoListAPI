using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Models
{
    [Table("todo_list")]
    public class Todo
    {
        public int Id { get; set; }
        public string descricao { get; set; }
    }
}
