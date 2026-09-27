// Console.WriteLine("Привет от ИСП-243");
// Console.WriteLine("Автор: Торяник Кирилл");
// Console.WriteLine("Год: 2026");

// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Иван";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);

// var city = "Москва";
// var year = 2026;
// var pi = 3.1415;
// var isActive = true;

// string myName = "Кирилл";
// int myAge = 18;
// string myGroup = "Исп -243";

// Console.WriteLine($"Меня зовут{myName}, мне {myAge} лет, я учусь в группе {myGroup}.");

// Console.Write("Введите ваше имя: ");
// string name2 = Console.ReadLine();
// Console.WriteLine($"Привет, {name2}!");

// Console.Write("Введите ваш возраст: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");

// int x = 10;
// int y = 3;
// Console.WriteLine(x + y); // 13
// Console.WriteLine(x - y); // 7
// Console.WriteLine(x * y); // 30
// Console.WriteLine(x / y); // 3
// Console.WriteLine(x % y); // 1

using System.Data;

string firstName = "Кирилл";
string lastName = "Торяник";
string group = "ИСП-243";
int birthYear = 2008;
double gpa = 4.5;
bool hasScholArship = true;
int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholArship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {firstName} любит {subject}.");

