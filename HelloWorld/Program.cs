// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет от ИСП-243");
Console.WriteLine("Автор: Торяник Кирилл");
Console.WriteLine("Год: 2026");

int age = 20;
double gpa = 4.5;
bool isStudent = true;
string name = "Кирилл";

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(gpa);
Console.WriteLine(isStudent);

var city = "Москва";
var year = 2026;
var pi = 3.123123412;
var isActive = true;

Console.WriteLine($"Меня зовут {city}, мне {year} лет, я учусь в группе {pi}");

Console.Write("Введите ваше имя: ");
string name2 = Console.ReadLine();
Console.WriteLine($"Привет {name2}");