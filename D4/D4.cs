// See https://aka.ms/new-console-template for more information

/* E53 1

int[] Numbers = { 2, 4, 7, 8, 6 };
bool Test = false;

foreach (int Num in Numbers)
{
    if (Num % 2 != 0)
    {
        Test = true;
    }
}

Console.WriteLine($"Original array {string.Join(", ", Numbers)}");
Console.WriteLine($"Check if an array contains an odd number? {Test}");
*/

/* E54 2?

Console.WriteLine("Please enter the year:");
double Year = Convert.ToInt32(Console.ReadLine());
int Cen = Convert.ToInt32(Math.Floor(Year / 100) + 1);

Console.WriteLine($"It is the {Cen} century.");
*/

/* E55 3

int[] Ar1 = { 2, 4, 2, 6, 9, 3 };
int[] Ar2 = { 0, -1, -1, -2 };
int[] Ar3 = { 6, 1, 12, 3, 1, 4 };
int[] Ar4 = { 1, 4, 3, 0 };

Console.WriteLine(testArray(Ar1) == 27);
Console.WriteLine(testArray(Ar2) == 2);
Console.WriteLine(testArray(Ar3) == 36);
Console.WriteLine(testArray(Ar4) == 16);

static int testArray(int[] inputAr)
{
    int inArray = 0;
    int Product = inputAr[inArray] + inputAr[inArray + 1];

    
    while (inArray+1 < inputAr.Length)
    {
        Product = ((inputAr[inArray] * inputAr[inArray + 1] > Product) ? inputAr[inArray] * inputAr[inArray + 1] : Product);
        inArray++;
    }

    return Product;
}
*/

/* E56 ***4***

Console.WriteLine("Please enter sentece:");
string Sen = (Console.ReadLine());
int Len = Sen.Length;
int Mid = Convert.ToInt32(Len / 2);

char[] rev = Convert.ToChar(Sen.Substring(Mid + 1));
string Second =rev.Reverse();
string First = Sen.Substring(0, Mid);
char[] rev = Convert.ToChar(Second);


Console.WriteLine(First);
Console.WriteLine(Second);
Console.WriteLine($"Is this a Pallendrome? {First == Second.Reverse()}");
*/

/* E57* 5
int[] Ar1 = { 1, -3, 4, -5, 1 };
int[] Ar2 = { 1, 3, 4, 5, 2 };
int[] Ar3 = { 1, 3, -4, 5, 2 };
int[] Ar4 = { 1, 0, -4, 0, 2 };

Console.WriteLine(testArray(Ar1));
Console.WriteLine(testArray(Ar2));
Console.WriteLine(testArray(Ar3));
Console.WriteLine(testArray(Ar4));

static int testArray(int[] inputAr)
{
    int inArray = 0;
    int Product = inputAr[inArray] * inputAr[inArray + 1];


    while (inArray + 1 < inputAr.Length)
    {
        Product = Math.Max(Product, inputAr[inArray] * inputAr[inArray + 1]);// > Product) ? inputAr[inArray] * inputAr[inArray + 1] : Product);
        inArray++;
    }

    return Product;
}

*/

// E58 6*
























































































































































































Console.ReadKey();