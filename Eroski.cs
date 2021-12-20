using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eroski
{
    public class Eroski
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string seccion { get; set; }
        public int ticket {get; set;}
    }
}
