using System;
using System.Collections.Generic;

namespace DiccionarioGENERICO
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Tuple<string, string>> Ciudad = new Dictionary<int, Tuple<string, string>>();
            Ciudad.Add(1, new Tuple<string, string> ("Buenos Aires", "La Plata"));
            Ciudad.Add(2, new Tuple<string, string>("Catamarca","San Fernando del Valle de Catamarca"));
            Ciudad.Add(3, new Tuple<string, string>( "Chaco","Resistencia"));
            Ciudad.Add(4, new Tuple<string, string>(" Chubut","Rawson"));
            Ciudad.Add(5, new Tuple<string, string>("Córdoba","Córdoba"));
            Ciudad.Add(6, new Tuple<string, string>("Corrientes","Corrientes"));
            Ciudad.Add(7, new Tuple<string, string>(" Entre Ríos" ,"Paraná"));
            Ciudad.Add(8, new Tuple<string, string>(" Formosa","Formosa"));
            Ciudad.Add(9, new Tuple<string, string>("Jujuy ","San Salvador de Jujuy"));
            Ciudad.Add(10,new Tuple<string, string> ("La Pampa","Santa Rosa"));
            Ciudad.Add(11,new Tuple<string, string> ("La Rioja","La Rioja"));
            Ciudad.Add(12,new Tuple<string, string> ("Mendoza ","Mendoza"));
            Ciudad.Add(13,new Tuple<string, string> ("Misiones","Posadas"));
            Ciudad.Add(14,new Tuple<string, string> ("Neuquén","Neuquén"));
            Ciudad.Add(15,new Tuple<string, string> ("Río Negro","Viedma"));
            Ciudad.Add(16,new Tuple<string, string> ("Salta ","Salta"));
            Ciudad.Add(17,new Tuple<string, string> ("San Juan","San Juan"));
            Ciudad.Add(18,new Tuple<string, string> ("San Luis","San Luis"));
            Ciudad.Add(19,new Tuple<string, string> ("Santa Cruz ","Río Gallegos"));
            Ciudad.Add(20,new Tuple<string, string> ("Santa Fe ","Santa Fe"));
            Ciudad.Add(21,new Tuple<string, string> ("Santiago del Estero ","Santiago del Estero"));
            Ciudad.Add(22,new Tuple<string, string> ("Tierra del Fuego, Antártida e Islas del Atlántico Sur ","Ushuaia"));
            Ciudad.Add(23, new Tuple<string, string> ("Tucumán","San Miguel De Tucumán"));

            Console.Write("Ingrese el número de la provincia a buscar del 1-23 : ");
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Ciudad[numero]);
            Console.ReadKey();
        }
    }
}
