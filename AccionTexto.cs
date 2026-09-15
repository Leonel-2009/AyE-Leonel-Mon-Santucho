using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    public class AccionTexto
    {
        public string TipoAccion;
        public string Contenido;
        public DateTime FechaHora;

        public AccionTexto(string TipoAccion, string Contenido)
        {
            this.TipoAccion = TipoAccion;
            this.Contenido = Contenido;
            this.FechaHora = DateTime.Now;
        }
    }
}
