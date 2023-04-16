// программа, уоторая принимает на вход цифру, щбозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите число: ");
  int number = int.Parse(Console.ReadLine());
  if ( number == 6 || number ==7 )
  {
    System.Console.WriteLine("Этот день выходной!");
  }
  else
  {
    if ( number >0 && number < 8 )
    {
        System.Console.WriteLine("Это будний день");
    }
    else
    {
        System.Console.WriteLine("Введно не корректное число. Ведите цифру от 1 до 7");
    }
  }
