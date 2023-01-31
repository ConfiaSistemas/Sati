using System;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    class NumLetra
    {
        private string[] UNIDADES = new[] { "", "Un ", "Dos ", "Tres ", "Cuatro ", "Cinco ", "Seis ", "Siete ", "Ocho ", "Nueve " };
        private string[] DECENAS = new[] { "Diez ", "Once ", "Doce ", "Trece ", "Catorce ", "Quince ", "Dieciséis ", "Diecisiete ", "Dieciocho ", "Diecinueve ", "Veinte ", "Veintiún ", "Veintidós ", "Veintitrés ", "Veinticuatro ", "Veinticinco ", "Veintiséis ", "Veintisiete ", "Veintiocho ", "Veintinueve ", "Treinta ", "Cuarenta ", "Cincuenta ", "Sesenta ", "Setenta ", "Ochenta ", "Noventa " };
        private string[] CENTENAS = new[] { "", "Ciento ", "Doscientos ", "Trescientos ", "Cuatrocientos ", "Quinientos ", "Seiscientos ", "Setecientos ", "Ochocientos ", "Novecientos " };
        private Regex r;

        public string Convertir(string numero, bool mayusculas)
        {
            string literal = "";
            string parte_decimal;
            numero = numero.Replace(".", ",");

            if (numero.IndexOf(",") == -1)
            {
                numero = numero + ",00";
            }

            r = new Regex(@"\d{1,9},\d{1,2}");
            var mc = r.Matches(numero);

            if (mc.Count > 0)
            {
                var Num = numero.Split(',');
                parte_decimal = Convert.ToInt64(Conversions.ToDouble(Num[1]) * 10d).ToString("00") + "/100 M.N.";

                if (int.Parse(Num[0]) == 0)
                {
                    literal = "Cero ";
                }
                else if (int.Parse(Num[0]) > 999999)
                {
                    literal = getMillones(Num[0]);
                }
                else if (int.Parse(Num[0]) > 999)
                {
                    literal = getMiles(Num[0]);
                }
                else if (int.Parse(Num[0]) > 99)
                {
                    literal = getCentenas(Num[0]);
                }
                else if (int.Parse(Num[0]) > 9)
                {
                    literal = getDecenas(Num[0]);
                }
                else
                {
                    literal = getUnidades(Num[0]);
                }

                if (mayusculas)
                {
                    return "(" + (literal + " PESOS " + parte_decimal).ToUpper() + ")";
                }
                else
                {
                    return "(" + literal + " Pesos " + parte_decimal + ")";
                }
            }
            else
            {
                return CSharpImpl.__Assign(ref literal, null);
            }
        }

        private string getUnidades(string numero)
        {
            string num = numero.Substring(numero.Length - 1);
            return UNIDADES[int.Parse(num)];
        }

        private string getDecenas(string num)
        {
            int n = int.Parse(num);

            if (n < 10)
            {
                return getUnidades(num);
            }
            else if (n > 29)
            {
                string u = getUnidades(num);

                if (u.Equals(""))
                {
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 17];
                }
                else
                {
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 17] + "y " + u;
                }
            }
            else
            {
                return DECENAS[n - 10];
            }
        }

        private string getCentenas(string num)
        {
            if (int.Parse(num) > 99)
            {

                if (int.Parse(num) == 100)
                {
                    return " Cien ";
                }
                else
                {
                    return CENTENAS[int.Parse(num.Substring(0, 1))] + getDecenas(num.Substring(1));
                }
            }
            else
            {
                return getDecenas(int.Parse(num) + "");
            }
        }

        private string getMiles(string numero)
        {
            string c = numero.Substring(numero.Length - 3);
            string m = numero.Substring(0, numero.Length - 3);
            string n = "";

            if (int.Parse(m) > 0)
            {
                n = getCentenas(m);
                return n + "Mil " + getCentenas(c);
            }
            else
            {
                return "" + getCentenas(c);
            }
        }

        private string getMillones(string numero)
        {
            string miles = numero.Substring(numero.Length - 6);
            string millon = numero.Substring(0, numero.Length - 6);
            string n = "";

            if (millon.Length > 1)
            {
                n = getCentenas(millon) + "Millones ";
            }
            else
            {
                n = getUnidades(millon) + "Millon ";
            }

            return n + getMiles(miles);
        }

        private class CSharpImpl
        {
            [Obsolete("Please refactor calling code to use normal Visual Basic assignment")]
            public static T __Assign<T>(ref T target, T value)
            {
                target = value;
                return value;
            }
        }
    }
}