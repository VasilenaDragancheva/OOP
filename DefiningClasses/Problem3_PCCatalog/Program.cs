using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_PCCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Component screen = new Component("screen", 200);
            Component keyboard = new Component("keyboard", 40);
            Component mouse = new Component("mouse", 20);
            Component motherboard = new Component("motherboard", "ASUS MAXIMUS VII IMPACT/1150", 540);
            Component HDD = new Component("HDD", " Toshiba 2TB 64MB 7200rpm SATA3 DT01ACA200", 150);
            Component proccesor = new Component("processor", "Intel Xeon (3.00GHz, 2M Cache)", 200);
            Computer full = new Computer("МyPC", motherboard, proccesor, HDD, new Component("ram", 150), screen, mouse, keyboard);
            Computer less = new Computer("MPC", motherboard, proccesor, HDD, new Component("ram", 220),screen);
            Computer less1 = new Computer("PC", motherboard, proccesor, HDD, new Component("Ram", 120));
            Computer[] pcs = { full, less, less1 };

            pcs=pcs.OrderBy(pc => pc.Price).ToArray();

            foreach (Computer pc in pcs)
            {
                Console.WriteLine(pc.ToString());
            }

        }
    }
}
