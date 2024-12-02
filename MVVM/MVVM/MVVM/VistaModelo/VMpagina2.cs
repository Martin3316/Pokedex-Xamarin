using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM.Modelo;
using static System.Net.WebRequestMethods;

namespace MVVM.VistaModelo
{
    public class VMpagina2: BaseViewModel
    {
        #region VARIABLES

        public string _Texto;
        public List<Musuarios> listausuarios { get; set; }

        #endregion

        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        #endregion

        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region PROCESOS

        public async Task volver()
        {
            await Navigation.PopAsync();
        }
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre = "Mario",
                    Imagen = "https://i.postimg.cc/VvvHP4Ky/Mario-RPG-imagen.png"
                },

                new Musuarios
                {
                    Nombre = "Pepe",
                    Imagen = "https://i.postimg.cc/QCzY85zF/avatares.png"
                },

                new Musuarios
                {
                    Nombre = "Elena",
                    Imagen = "https://i.postimg.cc/VsZVWQNz/avatares-1.png"
                }
            };
        }

        public async Task Alerta(Musuarios parametros)
        {
            DisplayAlert("Titulo", parametros.Nombre, "OK");
        }
        #endregion

        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await volver());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Alertacommand => new Command<Musuarios>(async(p)=>await Alerta(p));
        #endregion
    }
}
