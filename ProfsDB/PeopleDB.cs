using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfsDB
{

    [Serializable]
    public class People
    {
        public string Soname { get; set; }
        public string Name { get; set; }
        public string Father { get; set; }
        public string Probl { get; set; }
        public string Birsday { get; set; }
        public string SttUK { get; set; }
        public string PoStr { get; set; }
        public string Dsr { get; set; }
        public string Zbm { get; set; }
        public string Udz { get; set; }
        public string KiStr { get; set; }
        public string ImageP { get; set; }
        public string Vids { get; set; }
    }
    [Serializable]
    public class UserPrefs
    {
        public object Vidoma { get; set; }
        public object Zlodiy { get; set; }
        public object Wor { get; set; }
        public object Kiler { get; set; }
        public object Bandit { get; set; }
        public object PrNacB { get; set; }
        public object Separ { get; set; }
        public object Naric { get; set; }
        public object Shahr { get; set; }
        public object LOZG { get; set; }
        public object Slujba { get; set; }
        public object Habar { get; set; }
        public object Zvlada { get; set; }
    }

    [Serializable]
    class Vidoma : People
    {
       
    }
    [Serializable]
    class Wor : People
    {
    }
    [Serializable]
    class Zlodiy : People
    {
    }
    [Serializable]
    class Kiler : People
    {
    }

    [Serializable]
    class Band : People
    {
    }
    [Serializable]
    class PrNacB : People
    {
    }
    [Serializable]
    class Separ : People
    {
    }
    [Serializable]
    class Naric : People
    {
    }
    [Serializable]
    class Shahr : People
    {
    }
    [Serializable]
    class LOZG : People
    {
    }
    [Serializable]
    class Slujba : People
    {
    }
    [Serializable]
    class Habar : People
    {
    }
    [Serializable]
    class Zvlada : People
    {
    }
}
