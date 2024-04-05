using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Sistema_Votaciones.Models
{
    public class FormDataViewModel
    {
        public string Alca_Id { get; set; }
        public List<IFormFile> Imagen { get; set; }
    }
}
