using System;
using System.Collections.Generic;
using System.Text;

namespace AppXEvolution
{
    public class Cliente
    {

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Dni { get; set; }

        public string Telefono { get; set; }

        public string Domicilio { get; set; }

        public string Mail { get; set; }

        public DateTime FechaNacimiento { get; set; }

        //public byte[] Foto { get; set; }
        public string FotoLink { get; set; }

        public Sexo Sexo { get; set; }

        public GrupoSanguineo GrupoSanguineo { get; set; }

        public DateTime FechaDeIngreso { get; set; }

    }
}
