using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_and_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantity of massives - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] massive = new int[n][];
            for (int i = 0; i < n; i++) 
            {
                Console.Write("Quantity of elements - ");
                int m = Convert.ToInt32(Console.ReadLine());
                massive[i] = new int [m];
                for (int j = 0; j < m; j++) 
                {
                    Console.Write("element - ");
                    massive[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < massive[i].GetUpperBound(0) + 1; j++) 
                {
                    Console.Write(massive[i][j] + "\t");
                }
                Console.WriteLine();
            }
            int[][] result = new int[n + 2][];
            string res = "";
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < massive[i].Length; j++) 
                {
                    int qua = 1;
                    for (int k = 0; k < n; k++) 
                    {
                        if (k != i) 
                        {
                            foreach (int num in massive[k]) 
                            {
                                if (num == massive[i][j]) 
                                {
                                    qua++;
                                }
                            }
                        }
                    }
                    if (qua == n)
                    { res += massive[i][j] + " "; }
                } 
            }
            //Console.WriteLine(res);
            //foreach (string str in res.Split(' ')) 
            //{
            //    Console.WriteLine("___" + str + "_____");
            //    if (str == "") { Console.WriteLine("null"); }
            //}
            result[0] = new int[res.Split(' ').Length-1];
            int a = 0;
            foreach (string str in res.Split(' '))
            {
                if (str != "")
                {result[0][a++] = Convert.ToInt32(str); }
            }
            string st = "";
            for (int i = 0; i < result[0].Length; i++)
            {
                bool tr = true;
                foreach (string s in st.Split(' ')) 
                {
                    if(s != "")
                    {
                        if(result[0][i]  == Convert.ToInt32(s))
                        {
                            tr = false;
                        }
                    }
                }
                if (tr) 
                {
                    st += result[0][i] + " ";
                }
                
            }
            Console.Write(st+"!");
            Console.WriteLine(st.Length);
            string[] res_0 = st.Split(' ');
            foreach (string stri in res_0)
            {
                if (stri != "") 
                { Console.Write(stri + "\t"); }
             }

            Console.ReadKey();
        }
    }
}
