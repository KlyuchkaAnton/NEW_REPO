Console.WriteLine("Введите количество элементов массива:");

int AmAl = int.Parse(Console.ReadLine()!);

string[] words;

words = new string[AmAl];
//////////////////////////////////////////////////////////////////////////
Console.WriteLine($"Введите {AmAl} элемента массива words");

for  (int i = 0; i < words.Length; i++)
{
    words[i] = Console.ReadLine()!;
}

Console.Write(" words [ ");

for  (int i = 0; i < words.Length; i++)
{
Console.Write($"{words[i]} ");
}
Console.Write("]");
Console.WriteLine();

 //////////////////////////////////////////////////////////////////////////
string[] NS = new string[AmAl];
int length=3;
int count = 0;

foreach  (string i in words)
      
   if ( i.Length > length )
   {
                
   }
   else
   {
    Console.WriteLine(i);
    NS[count] = i;
    count++;  

   }
     Console.Write("NS [");
    foreach ( string ff in NS)
    {
       
        Console.Write($" {ff}");
        
         
    }
    Console.Write("]");

//////////////////////////////////////////////////////////////////////////