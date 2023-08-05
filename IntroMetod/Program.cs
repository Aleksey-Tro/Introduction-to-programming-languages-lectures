int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if(arg2 > result) result = arg2;
   if(arg3 > result) result = arg3;
   return result;
}

int a1 = 1;
int a2 = 2;
int a3 = 3;
int a4 = 4;
int a5 = 5;
int a6 = 6;
int a7 = 157;
int a8 = 8;
int a9 = 7;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(a4, a5, a6);
// int max3 = Max(a7, a8, a9);
// int max = Max(max1, max2, max3);

int max = Max(
   Max(a1, a2, a3),
   Max(a4, a5, a6),
   Max(a7,a8,a9));

Console.WriteLine(max);
