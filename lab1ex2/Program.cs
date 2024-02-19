/*Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura*/

Console.WriteLine("Introduceti nr1");
int nr1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti nr2");
int nr2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti nr3");
int nr3 = Convert.ToInt32(Console.ReadLine());

int Suma=nr1 + nr2 + nr3;
int Media = Suma / 3;
Console.WriteLine("Media aritmetica este:"+Media);