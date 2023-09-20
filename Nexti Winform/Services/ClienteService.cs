using Nexti_Winform.Models;
using Nexti_Winform.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexti_Winform.Services
{
    public class ClienteService : ICliente
    {
        private readonly NextiContext _contex;
        public ClienteService(NextiContext context)
        {
            _contex = context;
        }

        public List<ClienteVM> GetAllCliente()
        {
            List<ClienteVM> lista = new List<ClienteVM>();
           var result = _contex.Clientes.ToList();
            foreach ( var item in result )
            {
                ClienteVM clienteVM = new ClienteVM
                {
                    Apellido = item.Apellido,
                    Cedula = item.Cedula,
                    Correo = item.Correo,
                    Cursos = item.Cursos,
                    FotoPerfil = item.FotoPerfil,
                    Nombre = item.Nombre,
                    Telefono = item.Telefono
                };
                lista.Add(clienteVM);
            }

            return lista;

        }
    }
}
