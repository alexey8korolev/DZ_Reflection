using Reflection.Logic;
using Reflection.Sample;
using Reflection.Utils;


Console.WriteLine("Нажмите любую клавишу для запуска  REFLECTION...");
Console.ReadLine();

var f_obj = new F() { i1 = 1, i2 = 2, i3 = 3, i4 = 4, i5 = 5 };

Console.WriteLine("[1.Запуск] CSV сериализации");

string csvString = string.Empty;

Stopwatch.Start();
for (var i = 0; i < 1000; i++)
{
    csvString = CsvConvert.SerializeObject<F>(f_obj);
}
Stopwatch.Stop();

var deltaTime = Stopwatch.TimeInterval;

Stopwatch.Start();
Console.WriteLine($"[3.Закончена] CSV сериализации 1000 раз. Время сериализации : {deltaTime}");
Console.WriteLine($"[4.CSV] полученная строка : \n{csvString}");
Stopwatch.Stop();
Console.WriteLine($"[6.] Время вывода текста в консоль : {Stopwatch.TimeInterval}");

Stopwatch.Start();
var obj = CsvConvert.DeserializeObject<F>(csvString);
Stopwatch.Stop();

Console.WriteLine($"[9.Десериализация] CSV в экземпляр класса: {obj}. Время десериализации : {Stopwatch.TimeInterval}");


// JSON сериализации
Console.WriteLine("------------  JSON --------");

Console.WriteLine("[7.Запуск] JSON сериализации");

string jsonString = string.Empty;

Stopwatch.Start();
for (var i = 0; i < 1000; i++)
{
   jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(f_obj);
}
Stopwatch.Stop();

deltaTime = Stopwatch.TimeInterval;

Stopwatch.Start();
Console.WriteLine($"[7.] JSON сериализации 1000раз. Время сериализации : {deltaTime}");
Console.WriteLine($"[7.JSON] Строка : \n{jsonString}");
Stopwatch.Stop();
Console.WriteLine($"[7.Окончание] Время вывода текста в консоль  : {Stopwatch.TimeInterval}");

Stopwatch.Start();
obj = Newtonsoft.Json.JsonConvert.DeserializeObject<F>(jsonString);
Stopwatch.Stop();

Console.WriteLine($"[7.Десериализация] JSON в экземпляр класса: {obj}. Время десериализации : {Stopwatch.TimeInterval}");

Console.WriteLine("Успешное Окончание!!!");
Console.ReadKey();

