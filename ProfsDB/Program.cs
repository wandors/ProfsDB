﻿using System;

namespace ProfsDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D://t.dat";
            string soname = "Полунец";
            string name = "Сергій";
            string fatger = "Васильович";
            Console.WriteLine("Введи номер обліку ");
            string _prob = Console.ReadLine();
            Int32.TryParse(_prob, out int _inpb);
            WriteDB wh = new WriteDB();
            wh.Work(soname, name, fatger, _inpb, path);
            ReadDB reds = new ReadDB();
            reds.Reads(_inpb, path);
            Console.ReadKey();
        }
    }
}
