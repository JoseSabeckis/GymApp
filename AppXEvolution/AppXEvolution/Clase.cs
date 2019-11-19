using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppXEvolution
{
    public class Clase
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public IFormFile Foto { get; set; }

        public string FotoLink { get; set; }

        public List<ClaseDetalle> ClaseDetalle { get; set; }

    }
}
