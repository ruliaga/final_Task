Console.Clear();
Console.WriteLine("Введите через пробел элементы массива строк:");
string phrase =Console.ReadLine();
string[] startArray=phrase.Split(' ');

void PrintArray (string[] array){
Console.Write("[");
foreach (var word in array){
Console.Write($"'{word}' ");}
}
PrintArray(startArray);
Console.Write("] -> ");
PrintArray(NewArray(startArray));
Console.Write("]");


string[]  NewArray (string[] strings){
   

int sum=0;
for (int i=0; i<strings.Length;i++){
    if (strings[i].Length<=3){sum=sum+1;}    
}
int j=0;
string [] newArray = new string[sum];
    for (int i=0; i<strings.Length;i++){
        if (strings[i].Length<=3){
            newArray[j]=strings[i];
            j++;
        }
}
return newArray;
}

