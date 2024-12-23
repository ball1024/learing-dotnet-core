// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Ball!");
// Console.WriteLine("Test C# ");
// Console.WriteLine("JAC\tVA \nsadasdasd");


// int x = 10;
// double y = 14.14;
// String name = "Game";

// Console.WriteLine("x = {0}, {1}", x, y);
// Console.WriteLine("Name : {0}", name);


// int a = 5;
// int b = 10;

// Console.WriteLine(a + b);
// Console.WriteLine(a - b);
// Console.WriteLine(a * b);
// Console.WriteLine(a / b);
// Console.WriteLine(a % b);

// int x = 3;
// Console.WriteLine(++x);
// Console.WriteLine(x);
// Console.WriteLine(x--);
// Console.WriteLine(x);

// if else

//int x = 10;
// if (x == 3)
//     Console.WriteLine("x is 3");
// else if (x == 10)
//     Console.WriteLine("x is 10");
// else
//     Console.WriteLine("x is {0}", x);

// switch (x)
// {
//     case 7:
//         Console.WriteLine("x = 7");
//         break;
//     default:
//         Console.WriteLine("default");
//         break;
// }

// loop
// for (int i = 0; i < 5; i++)
// {
//     Console.Write("{0} ", i);
// }

// int x = 0;

// while (x < 10)
// {
//     Console.WriteLine(x);
//     x++;
// }
// int x = 10;
// do
// {
//     Console.WriteLine(x);
//     x++;
// } while (x < 20);

// arry
int[] items = [1, 4, 5, 66, 77, 200];
// Console.WriteLine("items 2 = {0}", items[2 - 1]);

// for (int i = 0; i < items.Length; i++)
// {
//     Console.WriteLine("items = {0}", items[i]);
// }

foreach (var item in items)
{
    Console.WriteLine(item);
}