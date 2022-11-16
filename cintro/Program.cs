
#region Task 1
Console.WriteLine("1) Ededin 2-nin quvveti olub olmadigini tapan alqoritm");
Console.Write("Eded: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num % 2 == 0)
{
    num = num / 2;
}
if (num == 1)
{
    Console.WriteLine("2-nin quvvetidir");
}
else
{
    Console.WriteLine("2-nin quvveti deyil");
}
#endregion


#region Task 2
Console.WriteLine("\n2) Verilen 2 eded arasindaki ededleri ekrana yazdiran alqoritm");
Console.Write("Ilk eded: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ikinci eded: ");
int num2 = Convert.ToInt32(Console.ReadLine());

for (int i = num1 + 1; i < num2; i++)
{
    Console.WriteLine(i);
}
#endregion


#region Task 3
Console.WriteLine("\n3) Verilen eded 70-den boyukdurse, 70-le arasindaki ferqin 3 qatini ekrana yazdiran, eger kicikdirse ferqin ozunu ekrana yazdiran alqoritm");
Console.Write("Eded: ");
int eded = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (eded > 70)
{
    result = (eded - 70) * 3;
    Console.WriteLine(result);
}
else if (eded < 70)
{
    result = 70 - eded;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("70e beraberdir");
}
#endregion


#region Task 4
Console.WriteLine("\n4) X, Y, Z ededlerinden hansinin boyuk oldugunu ekrana yazdiran alqoritm");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z = Convert.ToInt32(Console.ReadLine());

if (x > y && x > z)
{
    Console.WriteLine("X boyukdur");
}
else if (y > z)
{
    Console.WriteLine("Y boyukdur");
}
else
{
    Console.WriteLine("Z boyukdur");
}
#endregion


#region Task 5
Console.WriteLine("\n5) n ve m (n < m) ededleri arasinda neche tek eded oldugunu tapan alqoritm");
Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("m: ");
int m = Convert.ToInt32(Console.ReadLine());
int tek = 0;
for (int i = n + 1; i < m; i++)
{
    if (i % 2 != 0)
    {
        tek++;
    }
}
Console.WriteLine(tek + " tek eded var"); 
#endregion