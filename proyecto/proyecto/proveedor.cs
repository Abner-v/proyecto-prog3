using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{
    [Serializable]
    public class proveedor : persona
    {
        public string codprove { get; set; }
        public string empresa { get; set; }
        public proveedor(string nom, string dir, int tel, string cod, string empre) : base(nom,0, dir, tel)
        {
            this.empresa = empre;
            this.codprove = cod;
        }
    }
}
