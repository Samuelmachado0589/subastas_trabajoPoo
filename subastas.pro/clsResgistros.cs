using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace subastas.pro
{
   class clsResgistros
    {
        public string Nombre { get; set; }  
        public string Apellido { get; set; }    
        public string Email { get; set; }
        public double Telefono { get; set;}
        public double Documento { get; set; }

        
        public clsResgistros(string nombre, string apellido, double documneto, double telefono, string email) 
        {
            Nombre = nombre;
            Apellido = apellido;    
            Email = email;
            Telefono = telefono;
            Documento = documneto;
        }
        

  

    }
}
