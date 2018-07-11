using System;
using System.Collections.Generic;

namespace ProfsDB
{
    class ReadDB
    {

        public string _keys;
        public object _values;
        public void Reads(int _inpbs, string path)
        {
            int _inpts = _inpbs - 1;
            object arryPR = DeserelzeD.DeserD(path);
            UserPrefs arrPR = (UserPrefs)arryPR;
            switch (_inpts)
            {
                case 0:
                    object _wor = arrPR.Wor;
                    var _liseW = (Dictionary<string, object>)_wor;
                    foreach (KeyValuePair<string, object> id in _liseW)
                    {
                        _keys = id.Key.ToString();
                        _values = id.Value;
                        Console.WriteLine(_keys);
                    }

                    Wor _vorse = (Wor)_values;
                    Console.WriteLine(_vorse.Soname);
                    Console.WriteLine(_vorse.Name);
                    Console.WriteLine(_vorse.Father);
                    Console.WriteLine(_vorse.Probl);
                    break;
                case 1:
                    object _kilK = arrPR.Kiler;
                    var _liseK = (Dictionary<string, object>)_kilK;
                    foreach (KeyValuePair<string, object> id in _liseK)
                    {
                        _keys = id.Key.ToString();
                        _values = id.Value;
                        Console.WriteLine(_keys);
                    }
                    Kiler _kil = (Kiler)_values;
                    Console.WriteLine(_kil.Soname);
                    Console.WriteLine(_kil.Name);
                    Console.WriteLine(_kil.Father);
                    Console.WriteLine(_kil.Probl);

                    break;
                case 2:
                    object _kilB = arrPR.Bandit;
                    var _liseB = (Dictionary<string, object>)_kilB;
                    foreach (KeyValuePair<string, object> id in _liseB)
                    {
                        _keys = id.Key.ToString();
                        _values = id.Value;
                        Console.WriteLine(_keys);
                    }
                    Band _ban = (Band)_values;
                    Console.WriteLine(_ban.Soname);
                    Console.WriteLine(_ban.Name);
                    Console.WriteLine(_ban.Father);
                    Console.WriteLine(_ban.Probl);
                    break;
            }

        }
    }
}
