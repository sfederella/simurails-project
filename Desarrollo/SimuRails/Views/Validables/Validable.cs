using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Views.Validables
{
    interface Validable
    {
        void mostrarError();

        Boolean esValido();
    }
}
