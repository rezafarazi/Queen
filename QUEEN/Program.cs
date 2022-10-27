using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEEN
{
    class Program
    {

        //Variable For All Elements
        public static string[,] All;
        public static int Q_Counter=0;

        //Main Function Start
        static void Main(string[] args)
        {
            Console.Write("Enter Elements Number :  ");
            int All_Elements_Count = int.Parse(Console.ReadLine());
            All = new string[All_Elements_Count,All_Elements_Count];
            Generate_Element(All_Elements_Count);



            //Print All Elements Start
            Console.WriteLine();
            for (int i = 0; i < All_Elements_Count; i++)
            {
                for (int j = 0; j < All_Elements_Count; j++)
                {
                    Console.Write(All[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
            //Print All Elements End


            Console.ReadKey();
        }
        //Main Function End

        //Generate Function Start
        public static void Generate_Element(int Count)
        {

            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    All[i, j] = "0";
                }
            }



            //Fill All Elemtnts Start
            for (int S = 0; S < Count; S++)
            {
                if (Q_Counter == Count)
                {
                    break;
                }
                else
                {
                    Clear(Count);
                    All[S, 0] = "Q";
                }

                for (int i = 0; i < Count; i++)
                {
                    for (int j = 0; j < Count; j++)
                    {
                        if (Check_Element(i, j))
                        {
                            All[i, j] = "Q";
                            Q_Counter++;
                            break;   
                        }
                    }
                }
            }
            //Fill All Elemtnts End



        }
        //Generate Function End

        //Check Element Function Start
        public static bool Check_Element(int a,int b)
        {

            int DEEP = int.Parse((All.Length / Math.Sqrt(All.Length)).ToString());

            bool output = true;

            for (int i = 0; i < DEEP; i++)
            {
                if(All[a,i]=="Q")
                {
                    output = false;
                    break;
                }

                if (All[i, b] == "Q")
                {
                    output = false;
                    break;
                }
            }


            
            for(;(a != 0 && b != 0) ;)
            {
                if (All[a, b] == "Q")
                {
                    output = false;
                    break;
                }
                a--;
                b--;   
            }



            for (; (a != DEEP && b != DEEP);)
            {
                if (All[a, b] == "Q")
                {
                    output = false;
                    break;
                }
                a++;
                b++;
            }
            

            return output;

        }
        //Check Element Function End

        //Clear All Function Start
        public static void Clear(int Count)
        {
            Q_Counter = 0;
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    All[i, j] = "0";   
                }
            }
        }
        //Clear All Function End


    }
}
