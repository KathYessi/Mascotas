using System;
namespace mascotas.Models
{
    public class Adopcion
    {

        public int id { get; set; }
       
        public string Nombre{ get; set; }
         
        public string Telefono{ get; set; }
        
        public int Distrito{ get; set; }
        
        public int TipoMascota{ get; set; }

    }
}