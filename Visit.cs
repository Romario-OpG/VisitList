using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visit_list
{
   [Table("visit")]
   public class Visit
   {
      [Column("id")]
      public int Id { get; set; }

      [Column("student_id")]
      public int Student_id { get; set; }

      [Column("date")]
      public DateTime Date { get; set; }

      [Column("attend")]
      public bool Attend { get; set; }
   }
}
