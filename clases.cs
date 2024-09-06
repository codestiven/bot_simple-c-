using System;

public class Clases
{





    public static void color_R()
    {

        Random r = new Random();

        int coco = r.Next(1, 9);

        if (coco == 1)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (coco == 2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else if (coco == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (coco == 4)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        else if (coco == 5)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else if (coco == 6)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else if (coco == 7)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else if (coco == 8)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        else if (coco == 9)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }



    }



    public static void Scolor(string entrada , string color , bool line) {
        if (color == "E") {
            Console.ForegroundColor = ConsoleColor.Cyan;

        }
        else if (color == "R")
        {
            Console.ForegroundColor = ConsoleColor.Red;

        }
        else if (color == "A")
        {
            Console.ForegroundColor = ConsoleColor.Blue;

        }
        else if (color == "AO")
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

        }
        else if (color == "V")
        {
            Console.ForegroundColor = ConsoleColor.Green;


        }
        else if (color == "RO")
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

        }
        else if (color == "Ra")
        {
            color_R();

        }



        if (line)
        {
            Console.WriteLine(entrada);
        }
        else
        {
            Console.Write(entrada);
        }



        Console.ResetColor();


    }
}
