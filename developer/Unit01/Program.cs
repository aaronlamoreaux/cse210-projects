using System;

namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
            string square1 = "1";
            string square2 = "2";
            string square3 = "3";
            string square4 = "4";
            string square5 = "5";
            string square6 = "6";
            string square7 = "7";
            string square8 = "8";
            string square9 = "9";
            int win = 0;

            do {
                writeBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9);

                Console.Write ("x's turn to choose a square (1-9): ");
                string userInput = Console.ReadLine();
                Console.WriteLine (" ");

                if (userInput == "1") {
                    square1 = "x";
                }
                else if (userInput == "2") {
                    square2 = "x";
                }
                else if (userInput == "3") {
                    square3 = "x";
                }
                else if (userInput == "4") {
                    square4 = "x";
                }
                else if (userInput == "5") {
                    square5 = "x";
                }
                else if (userInput == "6") {
                    square6 = "x";
                }
                else if (userInput == "7") {
                    square7 = "x";
                }
                else if (userInput == "8") {
                    square8 = "x";
                }
                else if (userInput == "9") {
                    square9 = "x";
                }

                if (square1 == "x" && square4 == "x" && square7 == "x"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square1 == "x" && square2 == "x" && square3 == "x"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square1 == "x" && square5 == "x" && square9 == "x"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square2 == "x" && square5 == "x" && square8 == "x"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square3 == "x" && square6 == "x" && square9 == "x"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square3 == "x" && square5 == "x" && square7 == "x"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square4 == "x" && square5 == "x" && square6 == "x"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square7 == "x" && square8 == "x" && square9 == "x"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }

                writeBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9);

                Console.Write ("o's turn to choose a square (1-9): ");
                string user2Input = Console.ReadLine();
                Console.WriteLine (" ");

                if (user2Input == "1") {
                    square1 = "o";
                }
                else if (user2Input == "2") {
                    square2 = "o";
                }
                else if (user2Input == "3") {
                    square3 = "o";
                }
                else if (user2Input == "4") {
                    square4 = "o";
                }
                else if (user2Input == "5") {
                    square5 = "o";
                }
                else if (user2Input == "6") {
                    square6 = "o";
                }
                else if (user2Input == "7") {
                    square7 = "o";
                }
                else if (user2Input == "8") {
                    square8 = "o";
                }
                else if (user2Input == "9") {
                    square9 = "o";
                }

                if (square1 == "o" && square4 == "o" && square7 == "o"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square1 == "o" && square2 == "o" && square3 == "o"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square1 == "o" && square5 == "o" && square9 == "o"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square2 == "o" && square5 == "o" && square8 == "o"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square3 == "o" && square6 == "o" && square9 == "o"){           
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square3 == "o" && square5 == "o" && square7 == "o"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square4 == "o" && square5 == "o" && square6 == "o"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
                else if (square7 == "o" && square8 == "o" && square9 == "o"){
                    victoryBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9, win);
                    break;
                }
            } while (win != 1);
        }

        static void writeBoard(string square1, string square2, string square3, string square4, string square5, string square6, string square7, string square8, string square9){
            Console.WriteLine($"{square1}|{square2}|{square3}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{square4}|{square5}|{square6}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{square7}|{square8}|{square9}");
            Console.WriteLine (" ");
        }
        static void victoryBoard(string square1, string square2, string square3, string square4, string square5, string square6, string square7, string square8, string square9, int win){
            writeBoard(square1, square2, square3, square4, square5, square6, square7, square8, square9);
            Console.WriteLine("Good game. Thanks for playing!");
            win++;
        }
    
    }
}
