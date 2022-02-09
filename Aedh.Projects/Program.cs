// See https://aka.ms/new-console-template for more information
using System;
using Aedh.Projects;
{


    Person pawel = new Person();
    pawel.FirstName = "Pawel";
    pawel.LastName = "Kordel";
    pawel.age = 40;


    Person marfa = new Person();
    marfa.FirstName = "Marta";
    marfa.LastName = "Czop";
    marfa.age = 22;

    Person bobo = new Person();
    bobo.FirstName = "Bolek";
    bobo.LastName = "Fryc";
    bobo.age = 50;

    Person[] osoby = new Person[] { pawel, marfa, bobo };


    foreach (Person os in osoby)
    {
        os.Introduce();
    }


    var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
    string list = string.Join(", ", numbers);

    foreach (int i in numbers)
    {
        Console.Write(i + ", ");
    }

    Console.WriteLine(list);

    string pav = "Pawel";

    char firstLetter = pav[3];

    Console.WriteLine(firstLetter);

    var names = new string[3] { "John", "Mary", "Jack" };
    var formatedNames = string.Join(".", names);
    Console.WriteLine(formatedNames);

    var text = @"HI John
Look into the following paths:
c:\folder1\folder2
c:\folder3\folder4";
    Console.WriteLine(text);



    Console.WriteLine("Podaj dowolną liczbę od 1 do 10");
    int x;
    x = Convert.ToInt32(Console.ReadLine());


    if (x > 0 && x <= 10)
        Console.WriteLine("Poprawna liczba");

    ;
    while (!(x > 0 && x <= 10))
    {
        Console.WriteLine("Zła liczba");
        x = Convert.ToInt32(Console.ReadLine());
        continue;
    }
    Console.WriteLine("give a and b:");
    int a, b, c;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
        Console.WriteLine(a);
    else
        Console.WriteLine(b);

    double height, width;
    Console.WriteLine("Insert height: ");
    height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Insert width");
    width = Convert.ToDouble(Console.ReadLine());
    var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
    Console.WriteLine("Image orientation is " + orientation);



/*
 Your job is to write a program for a speed camera. 
For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
Write a program that asks the user to enter the speed limit. 
Once set, the program asks for the speed of a car. 
If the user enters a value less than the speed limit, program should display Ok on the console. 
If the value is above the speed limit, the program should calculate the number of demerit points. 
For every 5km/hr above the speed limit, 1 demerit points should be incurred 
and displayed on the console. 
If the number of demerit points is above 12, the program should display License Suspended.
 */

double speedLimit, speedVehicle, punkty;

    Console.WriteLine("What is a speed limit?");

    speedLimit = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What is a speed of the car?");

    speedVehicle = Convert.ToDouble(Console.ReadLine());

    if (speedVehicle <= speedLimit)
    {
        Console.WriteLine("OK");
    }
    else
    {
       punkty = (speedVehicle - speedLimit)/5;
        Console.WriteLine("License suspended. You`ve got: " + punkty + " points");
    }
}