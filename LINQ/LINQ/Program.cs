using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LINQ
{
    internal class Program
    {
        static  OperacionesLINQ _OP = new OperacionesLINQ();
        static void Main(string[] args)
        {
            _OP.CargarList();

        }
    }
}
