using MVVM.Modelo;
using MVVM.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace MVVM.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES

        public string _Texto;
        public List<Mmenuprincipal> listapaginas { get; set; }

        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
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
        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://i.postimg.cc/VvvHP4Ky/Mario-RPG-imagen.png"
                },

                new Mmenuprincipal
                {
                    Pagina ="CollectionView sin enlace a base de datos",
                    Icono = "https://i.postimg.cc/tJXqbLVS/chill-guy-meme-png-para-descargar.jpg"
                },

                new Mmenuprincipal
                {
                    Pagina = "Crud pokemon",
                    Icono ="https://i.postimg.cc/Twv27y2X/juegos.png"
                }
            };
        }

        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion

        #region COMANDOS
       // public ICommand Volvercommand => new Command(async () => await volver());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
