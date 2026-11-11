using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_doga
{
    internal class Games
    {
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public DateTime KiadasDatum { get; set; }
        public int AktivJatekosok { get; set; }
        public float Ertekeles { get; set; }

        public override string ToString() =>
            $"\tJáték címe: {Cim}\n" +
            $"\tMűfaj: {Mufaj}\n" +
            $"\tKiadási dátuma: {KiadasDatum}\n" +
            $"\tAktív játékosok: {AktivJatekosok}\n" +
            $"\tÉrtékelés: {Ertekeles:0.0}/5,0";
    }
}
}
