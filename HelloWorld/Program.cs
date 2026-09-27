// // // Console.WriteLine("Привет от ИСП-243");
// // // Console.WriteLine("Автор: Торяник Кирилл");
// // // Console.WriteLine("Год: 2026");

// // // int age = 20;
// // // double gpa = 4.5;
// // // bool isStudent = true;
// // // string name = "Иван";

// // // Console.WriteLine(name);
// // // Console.WriteLine(age);
// // // Console.WriteLine(gpa);
// // // Console.WriteLine(isStudent);

// // // var city = "Москва";
// // // var year = 2026;
// // // var pi = 3.1415;
// // // var isActive = true;

// // // string myName = "Кирилл";
// // // int myAge = 18;
// // // string myGroup = "Исп -243";

// // // Console.WriteLine($"Меня зовут{myName}, мне {myAge} лет, я учусь в группе {myGroup}.");

// // // Console.Write("Введите ваше имя: ");
// // // string name2 = Console.ReadLine();
// // // Console.WriteLine($"Привет, {name2}!");

// // // Console.Write("Введите ваш возраст: ");
// // // string input = Console.ReadLine();
// // // int age2 = int.Parse(input);
// // // Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");

// // // int x = 10;
// // // int y = 3;
// // // Console.WriteLine(x + y); // 13
// // // Console.WriteLine(x - y); // 7
// // // Console.WriteLine(x * y); // 30
// // // Console.WriteLine(x / y); // 3
// // // Console.WriteLine(x % y); // 1

// // using System.Data;

// // string firstName = "Кирилл";
// // string lastName = "Торяник";
// // string group = "ИСП-243";
// // int birthYear = 2008;
// // double gpa = 4.5;
// // bool hasScholArship = true;
// // int currentYear = 2026;
// // int age = currentYear - birthYear;

// // Console.WriteLine("Студенческое удостоверение");
// // Console.WriteLine($"Имя: {firstName} {lastName}");
// // Console.WriteLine($"Группа: {group}");
// // Console.WriteLine($"Возраст: {age} лет");
// // Console.WriteLine($"Средний балл: {gpa}");
// // Console.WriteLine($"Стипендия: {hasScholArship}");

// // Console.Write("\nВведите ваш любимый предмет: ");
// // string subject = Console.ReadLine();
// // Console.WriteLine($"Отлично! {firstName} любит {subject}.");

// int a = 15;
// int b = 4;
// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Разность: {a - b}");
// Console.WriteLine($"Произведение: {a * b }");
// Console.WriteLine($"Частное(int):  {a / b}");
// Console.WriteLine($"Остаток: {a % b}");

// double result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");

// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10, 25));
// Console.WriteLine(Math.Min(10, 25));
// Console.WriteLine(Math.Round(3.567, 2));

// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");
// if (num2 != 0)
//     Console.WriteLine($"Частное: {num1 / num2}");
// else
//     Console.WriteLine("Деление на ноль невозможно!");

// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue);
// Console.WriteLine(double.MaxValue);
// Console.WriteLine(double.MinValue);


Console.WriteLine("Добро пожаловать в анкету!");
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();
Console.Write("Введите ваш год рождения: ");
int bithYear = int.Parse(Console.ReadLine());
Console.Write("Введите ваш средний балл например (4,5): ");
double gpa = double.Parse(Console.ReadLine());

int currentYear = 2026;
int age = currentYear - bithYear;
bool isExcellent = gpa >= 4.5;
string status;
if (isExcellent == true) status = "Отличник";
else status = "Хорошист";

Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя:             {name} {surname}");
Console.WriteLine($"Группа:          {group}");
Console.WriteLine($"Возраст:         {age} лет");
Console.WriteLine($"Средний балл:    {gpa}");
Console.WriteLine($"Статус:          {status}");
Console.WriteLine($"Лет до 30:       {30 - age}");
Console.WriteLine("Нажми Enter для выхода...");
Console.ReadLine();