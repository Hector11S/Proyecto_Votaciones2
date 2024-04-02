using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Votaciones.BusinessLogic
{
    public class RequestStatus
    {
        public RequestStatus(int _CodeStatus)
        {
            CodeStatus = _CodeStatus;
        }
        public int CodeStatus { get; set; }
        public string MessageStatus { get; set; }
    }
}
