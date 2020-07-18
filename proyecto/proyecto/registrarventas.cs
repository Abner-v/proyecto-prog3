using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{
    [Serializable]
    public class registrarventas
    {
        
        public int boleta { get; set; }
        public List<string> vendidos { get; set; }
        public decimal total { get; set; }
        public DateTime fecha { get; set; }
        public string vendedor { get; set; }
        public registrarventas(int bo, List<string> ven, decimal total, DateTime fech, string vendedor)
        {
            this.boleta = bo;
            this.vendidos = ven;
            this.total = total;
            this.fecha = fech;
            this.vendedor = vendedor;
        }

    }
}
