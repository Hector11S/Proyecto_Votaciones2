using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class PantallasViewModelComparer : IEqualityComparer<PantallasViewModel>
    {
        public bool Equals(PantallasViewModel x, PantallasViewModel y)
        {
            return x.Pant_Id == y.Pant_Id;
        }

        public int GetHashCode(PantallasViewModel obj)
        {
            return obj.Pant_Id.GetHashCode();
        }
    }

}
