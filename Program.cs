string[] CreateArray (int size)
{
    string[] array = new string[size];
    for (int i = 0; i<size; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент массива:");
        array[i]=Console.ReadLine();
    }
    return array;
}

void ShowArray (string[] array)
{
for (int i = 0; i<array.Length; i++)
Console.Write (array[i]+"  ");
Console.WriteLine();
}

int NewArraySize (string[] array)
{
    int newArrayLength = 0;
    for (int i = 0; i<array.Length; i++)
            if (array[i].Length<=3) newArrayLength++; 
    return newArrayLength;
}

string[]FillNewArray (string[] array, int size)
{
 string[] newArray = new string[size];
 int j = 0;
 for (int i=0; i<array.Length; i++)
 {
    if (array[i].Length<=3) 
    {
        newArray[j] = array[i];
        j++;
    }
 }
 return newArray;
}

Console.WriteLine ("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
string[] firstArray = CreateArray (length);
ShowArray (firstArray);
int newArrayLength = NewArraySize (firstArray);
if (newArrayLength>0)
{
string[] secondArray = FillNewArray(firstArray, newArrayLength);
ShowArray(secondArray);
}
else Console.WriteLine ("[ ]");