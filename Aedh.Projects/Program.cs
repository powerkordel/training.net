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

        while (true)
        {
            Console.WriteLine("type your name: ");
            var input3 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input3))
            {
                Console.WriteLine("@Echo: " + input3);
                continue;
            }
                break;
        }

        
/////////////////////////////////////////////////////////////////////////////////////////////////////////////    
    const int passwordLenght = 5;
    var random = new Random();
    var buffer = new char[passwordLenght];
    for (var i = 0; i < passwordLenght; i++)
        buffer[i] = (char)('a' + random.Next(0,26));
    var password = new string(buffer);
    Console.WriteLine(password);
    

    /*
    1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
    Display the count on the console.
    */
    
    var licz = 0;
    var przezTrzy = 0;

    while (licz <= 100)
    {
        
        if (licz % 3 == 0)
        {
            przezTrzy++;
        }
        licz++;
    }
    Console.WriteLine(przezTrzy);
    

    /*
     2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
    Calculate the sum of all the previously entered numbers and display it on the console.
     */

    
        var total = 0;

        while (true)
        {
            Console.WriteLine("Give a number: \nTo finish write \"ok\".");
            var input1 = Console.ReadLine();

            if (input1.ToLower() == "ok")
                break;

            total += Convert.ToInt32(input1);
        }
        Console.WriteLine("End. Total is: " + total);

        

    /*
     3- Write a program and ask the user to enter a number. 
     Compute the factorial of the number and print it on the console. 
     For example, if the user enters 5, 
     the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
     */
    
    Console.WriteLine("enter number");
    int n = 0;
    int faktor= 1;
    n = Convert.ToInt32(Console.ReadLine());
    for (int i = n; i > 0; i--)
    {
        faktor *= i;
    }
    Console.WriteLine(n+"! = " + faktor);
    


    /*
     4- Write a program that picks a random number between 1 and 10. 
    Give the user 4 chances to guess the number. If the user guesses the number, 
    display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, 
    you can display the secret number on the console first.)
     */

    
    Console.WriteLine("Give a number: ");
    var random1 = new Random();
    
    for (int i = 4; i > 0; i--)
    {
        int shot = Convert.ToInt32(Console.ReadLine());
        int randi = random1.Next(1, 10);
        Console.WriteLine("random number is : " + randi);
        if (shot == randi)
        {
            Console.WriteLine("You won");
            break;
        }
        else if (i == 1) Console.WriteLine("You lost");
    }
   
    /*
     5- Write a program and ask the user to enter a series of numbers separated by comma. 
    Find the maximum of the numbers and display it on the console. 
    For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
     */

    Console.WriteLine("Insert number separated by coma:");

    var input = Console.ReadLine();

    var numerx = input.Split(',');

    var max = Convert.ToInt32(numerx[0]);

    foreach (var str in numerx)
    {
        var number = Convert.ToInt32(str);
        if (number > max)
            max = number;
    }
    Console.WriteLine("max number is: " + max);





}