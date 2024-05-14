using System.Text;

string name = "Tom";
int age = 33;
bool isEmployed = false;
double weight = 78.65;
 bool isGay = true;
double height = 176;
 






Console.WriteLine($"Имя: {name}"); // consolewrite если тогда след вывод будет на этой же строке
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Работает: {isEmployed}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Гей: {isGay}");
Console.WriteLine("Рекомендация");
if (isEmployed == false)
    Console.WriteLine("Find Job");


Console.WriteLine($"Имя: {name} Возраст: {age}года Вес: {weight}кг");
Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}", name, height, age);
