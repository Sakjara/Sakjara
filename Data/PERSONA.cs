//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONA
    {
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public System.DateTime FECHA_NACIMIENTO { get; set; }
        public string SEXO { get; set; }
        public string ESTADO { get; set; }
        public string PROFESION { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1}", RUT, NOMBRE);
        }
    }
}
