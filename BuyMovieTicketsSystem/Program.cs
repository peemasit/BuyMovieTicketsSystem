using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMovieTicketsSystem {
    class Program {

        static string[,] seats1_15_00 = { { "A1", "A2", "A3", "A4", "A5" }, { "B1", "B2", "B3", "B4", "B5" },
            { "C1", "C2", "C3", "C4", "C5" }, { "D1", "D2", "D3", "D4", "D5" }, { "E1", "E2", "E3", "E4", "E5" } };
        static string[,] seats1_18_40 = { { "A1", "A2", "A3", "A4", "A5" }, { "B1", "B2", "B3", "B4", "B5" },
            { "C1", "C2", "C3", "C4", "C5" }, { "D1", "D2", "D3", "D4", "D5" }, { "E1", "E2", "E3", "E4", "E5" } };
        static string[,] seats1_22_20 = { { "A1", "A2", "A3", "A4", "A5" }, { "B1", "B2", "B3", "B4", "B5" },
            { "C1", "C2", "C3", "C4", "C5" }, { "D1", "D2", "D3", "D4", "D5" }, { "E1", "E2", "E3", "E4", "E5" } };
        static string[,] seats2_17_00 = { { "A1", "A2", "A3", "A4", "A5" }, { "B1", "B2", "B3", "B4", "B5" },
            { "C1", "C2", "C3", "C4", "C5" }, { "D1", "D2", "D3", "D4", "D5" }, { "E1", "E2", "E3", "E4", "E5" } };
        static string[,] seats2_19_20 = { { "A1", "A2", "A3", "A4", "A5" }, { "B1", "B2", "B3", "B4", "B5" },
            { "C1", "C2", "C3", "C4", "C5" }, { "D1", "D2", "D3", "D4", "D5" }, { "E1", "E2", "E3", "E4", "E5" } };
        static string[,] seats2_21_40 = { { "A1", "A2", "A3", "A4", "A5" }, { "B1", "B2", "B3", "B4", "B5" },
            { "C1", "C2", "C3", "C4", "C5" }, { "D1", "D2", "D3", "D4", "D5" }, { "E1", "E2", "E3", "E4", "E5" } };

        static bool inputCurrent = true;
        static bool backCurrent = false;
        static bool confirmCurrent = false;
        static void Main(string[] args) {
            Showtime();
            do {
                Console.Write("Choose a movie number :");
                string movieNumber = Console.ReadLine();
                if (movieNumber == "1") {
                    Console.Write("Choose showtimes number :");
                    string movieShowtime = Console.ReadLine();
                    if (movieShowtime == "1") {
                        CheckSeat(seats1_15_00);
                    } else if (movieShowtime == "2") {
                        CheckSeat(seats1_18_40);
                    } else if (movieShowtime == "3") {
                        CheckSeat(seats1_22_20);
                    } else {
                        Console.Write("Please enter showtimes number :");
                    }
                } else if (movieNumber == "2") {
                    Console.Write("Choose showtimes number :");
                    string movieShowtime = Console.ReadLine();
                    if (movieShowtime == "1") {
                        CheckSeat(seats2_17_00);
                    } else if (movieShowtime == "2") {
                        CheckSeat(seats2_19_20);
                    } else if (movieShowtime == "3") {
                        CheckSeat(seats2_21_40);
                    } else {
                        Console.Write("Please enter showtimes number :");
                    }
                } else {
                    Console.WriteLine("Enter a movie number 1 or 2 :");
                }
            } while (true);
            
        }

        static void Showtime() {
            Console.WriteLine("-----Showtimes-----");
            Console.WriteLine();
            Console.WriteLine("1.Avengers Endgame");
            Console.WriteLine("  1      2      3  ");
            Console.WriteLine("15.00  18.40  22.20");
            Console.WriteLine();
            Console.WriteLine("2.Doraemon The Movie");
            Console.WriteLine("  1      2      3  ");
            Console.WriteLine("17.00  19.20  21.40");
            Console.WriteLine();
        }

        static void ShowSeats(string[,] seats) {
            Console.Clear();
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("------------------------------");
                for (int j = 0; j < 5; j++) {
                    Console.Write($"| {seats[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("----------- SCREEN -----------");
            Console.WriteLine("------------------------------");
        }
        static void ChooseSeat(string[,] seats, int i,int input) {
            switch (input) {
                case 1: seats[i, 0] = "/"; break;
                case 2: seats[i, 1] = "/"; break;
                case 3: seats[i, 2] = "/"; break;
                case 4: seats[i, 3] = "/"; break;
                case 5: seats[i, 4] = "/"; break;
            }
        }
        static void CheckSeat(string[,] table) {
            do {
                ShowSeats(table);
                do {
                    Console.Write("Choose seat number: ");
                    string input = (Console.ReadLine()).ToUpper();
                    string row = "";
                    int number = 0;
                    try {
                        row = input.Substring(0, 1);
                        number = int.Parse(input.Substring(1, 1));
                    } catch (Exception) {

                    }
                    if ((row == "A") && (number <= 5 && number > 0) && input.Length == 2 && (table[0, number - 1] == $"A{number}")) {
                        ConfirmSeat(input, table, 0, number);
                    } else if ((row == "B") && (number <= 5 && number > 0) && (table[1, number - 1] == $"B{number}") && input.Length == 2) {
                        ConfirmSeat(input, table, 1, number);
                    } else if ((row == "C") && (number <= 5 && number > 0) && (table[2, number - 1] == $"C{number}") && input.Length == 2) {
                        ConfirmSeat(input, table, 2, number);
                    } else if ((row == "D") && (number <= 5 && number > 0) && (table[3, number - 1] == $"D{number}") && input.Length == 2) {
                        ConfirmSeat(input, table, 3, number);
                    } else if ((row == "E") && (number <= 5 && number > 0) && (table[4, number-1] == $"E{number}") && input.Length == 2) {
                        ConfirmSeat(input, table, 4, number);
                    } else if ((number <= 5 && number > 0) && ((table[0,number-1] == "/") || (table[1, number - 1] == "/") || (table[2, number - 1] == "/") || 
                        (table[3, number - 1] == "/")|| (table[4, number - 1] == "/")) && ((row == "A") || (row == "B") || (row == "C") || (row == "D") ||(row == "E"))) {
                        Console.WriteLine("Seat is reserved, please choose another seat, if you want to back to showtimes enter (back)");
                        inputCurrent = false;
                        backCurrent = false;
                    } else if (input.ToLower() == "back") {
                        Console.Clear();
                        Showtime();
                        inputCurrent = true;
                        backCurrent = true;
                    } else {
                        Console.WriteLine("Please enter seat(ex. A1,A2,...)");
                        inputCurrent = false;
                        backCurrent = false;
                    }
                } while (!inputCurrent);
            } while (!backCurrent);
        }
        static void ConfirmSeat(string input, string[,]table, int row, int number) {
            do {
                Console.Write($"Confirm seat {input} (Y/N) : ");
                string confirm = Console.ReadLine();
                if (confirm.ToUpper() == "Y") {
                    ChooseSeat(table, row, number);
                    ShowSeats(table);
                    inputCurrent = true;
                    backCurrent = false;
                    confirmCurrent = true;
                } else if (confirm.ToUpper() == "N") {
                    confirmCurrent = true;
                } else {
                    Console.WriteLine("Please enter Y/N ");
                    confirmCurrent = false;
                }
            } while (!confirmCurrent);
        }
        

    }
}
