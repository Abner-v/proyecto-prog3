using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{
    [Serializable]
    public class persona
    {
        
        public string nombre { get; set; }
        public int dni { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
     /*    {
       public string nombre;
        public string direccion;
        public int telefono;*/
        public persona(string nom,int dni, string dir, int tel)
        {
            this.nombre = nom;
            this.dni = dni;

            this.direccion = dir;
            this.telefono = tel;
        }
        
    }
        
}
