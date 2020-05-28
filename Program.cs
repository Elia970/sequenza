using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cesaretti.elia._3j.sequenza
{
    class Program
    {
        static void Main(string[] args)
        {
            string riga;
            int c=0,conts=0,crig=0;
            Console.WriteLine("Programma cerca una sequenza di Elia Cesaretti");
            StreamReader File = new StreamReader("se.txt");
            while (!File.EndOfStream)
            {
                crig++;
                switch (riga = File.ReadLine())
                {
                    case "1":
                        if (riga == "1")
                        {
                            c = 2;
                        }
                        break;
                    case "2":
                        if (riga == "2")
                        {
                            c = 3;
                        }
                        else
                        {
                            c = 1;
                        }
                        break;
                    case "3":
                        if (riga == "3")
                        {
                            c = 4;
                            conts++;
                            Console.WriteLine("La riga dove inizia la sequenza è: " + (crig-2));                       
                        }
                        else
                        {
                            c = 1;
                        }
                        break;
                    case "4":
                        if (riga == "1")
                        {
                            c = 2;
                        }
                        else
                        {
                            c = 1;
                        }
                        break;
                }
            }
            Console.WriteLine("Sequenze Trovate " + conts);
            Console.ReadLine();
        }
    }
}