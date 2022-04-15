using System;
using System.Collections.Generic;

namespace ebob_ekok
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            int num1Gecici = num1;
            int num2Gecici = num2;
            List<int> lst = AsalSayi(num1, num2);

            int ebob = 1;
            int ekok = 1;
            for (int i = 0; i < lst.Count; i++)
            {
                while (num1 % lst[i] == 0 && num2 % lst[i] == 0)
                {
                    if (num1 % lst[i] == 0 && num2 % lst[i] == 0)
                    {
                        ebob *= lst[i];
                        num1 = num1 / lst[i];
                        num2 = num2 / lst[i];
                    }
                }
                
            }
            num1 = num1Gecici;
            num2 = num2Gecici;
            for (int i = 0; i < lst.Count; i++)
            {
                while (num1 % lst[i] == 0 || num2 % lst[i] == 0)
                {
                    ekok *= lst[i];
                    if (num1 % lst[i] == 0 && num2 % lst[i] == 0)
                    {
                        num1 = num1 / lst[i];
                        num2 = num2 / lst[i];
                    }
                    else if(num1 % lst[i] == 0)
                    {
                        num1 = num1 / lst[i];
                    }
                    else if(num2 % lst[i] == 0)
                    {
                        num2 = num2 / lst[i];
                    }
                    else
                    {
                        Console.WriteLine("Hata!!");
                    }
                    
                }
            }


            Console.WriteLine("Ebob:{0},Ekok:{1}",ebob,ekok);
        }

        public static List<int> AsalSayi(int num1,int num2)
        {   
            List<int> list = new List<int>();
            list.Add(2);
            bool flag = false;
            if (num2<num1)
            {
                for (int i = 3; i <= num2; i++)
                {
                    for (int j = 2; j <i; j++)
                    {
                        if (i % j == 0)
                        {   
                           flag = true;
                            break;
                        }
                    }

                    if (flag == false)
                    {
                        if (list.Contains(i)==false)
                        {
                            list.Add(i);
                        }
                        
                    }
                    flag = false;
                }
            }
            else
            {
                for (int i = 3; i <= num1; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag == false)
                    {
                        if (list.Contains(i) == false)
                        {
                            list.Add(i);
                        }

                    }
                    flag = false;
                }
            }

            return list;
        }
    }
}
