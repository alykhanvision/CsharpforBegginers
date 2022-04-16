using System;
using System.Text;

namespace Urok_App_2
{
    class Program
    {
        static void Main(string[] args)
        {
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      /*byte age = 13;


      //Операторами if/else if/else можем задать программе какую часть кода впыолнять при выполнении той или иной условии
      if (age >= 18)//if - выражение, всй что внутри скобки условие
      {
        Console.WriteLine("Вам уже можно работать");
      }
      else if (age >= 14&&age<=18)
      {
        Console.WriteLine("Вам уже можно работать но лучше учиться");
      }
      else
      {
        Console.WriteLine("Вам лучше еще учиться");
      }



      string productCategory = "alcohol";
      switch (productCategory)
      {
        case "alcohol" when age >= 14 && age<18:
          Console.WriteLine("Вам еще недостаточно лет");
          break;

        case "alcohol" when age >= 18:
        case "milk":
          Console.WriteLine("Всего доброго");
          break;

        default:
          Console.WriteLine("Не хотели вы конфет");
          break;    //Оператор default нужен если мы хотим обработку ситуации по умолчанию
      }

      //Операторы цикла if/else if/else и switch*/


      /*for(int i=0;i<10;i++) //Это цикл счетчик, работает за счет того что итерирует(перебирает)
                            //какое то значение где инициализация перемнной int i=0, 10 колво итерации,
                            //i<10 прверка условия, i++  - увеличение значения на единичку
                            //
      {
        for(int j = 0; j < 10; j++)
        {
          Console.Write("[ ]");
        }
        Console.WriteLine();
      }*/


      /*
      bool isBoiled = false;
      int timer = 0;
      while (!isBoiled)//while - цикл с предусловием, внутри скобки пишем условие,
                       //внутри тела пишем код который должен впыплнятся в каждом итерации цикла
                       //break - прерывание, и выход из цикла, continue - пропустить итерацию
      {
       //
        Console.Write("[]");
        if (timer == 20)
        {
          break;
        }
        if (timer == 100)
        {
          isBoiled = true;
        }
        timer++;
        if (timer > 10)
        {
          Console.Write("[x]");
          continue;
        }
      }
      Console.WriteLine();

      if (isBoiled)
      {
        Console.WriteLine("вода вскипела");
      }*/

      //Console.WriteLine("Введите число от 1 до 10");
      //string answer = Console.ReadLine();
      //bool succes = int.TryParse(answer, out int value); //Результат этого метода это булево значение

      //if(value>=1&&value<=10)
      //{
      //  Console.WriteLine("Вы ввели " + value);
      //}


      //bool success = false;
      //Console.WriteLine("Введите число от 1 до 10");
      //do
      //{
      //  string answer = Console.ReadLine();
      //  success = int.TryParse(answer, out int value);

      //  if (value >= 1 && value <= 10)
      //  {
      //    Console.WriteLine("Вы ввели " + value);
      //  }

      //  if (!success)
      //  {
      //    Console.WriteLine("Вы ввели не число");
      //  }

      //} while (!success);


      

      //string[] names = new string[7];  //new - связан с ссылочными типами, позволяет ссылочному
      //                                  //типу данных воссоздаться/инициализироваться.в квадратные
      //                                  //скобки мы записываем размер
      //                                  //String обьявляет строчный массив в 
      //names[0] = "Ivan";
      //names[1] = "Maks";
      //names[2] = "Alexey";
      //names[3] = "Pasha";
      //names[4] = "Denis";

      //Console.WriteLine("Введите ваше имя:");
      //names[5] = Console.ReadLine();//Пользователь вводит очередной элемент массива
      //                              //в данном случае 5 элемент.

      //for (int i = 0; i < names.Length; i++) //names.Length позволяет получить длинну массива
      //{
      //  Console.WriteLine(names[i]);
      //}

      int[] numbers = new int[9];
      Random random = new Random();

      for(int i = 0; i < numbers.Length; i++)
      {
        numbers[i] = random.Next();//Позволяет заполнить численный массив рандомными знаяениями
      }
      for(int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine(numbers[i]);
      }


      //numbers[0] = 1;
      //numbers[1] = 56;
      //numbers[2] = 44;
      //numbers[3] = 23;
      //numbers[4] = 25;
      //numbers[5] = 0;
      //numbers[6] = 87;
      //numbers[7] = 99;
      //numbers[8] = 9009;



    }
  }
}
