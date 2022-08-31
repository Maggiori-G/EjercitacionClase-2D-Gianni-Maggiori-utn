using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeporte
{
    public static class ValidadoraString
    {
        private static int limiteCaracteres;

        static ValidadoraString()
        {
            limiteCaracteres = 5;
        }

        public static int LimiteCaracteres
        {
            set
            {
                limiteCaracteres = value;
            }
        }

        public static bool CheckearSiNombreEsValido(string dato)
        {
            if (dato.Length > limiteCaracteres)
                return true;
            return false;
        }


        public static bool CheckearCantidadDeLetrasE(string dato)
        {
            if (dato.Length > limiteCaracteres)
                return true;
            return false;
        }
    }
}
