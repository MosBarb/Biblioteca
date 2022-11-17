using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScuoleMedie
{
    internal class biblioteca : libro
    {
        internal string nome { get; set; }
        internal string indirizzo { get; set; }
        internal string OrarioApertura { get; set; }
        internal string OrarioChiusura { get; set; }

        internal biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;

            
        }
    }
}
