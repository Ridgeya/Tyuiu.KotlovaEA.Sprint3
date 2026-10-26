using Tyuiu.KotlovaEA.Sprint3.Task7.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Котлова Е.А. | АСОиУБ-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Табулирование функции                                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Котлова Елизавета Алексеевна | АСОиУБ-26-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        double[] valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |   f(x)   |");
        Console.WriteLine("+----------+----------+");
FHG
        for (int i = 0; i < valueArray.Length; i++)
        {
            Console.WriteLine("| {0,5:d}    | {1,6:f2}   |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+----------+----------+");

        Console.ReadKey();
    }
}