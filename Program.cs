Console.Clear();
Console.WriteLine("Введите через пробел элементы массива строк:");
string phrase =Console.ReadLine();
string[] strings=phrase.Split(' ');

void PrintArray (string[] array){
Console.Write("[");
foreach (var word in array){
Console.Write($"'{word}' ");}
}
PrintArray(strings);
Console.Write("] -> ");
PrintArray(NewArray(strings));
Console.Write("]");

string [] NewArray (string[] strings){
   
Random rnd=new Random();
string [] newArray = new string[rnd.Next(0,3)];
for (int i=0; i<newArray.Length;i++){
    newArray[i]=strings[rnd.Next(0,strings.Length)];
}
return newArray;
}

