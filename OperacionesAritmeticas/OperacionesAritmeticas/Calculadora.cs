using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public class Calculadora
    {
        public static decimal sumar(decimal oper1, decimal oper2)
        {
            return oper1 + oper2;
        }
        public static decimal restar(decimal oper1, decimal oper2)
        {
            return oper1 - oper2;
        }
        public static decimal multiplicar(decimal oper1, decimal oper2)
        {
            return oper1 * oper2;
        }
        public static decimal dividir(decimal oper1, decimal oper2)
        {
            return oper1 / oper2;
        }
        public static decimal modulo(decimal oper1, decimal oper2)
        {
            return oper1 % oper2;
        }
        public static Resultado simultaneas(decimal oper1, decimal oper2)
        {
            Resultado rResultado = new Resultado();
            rResultado.suma = sumar(oper1, oper2);
            rResultado.resta = restar(oper1, oper2);
            rResultado.multiplicacion = multiplicar(oper1, oper2);
            rResultado.division = dividir(oper1, oper2);
            rResultado.modulo = modulo(oper1, oper2);
            return rResultado;

        }

        public static decimal Operacion(OperacionesAritmetica operacionesAritmetica)
        {
            Resultado reResultado = new Resultado();
            decimal result = 0;
            if (operacionesAritmetica.tipoOperacion == tipoOperacion.sumar)
                result = sumar(operacionesAritmetica.operando1, operacionesAritmetica.operando2);

            else if (operacionesAritmetica.tipoOperacion == tipoOperacion.restar)
                result = restar(operacionesAritmetica.operando1, operacionesAritmetica.operando2);

            else if (operacionesAritmetica.tipoOperacion == tipoOperacion.multiplicar)
                result = multiplicar(operacionesAritmetica.operando1, operacionesAritmetica.operando2);

            else if (operacionesAritmetica.tipoOperacion == tipoOperacion.dividir)
                result = dividir(operacionesAritmetica.operando1, operacionesAritmetica.operando2);

            else if (operacionesAritmetica.tipoOperacion == tipoOperacion.modulo)
                result = modulo(operacionesAritmetica.operando1, operacionesAritmetica.operando2);

            else if(operacionesAritmetica.tipoOperacion == tipoOperacion.todas)

                reResultado = simultaneas(operacionesAritmetica.operando1, operacionesAritmetica.operando2);
                Console.WriteLine("El resultado de la suma es: " + reResultado.suma);
                Console.WriteLine("El resultado de la resta es: " + reResultado.resta);
                Console.WriteLine("El resultado de la multiplicacion es: " + reResultado.multiplicacion);
                Console.WriteLine("El resultado de la division es: " + reResultado.division);
                Console.WriteLine("El resultado del modulo es: " + reResultado.modulo);
            return result;
        }
        public static void Presentacion()
        {

            Console.WriteLine("Ingrese el primer valor: ");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            decimal valor2 = decimal.Parse(Console.ReadLine());


            Console.WriteLine(" 1.- Sumar \n 2.- Restar \n 3.- Multiplicar \n 4.- Dividir \n 5.- Modulo \n 6.- Todas");
            Console.WriteLine("Seleccione la Operacion\n");
            decimal oper = int.Parse(Console.ReadLine());

            OperacionesAritmetica oOperacionAritmetica = new OperacionesAritmetica();
            oOperacionAritmetica.operando1 = valor1;
            oOperacionAritmetica.operando2 = valor2;
            oOperacionAritmetica.tipoOperacion = (tipoOperacion)oper;

            decimal resultado = Operacion(oOperacionAritmetica);



            Console.WriteLine($"El resultado es: {resultado} ");
            Console.ReadKey();

        }
    }
}
