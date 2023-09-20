using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexti_Winform.ViewModels
{
    public class ClienteVM
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public byte[] FotoPerfil { get; set; }
        public string FotoPerfilSTR { get; set; }
        public string Cursos { get; set; }
    }
}
