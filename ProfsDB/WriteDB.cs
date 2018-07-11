using System;
using System.Collections.Generic;

namespace ProfsDB
{
    class WriteDB
    {
        private UserPrefs userData = new UserPrefs();
        private UserPrefs arrp;
        private object userP;
        private UserPrefs userPrefsd;
        private static readonly string[] oblic = new string[] { "Авторитет", "Кілер", "Бандитизм" };
        //private Vidoma vidomas = new Vidoma();
        //private Zlodiy zlodiys = new Zlodiy();
        private readonly Wor vors = new Wor();
        private readonly Kiler kils = new Kiler();
        private readonly Band band = new Band();
        /*
        private PrNacB prnarcs = new PrNacB();
        private Separ separs = new Separ();
        private Naric narics = new Naric();
        private Shahr shhrs = new Shahr();
        private LOZG lozgs = new LOZG();
        private Slujba sljbas = new Slujba();
        private Habar habars = new Habar();
        private Zvlada zvladas = new Zvlada();
        
        private Dictionary<string, object> _vidomas = new Dictionary<string, object>();
        private Dictionary<string, object> _zlodiys = new Dictionary<string, object>();
        */
        private Dictionary<string, object> _wors = new Dictionary<string, object>();
        private Dictionary<string, object> _kils = new Dictionary<string, object>();
        private Dictionary<string, object> _band = new Dictionary<string, object>();
        /*
        private Dictionary<string, object> _prnacs = new Dictionary<string, object>();
        private Dictionary<string, object> _separs = new Dictionary<string, object>();
        private Dictionary<string, object> _narics = new Dictionary<string, object>();
        private Dictionary<string, object> _shhrs = new Dictionary<string, object>();
        private Dictionary<string, object> _lozgs = new Dictionary<string, object>();
        private Dictionary<string, object> _sljbas = new Dictionary<string, object>();
        private Dictionary<string, object> _habars = new Dictionary<string, object>();
        private Dictionary<string, object> _zvladas = new Dictionary<string, object>();
        */
        public void Work(string soname, string name, string fatger, int _inpb, string path)
        {
            //Добавити масив облікі
            int _inpbs = _inpb - 1;
            try
            {
                arrp = (UserPrefs)DeserelzeD.DeserD(path);
            }
            catch
            {
                arrp = new UserPrefs();
            }
            switch (_inpbs)
            {
                //Прописати для запису обліків
                case 0:
                    try
                    {

                        _wors = (Dictionary<string, object>)arrp.Wor;
                        foreach (KeyValuePair<string, object> id in _wors)
                        {
                            string _keys = id.Key.ToString();
                            string _keses = String.Format("{0} {1} {2}", soname, name, fatger);
                            if (String.Equals(_keys, _keses))
                            {
                                _wors.Remove(_keses);
                            }
                        }
                    }
                    catch
                    {
                        _wors = new Dictionary<string, object>();
                    }
                    object wores = ProfWorc(vors, soname, name, fatger, _inpbs);
                    string _namesDW = String.Format("{0} {1} {2}", soname, name, fatger);
                    Wor wors = (Wor)wores;
                    _wors.Add(_namesDW, wores);
                    userData.Wor = _wors;
                    userP = ZagProf(userData, arrp, _inpbs);
                    userPrefsd = (UserPrefs)userP;
                    userData = userPrefsd;
                    break;
                case 1:
                    try
                    {
                        _kils = (Dictionary<string, object>)arrp.Kiler;
                        foreach (KeyValuePair<string, object> id in _kils)
                        {
                            string _keys = id.Key.ToString();
                            string _keses = String.Format("{0} {1} {2}", soname, name, fatger);
                            if (String.Equals(_keys, _keses))
                            {
                                _kils.Remove(_keses);
                            }
                        }
                    }
                    catch
                    {
                        _kils = new Dictionary<string, object>(); ;
                    }
                    object kulees = ProfWorc(kils, soname, name, fatger, _inpbs);
                    string _namesDK = String.Format("{0} {1} {2}", soname, name, fatger);
                    Kiler kilesed = (Kiler)kulees;
                    _kils.Add(_namesDK, kilesed);
                    userData.Kiler = _kils;
                    userP = ZagProf(userData, arrp, _inpbs);
                    userPrefsd = (UserPrefs)userP;
                    userData = userPrefsd;
                    break;
                case 2:
                    try
                    {
                        _band = (Dictionary<string, object>)arrp.Bandit;
                        foreach (KeyValuePair<string, object> id in _band)
                        {
                            string _keys = id.Key.ToString();
                            string _keses = String.Format("{0} {1} {2}", soname, name, fatger);
                            if (String.Equals(_keys, _keses))
                            {
                                _band.Remove(_keses);
                            }
                        }
                    }
                    catch
                    {
                        _band = new Dictionary<string, object>();
                    }
                    object bundus = ProfWorc(band, soname, name, fatger, _inpbs);
                    string _namesDB = String.Format("{0} {1} {2}", soname, name, fatger);
                    Band bundused = (Band)bundus;
                    _band.Add(_namesDB, bundused);
                    userData.Bandit = _band;
                    userP = ZagProf(userData, arrp, _inpbs);
                    userPrefsd = (UserPrefs)userP;
                    userData = userPrefsd;
                    break;
                default:
                    Console.Write("Good");
                    break;
            }
            object lister = userData;
            SerelizeD.SrelD(lister, path);
        }
        private static object ProfWorc(object clis, string soname, string name, string father, int profint)
        {
            People peop = new People();
            People Clis = (People)clis;
            Clis.Soname = soname;
            Clis.Name = name;
            Clis.Father = father;
            Clis.Probl = oblic[profint];

            object pipel = Clis;
            return Clis;

        }
        private static object ZagProf(object zafpr, object arripe, int profin)
        {
            UserPrefs ZriPr = (UserPrefs)zafpr;
            UserPrefs arrip = (UserPrefs)arripe;
            switch (profin)
            {
                case 0:
                    ZriPr.Kiler = arrip.Kiler;
                    ZriPr.Bandit = arrip.Bandit;
                    break;
                case 1:
                    ZriPr.Wor = arrip.Wor;
                    ZriPr.Bandit = arrip.Bandit;
                    break;
                case 2:
                    ZriPr.Wor = arrip.Wor;
                    ZriPr.Kiler = arrip.Kiler;
                    break;
            }
            return ZriPr;
        }
    }
}
