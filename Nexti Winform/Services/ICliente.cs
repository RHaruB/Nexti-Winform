using Nexti_Winform.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexti_Winform.Services
{
    public interface ICliente
    {
        public List<ClienteVM> GetAllCliente();
    }
}
