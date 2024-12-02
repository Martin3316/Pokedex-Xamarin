using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.VistaModelo.VMpokemon;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrarpokemon : ContentPage
    {
        public Registrarpokemon()
        {
            InitializeComponent();
            BindingContext = new VMregistropokemon(Navigation);
        }
    }
}