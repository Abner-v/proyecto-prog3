using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{

    /*public class principio
    {
        public List<empleado> empleo;
        public List<proveedor> prov;
        public List<articulos> articulos;
       
        public principio()
        {
             empleo = new List<empleado>();
             prov = new List<proveedor>();
             articulos = new List<articulos>();
        }
        public void agregar_empleado(empleado emp)
        {
            empleo.Add(emp);
        }
        public  void agregar_prov(proveedor pro)
        {
             prov.Add(pro);
        }
        public  void agregar_articulo(articulos art)
        {
            articulos.Add(art);
        }

    }*/
    [Serializable]
    public class principio
    {
      public  List<articulo> articulos;
        public List<empleado> empleados;
        public  List<registrarventas> registro_venta;
        public List<proveedor> provee;
        public List<Compra> compre;

        public principio()
        {
            articulos = new List<articulo>();
            empleados = new List<empleado>();
            registro_venta = new List<registrarventas>();
            provee = new List<proveedor>();
            compre = new List<Compra>();


        }
        public void agregarlistaArt(articulo m)
        {
            articulos.Add(m);
        }
        public void agregarempleado(empleado m)
        {
            empleados.Add(m);
        }
        public void agregarlista_de_ventas(registrarventas m)
        {
            registro_venta.Add(m);
        }
        public void agregarlista_de_proveedor(proveedor m)
        {
            provee.Add(m);
        }
        public void agregarlistacompras(Compra c)
        {
            compre.Add(c);
        }
       /* public void agregar_empleado()
        {
            empleado p = new empleado("abner", "vicente lopez", 1232456, "a1", "diurno");
            empleado c = new empleado("jkhkjhkj", "99797", 7655456, "b1", "nocturno");

            this.agregarempleado(p);
            this.agregarempleado(c);

        }
        public void mostrare()
        {
            foreach (var l in empleados)
            {
                
                Console.WriteLine(l.nombre + "  " + l.direccion + "   " + l.telefono + "   " + l.codigo + "   " + l.horario);
            }
        }
        public void agregar_articulo()
        {
            articulo a = new articulo("bananas", 234, 5, 255);
            articulo b = new articulo("peraz", 3, 10, 255);
            this.agregarlistaArt(a);
            this.agregarlistaArt(b);
        }
        public void mostrar()
        {
            foreach (var l in articulos)
                Console.WriteLine((l.cantidad + "   " + l.codigo + "  " + l.precio + "  " + l.producto));
        }
        public void agregar_proveedor()
        {
            proveedor a = new proveedor("aromos", "los olivos", 123456, "a1", "11aromos");

            this.provee.Add(a);
        }
        public void mostrarprove()
        {
            foreach (var l in provee)
                Console.WriteLine(l.nombre + "  " + l.direccion + "   " + l.codprove + "  " + l.telefono + " " + l.empresa);
        }*/
         /*  public void registrar_venta()
           { 
              this.agregarlista_de_ventas(a);
           }
        public void mostrar_ventas()
        {
            foreach (var l in registro_venta)
                Console.WriteLine((l.boleta + "  " + l.total + "   " + l.vendedor));
        }*/
        public void Actualizararticulos(string pro, int can)
        {
            foreach (var l in Program.inicial().articulos)
                if (pro == l.producto)
                {
                    l.cantidad += can;
                }
        }
        public void Actualizararprecio(string pro, decimal can)
        {
            foreach (var l in Program.inicial().articulos)
                if (pro == l.producto)
                {
                    l.precio = can;
                }
        }
    }
}
