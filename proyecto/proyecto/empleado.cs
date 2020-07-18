using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{
    [Serializable]
    public class empleado:persona
    {
        public string codigo;
        public string horario;
        public empleado(string nom,int dni, string dir, int tel, string cod, string hor) : base(nom,dni,dir,tel)
        {
            this.codigo = cod;
            this.horario = hor;
        }


    }
}
