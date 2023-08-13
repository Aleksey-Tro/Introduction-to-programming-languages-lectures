// // Вид 1
// void Method1()
// {
//    Console.WriteLine("Автор...");
// }
// // Вызов метода
// Method1();


// // Вид 2
// void Method2(string msg)
// {
//    Console.WriteLine(msg);
// }
// // Вызов метода
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//    int i = 0;
//    while (i < count)
//    {
//       Console.WriteLine(msg);
//       i++;
//    }
// }
// // Именнованные аргументы не обязательно 
// // писать по порядку, если прописывать их имя
// Method21("Текст", 4);
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Текст");


// Вид 3
// int Method3()
// {
//    return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// // Вид 4
// string Method4(int count, string text)
// {
//    int i = 0;
//    string result = string.Empty;

//    while (i < count)
//    {
//       result = result + text;
//       i++;
//    }
//    return result;
// }

// string res = Method4(10, "flat");
// Console.WriteLine(res);


// string Method4(int count, string text)
// {
//    string result = string.Empty;
//    for(int i = 0; i < 10; i++)
//    {
//       result = result + text;
//    }
//    return result;
// }

// string res = Method4(10, "Polina fat, ");
// Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
   for (int j = 2; j <= 10; i++)
   {
      Console.WriteLine($"{i} x {j} = {i * j}");
   }
   Console.WriteLine();
}
