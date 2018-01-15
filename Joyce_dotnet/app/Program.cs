using System;
using System.Collections;
using System.Collections.Generic;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Console.WriteLine("Adiciona no início da lista.");          
            a.Insert(0, "Joyce");
            a.Insert(1, "Weskley");
            a.Insert(2, "Wellington");
            a.Insert(3, "Alberto");
            a.Insert(4, "Márcia");
            a.Insert(5, "William");
            a.Insert(6, "Alex");
            a.Insert(7, "Lucas chatão");
            a.Insert(8, "Lincoln");

            for(int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i]);
            
            ArrayList b = new ArrayList();
            Console.WriteLine("Adiciona no final da lista.");
            b.Add("Joyce");
            b.Add("Weskley");
            b.Add("Wellington");
            b.Add("Alberto");
            b.Add("Márcia");
            b.Add("William");
            b.Add("Alex");
            b.Add("Lucas chatão");
            b.Add("Lincoln");

            for(int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i]);

            Console.WriteLine("Números pares: ");

            ArrayList c = new ArrayList();
            for(int i = 1; i <= 20; i++){
                if(i % 2 == 0)
                    c.Add(i);
            }

            for(int i = 0; i < c.Count; i++)
                Console.WriteLine(c[i]);

            Console.WriteLine("Dicionário: ");
            Dictionary<int, string> dic = new Dictionary<int, string>();
            
            dic.Add(123, "Joyce");
            dic.Add(100098, "Weskley");
            dic.Add(675, "Wellington");
            dic.Add(0987, "Alberto");

            foreach(KeyValuePair<int, string> d in dic )
            {
                Console.WriteLine("Matrícula = {0}, Aluno = {1}", d.Key, d.Value);
            }
        }
    }
}
