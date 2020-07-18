using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace proyecto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        private static principio primer;
        public static principio inicial()
        {
            return primer;
        }
        public static decimal Calcular(int cant, decimal pre)
        {
            return cant * pre;

        }
       public static void Crear_archivo()
        {
            try
            {
                Stream Archivo = File.OpenRead("kiosko.bin");
                BinaryFormatter deserealizar = new BinaryFormatter();
                primer = (principio)deserealizar.Deserialize(Archivo);
                Archivo.Close();
            }
            catch (Exception e)
            {
                primer = new principio();
            }
        }
        public static void Guardar_archivo()
        {
            Stream Archivo = File.Create("kiosko.bin");
            BinaryFormatter serealizar = new BinaryFormatter();
            serealizar.Serialize(Archivo,primer);
            Archivo.Close();

        }



        [STAThread]
        static void Main()
        {
            /*  primer = new principio();
              inicial();
              primer.agregar_empleado();
              primer.agregar_articulo();
              primer.agregar_proveedor();
              primer.mostrar();
              primer.mostrare();
              primer.mostrarprove();
              */
            Crear_archivo();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            
            
             }
    }
}
