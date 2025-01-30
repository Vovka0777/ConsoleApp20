using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pc pc1 = new Pc();
            pc1.Info();
            Console.WriteLine();
            pc1.model = "Gaming";
            pc1.herts_cpu = 4.2;
            pc1.amount_ram = 16;
            pc1.amount_hdd = 960;
            pc1.Info();
            Console.WriteLine();
            Pc pc2 = new Pc("Office");
            pc2.Info();
            pc2.herts_cpu = 3.3;
            pc2.amount_ram = 8;
            pc2.amount_hdd = 543;
            pc2.Info();
            Console.WriteLine();
            Pc pc3 = new Pc("Office", 4.2);
            pc3.Info();
            pc3.amount_ram = 8;
            pc3.amount_hdd = 543;
            pc3.Info();
            Console.WriteLine();
            Pc pc4 = new Pc("Office", 4.2, 8);
            pc4.Info();
            pc4.amount_hdd = 543;
            pc4.Info();
            Console.WriteLine();
            Pc pc5 = new Pc("Office", 4.2, 8, 543);
            pc5.Info();
            Console.WriteLine();
            Console.WriteLine($"{pc5.ToString()}");
            Console.Write("Модель ПК - ");
            string model = Console.ReadLine();
            Console.Write("Частота ЦП - ");
            double herts_cpu = double.Parse(Console.ReadLine());
            Console.Write("Объём ОЗУ - ");
            int amount_ram = int.Parse(Console.ReadLine());
            Console.Write("Объём жёсткого диска - ");
            int amount_hdd = int.Parse(Console.ReadLine());
            Pc pc6 = new Pc(model, herts_cpu, amount_ram, amount_hdd);
            Console.WriteLine($"{pc6.ToString()}");
            Console.Read();
        }
    }
}
