using Nexti_Winform.Services;

namespace Nexti_Winform
{
    public partial class Home : Form
    {
        private readonly ICliente _cliente;
        public Home(ICliente cliente)
        {
            this._cliente = cliente;

            InitializeComponent();
        }

    }
}