using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tiempo
{
    public class Tiempo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public decimal GpxX { get; set; }
        public decimal GpxY { get; set; }
        public string Region { get; set; }
        public int Temperatura { get; set; }
        public int VelViento { get; set; }
        public int Humedad { get; set; }
        public int Precipitaciones { get; set; }
    }
}
