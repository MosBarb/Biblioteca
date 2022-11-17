using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScuoleMedie
{
    internal class libro
    {
        internal int pagine { get; set; }
        internal string titolo { get; set; }
        internal string autore { get; set; }

        internal libro()
        {
            this.pagine = pagine;
            this.titolo = titolo;
            this.autore = autore;


        }

        static override toString()
        {
            return string;
        }

        static string ReadingTime(int pagine)
        {
            string tempo = "";
            if (pagine < 100)
            {
                return tempo = "1h";
            }

            if (pagine > 100 || pagine < 200)
            {
                return tempo = "2h";
            }

            if (pagine > 200)
            {
                return tempo = "4h";
            }
        }
    }

    
}
