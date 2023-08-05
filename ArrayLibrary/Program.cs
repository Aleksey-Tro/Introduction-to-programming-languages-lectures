void FillArray(int [] collection)
{
   int length = collection.Length;
   int i = 0;
   while (i < length)
   {
      collection[i] = new Random().Next(1, 10);
      i++;
   }
}
// Заполняет массив int[] array = new int [10]

void PrintArray(int[] col)
{
   int count = col.Length;
   int position = 0;
   while (position < count)
   {
      Console.WriteLine(col[position]);
      position++;
   }
}
// Выводит в терминал массив int[] array = new int [10]

int IndexOff(int[] collection, int find)
{
   int count = collection.Length;
   int i = 0;
   int position = -1;
   while (i < count)
   {
      if(collection[i] == find)
      {
         position = i;
         break;
      }
   }
   return position;
}
//Находит индекс нужного значения в массиве int[] array = new int [10];

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 4);
Console.WriteLine(pos);
