using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraIMSS2
{
    public class Calculadora
    {

        public decimal uma;
        public decimal sb;
        public int tip;

        public static Aportaciones Calcular(decimal uma, decimal sb, int tip)
        {
            Aportaciones ap = new Aportaciones();
            if (tip == 1)
            {
                Console.WriteLine("Patron");

                ap.EM = (sb - (3 * uma) * 1.1m);
                Console.WriteLine("Enfermedades y Maternidad");
                Console.WriteLine(ap.EM);
                Console.WriteLine(" ");

                ap.IV = (sb * (1.75m));
                Console.WriteLine("Invalidez y Vida");
                Console.WriteLine(ap.IV);
                Console.WriteLine(" ");

                ap.RT = (sb * (2));
                Console.WriteLine("Retiro");
                Console.WriteLine(ap.RT);
                Console.WriteLine(" ");

                ap.CS = (sb * (3.150m));
                Console.WriteLine("Cesantia");
                Console.WriteLine(ap.CS);
                Console.WriteLine(" ");

                ap.IN = (sb * (0.5m));
                Console.WriteLine("Credito Infonavit");
                Console.WriteLine(ap.IN);
                Console.WriteLine(" ");
            }
            else if (tip == 2)
            {
                Console.WriteLine("Trabajador");

                ap.EM = (sb - (3 * uma) * 0.4m);
                Console.WriteLine("Enfermedades y Maternidad");
                Console.WriteLine(ap.EM);
                Console.WriteLine(" ");

                ap.IV = (sb * (0.625m));
                Console.WriteLine("Invalidez y Vida");
                Console.WriteLine(ap.IV);
                Console.WriteLine(" ");

                ap.RT = (sb * (0));
                Console.WriteLine("Retiro");
                Console.WriteLine(ap.RT);
                Console.WriteLine(" ");

                ap.CS = (sb *(1.125m));
                Console.WriteLine("Cesantia");
                Console.WriteLine(ap.CS);
                Console.WriteLine(" ");

                ap.IN = (sb * (0));
                Console.WriteLine("Credito Infonavit");
                Console.WriteLine(ap.IN);
                Console.WriteLine(" ");

            }
            else {
                Console.WriteLine("No amigo");
            }
            return ap;
        }


        public static void Presentacion()
        {
            Console.WriteLine("Tipo?");
            Console.WriteLine("PATRON = 1");
            Console.WriteLine("TRABAJADOR = 2");
            int tip = int.Parse(Console.ReadLine());

            Console.WriteLine("Salario BASE");
            decimal sb = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Unidad de Medida de Actualización");
            decimal uma = decimal.Parse(Console.ReadLine());

            Aportaciones aportaciones = new Aportaciones(); 
            aportaciones = Calcular(sb, uma, tip);

        }
    }
}