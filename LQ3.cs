//LQ3 Дан набор строк. Найти все строки, в которых ни одна буква не повторяется больше 2 раз.

using System;
using System.Collections.Generic;
using System.Linq;

public class Line
{public string Text { get; set; }}

public class LineChecker
{
    //Проводим итерации по каждой строке и проверяем кол-во каждой буквы слова по словарю.
    public IEnumerable<Line> FindLinesWithNoLetterRepeatedMoreThanTwice(IEnumerable<Line> lines)
    {
        var result = new List<Line>();

        foreach (var line in lines)
        {
            var charCount = new Dictionary<char, int>();

            foreach (var c in line.Text)
            {
                if (charCount.ContainsKey(c)) charCount[c]++;
                else charCount[c] = 1;
            }
            //Если буква не имеет счетчика больше 2(т.е соответствует условию), включаем её в результат.
            if (charCount.Values.All(count => count <= 2)) result.Add(line);
        }

        return result;
    }
}

public class LQ3
{
    public static void Main(string[] args)
    { //Создаем объекты для проверки роботоспособности программы
        var lines = new[]
        {
            new Line { Text = "тест номер один" },
            new Line { Text = "саспенс "},
            new Line { Text = "панорама" },
            new Line { Text = "тест последний" },
        };

        var lineChecker = new LineChecker();
        var result = lineChecker.FindLinesWithNoLetterRepeatedMoreThanTwice(lines);

        Console.WriteLine("строки, в которых ни одна буква не повторяется больше 2 раз:");
        foreach (var line in result)
        {
            Console.WriteLine(line.Text);
        }
    }
}
