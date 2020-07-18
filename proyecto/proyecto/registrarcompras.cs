using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{
    [Serializable]
    public class Compra
          {
        public string nombre { get; set; }
        public string codigo_producto { get; set; }
        public decimal costo { get; set; }
        public decimal precio_venta { get; set; }
        public float descuento { get; set; }
        public string factura { get; set; }
        public int cantidad { get; set; }
        public Compra(string nom, string cod, decimal cos, decimal preci, float descue,string factura,int cantidad)
            {
            this.nombre = nom;
            this.codigo_producto = cod;
            this.costo = cos;
            this.precio_venta = preci;
            this.descuento = descue;
            this.factura = factura;
            this.cantidad = cantidad;
            }      
        }
    }

