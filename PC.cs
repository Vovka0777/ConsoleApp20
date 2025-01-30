using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp20
{
    internal class Pc
    {
        public string model;
        public double herts_cpu;
        public int amount_ram;
        public int amount_hdd;
        public Pc () { }
        public Pc (string model) { this.model = model; }
        public Pc (string model, double herts_cpu) : this(model) { this.herts_cpu = herts_cpu; }
        public Pc (string model, double herts_cpu, int amount_ram) : this(model,herts_cpu) { this.amount_ram = amount_ram; }
        public Pc (string model, double herts_cpu, int amount_ram, int amount_hdd) : this(model,herts_cpu,amount_ram) 
        { this.amount_hdd = amount_hdd; }

        public void Info()
        {
            Console.WriteLine($"Компьтер, модели {model} имеет: {herts_cpu} Мгц - частоту ЦП " +
                $"{amount_ram} Гбайт - объем ОЗУ {amount_hdd} Гбайт - объем жёстоко диска");
        }
        public override string ToString()
        {
            return $"Компьтер, модели {model} имеет: {herts_cpu} Мгц - частоту ЦП " +
                $"{amount_ram} Гбайт - объем ОЗУ {amount_hdd} Гбайт - объем жёстоко диска";
        }
    }
}
