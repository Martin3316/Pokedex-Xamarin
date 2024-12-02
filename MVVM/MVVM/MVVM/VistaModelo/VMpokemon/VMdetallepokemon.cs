using MVVM.Datos;
using MVVM.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.VistaModelo.VMpokemon
{
   public  class VMdetallepokemon : BaseViewModel
    {
        #region VARIABLES

        public string _Texto;
        public Mpokemon pokemon { get; set; }
        string _objcolorfondo;
        string _objcolorpoder;
        string _objnombre;
        string _objnro;
        string _objpoder;
        string _objicono;

        public Mpokemon parametrosRecibe {  get; set; }

        #endregion

        #region CONSTRUCTOR
        public VMdetallepokemon(INavigation navigation, Mpokemon parametrosTrae)
        {
            Navigation = navigation;
            parametrosRecibe = parametrosTrae;
            pokemon = parametrosTrae;
            _objcolorfondo = pokemon.Colorfondo;
            _objcolorpoder = pokemon.Colorpoder;
            _objnombre = pokemon.Nombre;
            _objnro = pokemon.Nroorden;
            _objpoder = pokemon.Poder;
            _objicono = pokemon.Icono;
        }
        #endregion

        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        #endregion


        #region 

        public string ColorFondo
        {
            get { return _objcolorfondo; }
            set
            {
                SetValue(ref _objcolorfondo, value);
                OnPropertyChanged(nameof(ColorFondo));
            }

        }

        public string ColorPoder
        {
            get { return _objcolorpoder; }
            set
            {
                SetValue(ref _objcolorpoder, value);
                OnPropertyChanged(nameof(ColorPoder));
            }
        }

        public string Nombre
        {
            get { return _objnombre; }
            set { SetValue(ref _objnombre, value); }
        }

        public string Numero
        {
            get { return _objnro; }
            set { SetValue(ref _objnro, value); }
        }

        public string Poder
        {
            get { return _objpoder; }
            set { SetValue(ref _objpoder, value); }
        }

        public string Icono
        {
            get { return _objicono; }
            set { SetValue(ref _objicono, value); }
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }
        #endregion
        public async Task NavegarPagina()
        {
            await Navigation.PopAsync();
        }
        public async Task ProcesoAsyncrono()
        {
        }

        #region COMANDOS
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);

        public ICommand Volvercommand => new Command(async () => await Volver());

        
        #endregion
    }
}
