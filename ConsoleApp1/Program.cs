using System;
using ConsoleApp1.Entities;
using ConsoleApp1.Entitites.Exceptions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

        



                Console.WriteLine("Se nao quiser atualizar a data Digite N, " +
                    "caso contrario prossiga com as informações");

                    Console.WriteLine();
                    Console.WriteLine("Enter data to update the reservation:");
                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date (dd/MM/yyyy): ");
                    checkOut = DateTime.Parse(Console.ReadLine());

                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
                

            catch (FormatException e)
            {
                Console.WriteLine("Ok , bye, PROGRAMA VAI FECHAR AQUI " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }

    }

}

    

