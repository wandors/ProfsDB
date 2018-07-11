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
        //Резонанс в ЗМІ
    }
    [Serializable]
    class Wor : People
    {
        //Авторитет
    }
    [Serializable]
    class Zlodiy : People
    {
        //Злодій в законі
    }
    [Serializable]
    class Kiler : People
    {
        //Вбивство на замловлення ст.115 ч 2 п.п. 6,11,12
    }

    [Serializable]
    class Band : People
    {
        //Бандитизм ст.257
    }
    [Serializable]
    class PrNacB : People
    {
        //Посягання на територіальну цілісність і недоторканність України ст. 110 
    }
    [Serializable]
    class Separ : People
    {
        //Створення не передбачених законом воєнізованих або збройних формувань ст.260 ч.2
    }
    [Serializable]
    class Naric : People
    {
        //Наркоділок з міжрегіональними звязками ст.305
    }
    [Serializable]
    class Shahr : People
    {
        //Шахрайство ст.190 ч.4
    }
    [Serializable]
    class LOZG : People
    {
        //Лідер ОЗГ стт.255
    }
    [Serializable]
    class Slujba : People
    {
        //Службові злочини ст. 191 ч. 5
    }
    [Serializable]
    class Habar : People
    {
        //Одержання хабара cn 368 ч. 3,4
    }
    [Serializable]
    class Zvlada : People
    {
        //Зловживання владою або службовим становищем ст. 364 ч.3
    }
}
