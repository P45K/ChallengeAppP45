// liczby całkowite
int myAge = 120;
int newAge = myAge + 5;
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
ulong myVar3 = ulong.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;

// zmienne tekstowe
string name = "Przemek";
string surname = "Kotłubaj";
string result = name + surname + myAge;
// Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name.ToArray();

// zmienna logiczna
bool isActive = true; // zmienna bool, to są dwie wartości logiczne - true, false
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);