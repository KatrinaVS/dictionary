using System;
using System.Collections.Generic;

namespace dictionary
{
    class UserInfo
    {
        public static Dictionary<int, string> MyDic(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string> ();

            Console.WriteLine("Введите название рейса: ");
            string s;
            for (int j = 0; j < i; j++)
            {
                Console.Write("Рейс{0} - ", j);
                s = Console.ReadLine();
                dic.Add(j, s);
               
            }
            return dic;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Сколько будет пересадок? ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Dictionary<int, string> dic = UserInfo.MyDic(i);

                ICollection<int> keys = dic.Keys;
                Console.WriteLine("Ваши пересадки: ");
                foreach (int j in keys)
                    Console.WriteLine("Пересадка № {0} Город - {1}", j, dic[j]);
            }
            catch (FormatException) // обработка исключений
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }


    }


}
