using System;
using System.Collections.Generic;
using System.Text;
using MVVM.Modelo;
using MVVM.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace MVVM.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon parametros)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    Colorfondo = parametros.Colorfondo,
                    Colorpoder = parametros.Colorpoder,
                    Icono = parametros.Icono,
                    Nombre = parametros.Nombre,
                    Nroorden = parametros.Nroorden,
                    Poder = parametros.Poder
                }
                );
            
        }
      public async Task<ObservableCollection<Mpokemon>> Mostrarpokemones()
        {
            //return (await Cconexion.firebase
            //    .Child("Pokemon")
            //    .OnceAsync<Mpokemon>())
            //    .Select(item => new Mpokemon
            //    {
            //        Idpokemon = item.Key,
            //        Colorfondo = item.Object.Colorfondo,
            //        Colorpoder = item.Object.Colorpoder,
            //        Icono = item.Object.Icono,
            //        Nombre = item.Object.Nombre,
            //        Nroorden = item.Object.Nroorden,
            //        Poder = item.Object.Poder
            //    }
            //    ).ToList();

            var data = await Task.Run(()=> Cconexion.firebase
                .Child("Pokemon")
                .AsObservable<Mpokemon>()
                .AsObservableCollection());
            return data;
        }
    }
}
