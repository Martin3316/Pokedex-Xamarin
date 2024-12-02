using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvm-3f900-default-rtdb.firebaseio.com/");
    }
}
