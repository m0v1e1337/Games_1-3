
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Games_1;

class Games_1
{
    static void dell()
    {
        
        
            Console.WriteLine("Введите число для показания делителей");
            string num = Console.ReadLine();
        while (true)
        {
            try
            {
                int.TryParse(num, out int num_);
                for (int dellit = 1; dellit <= num_; dellit++)
                {
                    if ((num_ % dellit) == 0)
                    {
                        Console.Write(dellit+"\t");
                    }
                }
                Console.WriteLine();
                break;
            }
            catch
            {
                Console.WriteLine("ошибка");
            }
        }
        
    }
    static void num_game()
    {
        Random random = new Random();
        int rando = random.Next(0, 100);
        Console.WriteLine("Игра угадай число");
        Console.WriteLine("Вводите число до того пока не угадаете");
        
        while (true) {
            try
            {   
                string num_ = Console.ReadLine();
                int.TryParse(num_, out int num);
                if (num == rando)
                {
                    Console.WriteLine("Вы выйграли");
                    break;
                }
                else if (num > rando)
                {
                    Console.WriteLine("Введите число меньше");
                    continue;
                }
                else if (num < rando)
                {
                    Console.WriteLine("Введите число больше");
                    continue;
                }

        }
            catch
            {
                Console.WriteLine("Ошибка!");
            } }
    }
    static void tablich_()
    { 
        string[,] tabl = new string[10, 10];
        for (int line=0;line<=10; line++)
        {
            for (int vol = 0; vol<=10; vol++)
            {
                Console.Write(vol + "*"+ line + "="+ (vol*line)+"\t");
            }
            Console.WriteLine();
            
        }
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        while (true)
        {
            try
            { 
                Console.WriteLine("Вас приветствует помошник по играм\n" +
                "Выберите желаемый режим!\n" +
                "1.Таблица умножения\n" +
                "2.Угадай число\n" +
                "3.Делитель числа ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        tablich_();
                        break;
                    case "2":
                        num_game();
                        break;
                    case "3":
                        dell();
                        break;
                }   
            }
            catch
            {
                Console.WriteLine("Ошибка, вы что то ввели не правильно ");
            }
        }
    }
}