using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NeldnerMK.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            return value switch
            {
                6 => "шестерка",
                7 => "семерка",
                8 => "восьмерка",
                9 => "девятка",
                10 => "десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => "Неверный номер карты"
            };


        }
    }
}