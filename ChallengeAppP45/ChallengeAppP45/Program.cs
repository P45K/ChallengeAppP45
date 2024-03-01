// DZIEŃ 5 - ZADANIE DOMOWE

int number = 1357997531;
string numberAsString = number.ToString(); // konwersja zmiennej typu "int" do zmiennej typu "string"
char[] letters = numberAsString.ToArray(); // konwersja zmiennej typu "string" na tablicę znaków "char[]"

Console.WriteLine("Program ma za zadanie obliczyć, ile razy dana cyfra występuje w liczbie" + " " + number);

int digit0 = 0;
int digit1 = 0;
int digit2 = 0;
int digit3 = 0;
int digit4 = 0;
int digit5 = 0;
int digit6 = 0;
int digit7 = 0;
int digit8 = 0;
int digit9 = 0;

foreach (var letter in letters) // pętla "foreach" wykona przejście przez każdy element tablicy "char[]"
{
    if (letter == '0')
    {
        digit0++;
    }
    else if (letter == '1')
    {
        digit1++;
    }
    else if (letter == '2')
    {
        digit2++;  
    }
    else if (letter == '3')
    {
        digit3++; 
    }
    else if (letter == '4')
    {
        digit4++;   
    }
    else if (letter == '5')
    {
        digit5++;   
    }
    else if (letter == '6')
    {
        digit6++;   
    }
    else if (letter == '7')
    {
        digit7++;  
    }
    else if (letter == '8')
    {
        digit8++;  
    }
    else if (letter == '9')
    {
        digit9++;   
    }
}

Console.WriteLine("-----");
Console.WriteLine("0 = " + digit0);
Console.WriteLine("1 = " + digit1);
Console.WriteLine("2 = " + digit2);
Console.WriteLine("3 = " + digit3);
Console.WriteLine("4 = " + digit4);
Console.WriteLine("5 = " + digit5);
Console.WriteLine("6 = " + digit6);
Console.WriteLine("7 = " + digit7);
Console.WriteLine("8 = " + digit8);
Console.WriteLine("9 = " + digit9);
Console.WriteLine("-----");