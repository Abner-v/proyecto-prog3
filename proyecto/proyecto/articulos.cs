using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{
    [Serializable]
    public class articulo
    {
        public string producto { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public int codigo { get; set; }

        public articulo(string pro, int cod, int cant, decimal pre)
        {
            this.producto = pro;
            this.precio = pre;
            this.cantidad = cant;
            this.codigo = cod;
        }
        

    }
}
