/*2.Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N: ");
        int n = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(n);

        Console.WriteLine($"Число {n} после переворота: {reversedNumber}");
    }

    static int ReverseNumber(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number = number / 10;
        }
        return reversed;
    }
}
//3.Для вывода трех любых чисел на экран в одну строку с двумя пробелами между ними, вы можете воспользоваться языком программирования C#
using System;

class Program
{
    static void Main()
    {
        // Задайте три любых числа
        int number1 = 10;
        int number2 = 20;
        int number3 = 30;

        // Выведите их на экран в одну строку с двумя пробелами
        Console.WriteLine($"{number1}  {number2}  {number3}");
    }
}
//4.Вывести на экран числа 5, 10 и 21 одно под другим
Console.WriteLine(5);
Console.WriteLine(10);
Console.WriteLine(21);

//5.Дано расстояние в сантиметрах. Найти число полных метров в нем.

Console.Write("Введите расстояние в сантиметрах: ");
int distanceInCentimeters = int.Parse(Console.ReadLine());

int meters = distanceInCentimeters / 100; // 1 метр = 100 сантиметров

Console.WriteLine($"Число полных метров: {meters}");

//6.С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
int days = 234;
int weeks = days / 7;

Console.WriteLine($"Полных недель прошло: {weeks}");



    /*7.Дано натуральное число.

    a.Верно ли, что сумма его цифр больше 10?

    b. Верно ли, что произведение его цифр меньше 50?

    c. Верно ли, что количество его цифр есть четное число?

    d. Верно ли, что это число четырехзначное? Составное условие и вложенный условный оператор не использовать.

    e. Верно ли, что его первая цифра не превышает 6?

    f. Верно ли, что оно начинается и заканчивается одной и той же цифрой?

    g. Определить, какая из его цифр больше: первая или последняя.
    using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        // a. Верно ли, что сумма его цифр больше 10?
        int sumOfDigitsA = 0;
        int tempNumberA = number;

        while (tempNumberA > 0)
        {
            sumOfDigitsA += tempNumberA % 10;
            tempNumberA /= 10;
        }

        bool conditionA = sumOfDigitsA > 10;

        // b. Верно ли, что произведение его цифр меньше 50?
        int productOfDigitsB = 1;
        int tempNumberB = number;

        while (tempNumberB > 0)
        {
            productOfDigitsB *= tempNumberB % 10;
            tempNumberB /= 10;
        }

        bool conditionB = productOfDigitsB < 50;

        // c. Верно ли, что количество его цифр есть четное число?
        int numberOfDigitsC = 0;
        int tempNumberC = number;

        while (tempNumberC > 0)
        {
            numberOfDigitsC++;
            tempNumberC /= 10;
        }

        bool conditionC = numberOfDigitsC % 2 == 0;

        // d. Верно ли, что это число четырехзначное?
        bool conditionD = number >= 1000 && number <= 9999;

        // e. Верно ли, что его первая цифра не превышает 6?
        int firstDigitE = number % 10;
        bool conditionE = firstDigitE <= 6;

        // f. Верно ли, что оно начинается и заканчивается одной и той же цифрой?
        int lastDigitF = number % 10;
        bool conditionF = firstDigitE == lastDigitF;

        // g. Определить, какая из его цифр больше: первая или последняя.
        int greaterDigit;
        if (firstDigitE > lastDigitF)
        {
            greaterDigit = firstDigitE;
        }
        else if (lastDigitF > firstDigitE)
        {
            greaterDigit = lastDigitF;
        }
        else
        {
            greaterDigit = firstDigitE; // Если цифры равны, можно выбрать любую из них.
        }

        // Вывод результатов
        Console.WriteLine($"a. Сумма цифр больше 10: {conditionA}");
        Console.WriteLine($"b. Произведение цифр меньше 50: {conditionB}");
        Console.WriteLine($"c. Количество цифр четное: {conditionC}");
        Console.WriteLine($"d. Число четырехзначное: {conditionD}");
        Console.WriteLine($"e. Первая цифра не превышает 6: {conditionE}");
        Console.WriteLine($"f. Начинается и заканчивается одной цифрой: {conditionF}");
        Console.WriteLine($"g. Большая цифра: {greaterDigit}");
    }
}

//8.напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18 ... 9 х 9 = 81
using System;

class Program
{
    static void Main()
    {
        int number = 9; // Число, на которое будем умножать

        for (int i = 1; i <= 9; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}
//9.Дано натуральное число. Определить:
a.является ли оно четным;
b.оканчивается ли оно цифрой 7

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        // a. Проверка на четность
        bool isEven = number % 2 == 0;

        // b. Проверка на окончание цифрой 7
        bool endsWithSeven = number % 10 == 7;

        // Вывод результатов
        Console.WriteLine($"Число {number}:");

        if (isEven)
        {
            Console.WriteLine("a. Является четным.");
        }
        else
        {
            Console.WriteLine("a. Не является четным.");
        }

        if (endsWithSeven)
        {
            Console.WriteLine("b. Оканчивается на цифру 7.");
        }
        else
        {
            Console.WriteLine("b. Не оканчивается на цифру 7.");
        }
    }
}
//10.Дано четырехзначное число. Найти:
a.сумму его цифр;
b.произведение его цифр
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        // Разбиение числа на цифры
        int thousands = number / 1000;
        int hundreds = (number % 1000) / 100;
        int tens = (number % 100) / 10;
        int units = number % 10;

        // a. Сумма цифр
        int sumOfDigits = thousands + hundreds + tens + units;

        // b. Произведение цифр
        int productOfDigits = thousands * hundreds * tens * units;

        // Вывод результатов
        Console.WriteLine($"a. Сумма цифр: {sumOfDigits}");
        Console.WriteLine($"b. Произведение цифр: {productOfDigits}");
    }
}
//11.Известны объем и масса тела. Определить плотность материала этого тела.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите массу тела (в килограммах): ");
        double mass = double.Parse(Console.ReadLine());

        Console.Write("Введите объем тела (в кубических метрах): ");
        double volume = double.Parse(Console.ReadLine());

        // Расчет плотности
        double density = mass / volume;

        // Вывод результата
        Console.WriteLine($"Плотность материала тела: {density} кг/м³");
    }
}

//12.Дан радиус окружности. Найти ее диаметр.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());

        // Расчет диаметра
        double diameter = 2 * radius;

        // Вывод результата
        Console.WriteLine($"Диаметр окружности: {diameter}");
    }
}*/

