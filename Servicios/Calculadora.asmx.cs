using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicios
{
    /// <summary>
    /// Descripción breve de Calculadora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculadora : System.Web.Services.WebService
    {

        [WebMethod(Description ="suma de numeros")]
        public double Suma(double nro1,double nro2)
        {
            double resultado;
            resultado = nro1 + nro2;
            return resultado;
        }
        private double Fact(int n)
        {
            if (n == 0) return 1;
            else return n * Fact(n - 1);
        }
        [WebMethod(Description = "factorial de numeros")]
        public double Factorial(int n)
        {
            return Fact(n);
        }
        [WebMethod(Description = "resta de numeros")]
        public double Resta(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1 - nro2;
            return resultado;
        }
        [WebMethod(Description = "multiplicacion de numeros")]
        public double Mult(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1 * nro2;
            return resultado;
        }
        [WebMethod(Description = "division de numeros")]
        public double Division(double nro1, double nro2)
        {
            double resultado;
          
            resultado = nro1 / nro2;
            if (nro2 == 0)
                resultado.ToString("ERROR"); 
           
            return resultado;
        }

        [WebMethod(Description = "potencia de numeros")]
        public double Potencia(double nro1, double nro2)
        {
            double resultado;
            resultado = Math.Pow(nro1, nro2);
            return resultado;
        }
        [WebMethod(Description = "Porcentaje de un número")]
        public double Porcentaje(double nro1)
        {
            double resultado;
            resultado = nro1 / 100;
            return resultado;
        }
        [WebMethod(Description = "tangente de numeros")]
        public double Tangente(double nro1)
        {
            double resultado;
            double s;
            s = nro1 * Math.PI / 180;
            resultado = Math.Tan(s);
            return resultado;
        }
        [WebMethod(Description = "Coseno de un número")]
        public double Coseno(double nro1)
        {
            double resultado;
            double s;
            s = nro1 * Math.PI / 180;
            resultado = Math.Cos(s);
            return resultado;
        }
        [WebMethod(Description = "Seno de un número")]
        public double Seno(double nro1)
        {
            double resultado;
            double s;
            s = nro1 * Math.PI / 180;
            resultado = Math.Sin(s);
            return resultado;
        }
    }
}
