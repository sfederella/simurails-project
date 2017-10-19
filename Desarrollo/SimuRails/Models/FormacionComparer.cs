using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class FormacionComparer : IComparer<Formacion>
    {
        public int Compare(Formacion x, Formacion y)
        {
            int result = x.HoraSalida.CompareTo(y.HoraSalida);
            if (result == 0) result = x.Id.CompareTo(y.Id);
            return result;
        }
    }
}
