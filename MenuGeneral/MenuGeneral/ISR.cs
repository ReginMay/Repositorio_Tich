using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class ISR
    {
        public static void Calcular(decimal sueldoQ, decimal LimInf,decimal excepLim,
            decimal cuotafija, decimal sudcidio)
        {
            decimal cal1 = sueldoQ - LimInf;
            decimal cal2 = cal1 * (excepLim / 100);
            decimal Resultado = cal2 + cuotafija - sudcidio;

            Console.WriteLine("\nEl ISR es igual a: $"+Resultado);

        }


        public static void CargarTabla(Decimal sueldoM,string nombreArchivo)
        {
            Decimal sueldoQ = sueldoM / 2;

            string linea;

            StreamReader archivo = new StreamReader(@"C:\Users\Tichs\Documents\Introducción C#\" + nombreArchivo);

            //linea = archivo.ReadToEnd();
            //Console.WriteLine(linea);

            int i = 0;

            decimal[,] _tablaISR = new decimal[20, 5];

            while ((linea = archivo.ReadLine()) != null) 
            {
                string [] partesISR = linea.Split(',');
                _tablaISR[i, 0] = Convert.ToDecimal(partesISR[0]);
                _tablaISR[i, 1] = Convert.ToDecimal(partesISR[1]);
                _tablaISR[i, 2] = Convert.ToDecimal(partesISR[2]);
                _tablaISR[i, 3] = Convert.ToDecimal(partesISR[3]);
                _tablaISR[i, 4] = Convert.ToDecimal(partesISR[4]);


                i++;

            }
            archivo.Close();

            //for (int u = 0; u < 20; u++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(_tablaISR[u, j] + ",");
            //    }
            //    Console.Write("\n");
            //}

            decimal LimInf = 0;
           // decimal LimSup = 0;
            decimal cuotafija = 0;
            decimal excepLim = 0;
            decimal sudcidio = 0;

            for (int t = 0; t < 20; t++)
            {
                if (_tablaISR[t, 0] < sueldoQ && _tablaISR[t, 1] > sueldoQ)
                {
                    LimInf = _tablaISR[t, 0];
                 //   LimSup = _tablaISR[t, 1];
                    cuotafija = _tablaISR[t, 2];
                    excepLim = _tablaISR[t, 3];
                    sudcidio = _tablaISR[t, 4];
                    break;
                }

            }

            Calcular(sueldoQ,LimInf,excepLim,cuotafija,sudcidio);
            


        }

    }   
}
