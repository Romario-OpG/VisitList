using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visit_list
{
   [Table("students")]
   public class Student
   {
      [Column("id")]
      public int Id { get; set; }

      [Column("name", TypeName = "varchar(64)")]
      public string Name { get; set; }

      [Column("surname", TypeName = "varchar(64)")]
      public string Surname { get; set; }

      [Column("birthday")]
      public DateTime Birthday { get; set; }
   }
}
