// Simple challenges that don't require their own program will be done here.

///*
// * Hello World
// */
//Console.WriteLine("Hello, World!");

///*
// * What Comes Next
// */
//Console.WriteLine("What comes next...");
//Console.WriteLine();

///*
// * Inputs
// */
//Console.WriteLine("What is your name?");
//string name = Console.ReadLine();

//Console.WriteLine("Welcome " + name);
//Console.WriteLine();

///*
// * The Decompiled Gem
// */
//// Define variables
//int a, b , multiply;
//// Assign a + b
//a = 9;
//b = 6;
//// Calculate multiply using a + b
//multiply = a * b;
//// Print results
//Console.WriteLine("The answer is " + multiply);
//Console.WriteLine();

///*
// * Reusing a Variable
// */
//string symbol;
//Console.WriteLine("Enter a symbol: ");
//symbol = Console.ReadLine();

//Console.WriteLine();
//Console.WriteLine(symbol + " " + symbol);
//Console.WriteLine(" " + symbol);
//Console.WriteLine(symbol + " " + symbol);
//Console.WriteLine();

//Console.WriteLine("Enter another symbol: ");
//symbol= Console.ReadLine();

//Console.WriteLine();
//Console.WriteLine(symbol + "." + symbol + ".." + symbol);
//Console.WriteLine();

///*
// * Three Types
// */
//string aString = "This is a string!";
//char aChar = 'A';
//int aInt = 0;

//Console.WriteLine(aString);
//Console.WriteLine("This is a char: " + aChar);
//Console.WriteLine("This is an int: " + aInt);
//Console.WriteLine();

///*
// * Programmers First Crash
// */
//string emergency = "Programmers first crash!";
//Console.WriteLine(emergency[0]);
//Console.WriteLine(emergency[1]);
//Console.WriteLine(emergency[4]);
//Console.WriteLine(emergency[10000]);
//Console.WriteLine();

///*
// * Distraction
// */
//int a, b;
//Console.WriteLine("Please input a number: ");
//a = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input a second number: ");
//b = int.Parse(Console.ReadLine());

//Console.WriteLine(a + " + " + b + " = " + (a+b));

///*
// * Farm Fields
// */
//int length, width;
//Console.WriteLine("Please input the field length: ");
//length = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input the field width: ");
//width = int.Parse(Console.ReadLine());

//Console.WriteLine("The area of the field is: " + length*width);

///*
// * Ditches
// */
//int length, width, t1, t2;
//Console.WriteLine("Please input the field length: ");
//length = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input the field width: ");
//width = int.Parse(Console.ReadLine());

//t1 = width + length / 2 * width;
//t2 = length + width / 2 * length;

//Console.WriteLine("T1: " + t1);
//Console.WriteLine("T2: " + t2);

///*
// * The Dominion of Kings
// */
//int estates, dutchies, provinces, total;
//Console.WriteLine("Please input the amount of Estates you own: ");
//estates = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input the amount of Dutchies you own: ");
//dutchies = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input the amount of Provinces you own: ");
//provinces = int.Parse(Console.ReadLine());

//total = estates + (dutchies * 3) + (provinces * 6);

//Console.WriteLine("Your total worth is: " + total);

///*
// * The Fours Sisters and the Duckbear
// */
//int eggs, sistersEggs, duckbearEggs;
//Console.WriteLine("Please enter how many eggs you have gathered today: ");
//eggs = int.Parse(Console.ReadLine());

//sistersEggs = eggs / 3;
//duckbearEggs = eggs % 3;

//Console.WriteLine("Each sister gets " + sistersEggs + " eggs.");
//Console.WriteLine("The duckbear gets " + duckbearEggs + " eggs.");

///*
// * The Guidestone - Part 1
// */
//double radius, area;
//Console.WriteLine("Please enter the radius of the circle:");
//radius = double.Parse(Console.ReadLine());

//area = Math.PI * (Math.Pow(radius, 2));

//Console.WriteLine("The area of the circle is: " + area);

///*
// * The Guidestone - Part 2
// */
//double x, y, distance;
//Console.WriteLine("Please enter the x co-ordinate distance:");
//x = double.Parse(Console.ReadLine());
//Console.WriteLine("Please enter the y co-ordinate distance:");
//y = double.Parse(Console.ReadLine());

//distance = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));

//Console.WriteLine("The distance between the points is: " + distance);

Console.ReadKey();