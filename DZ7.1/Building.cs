using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7._1
{
    public class Building
    {
        private static int lastBuildingNumber = 0; // Статическое поле для отслеживания последнего номера здания
        private int buildingNumber;
        private double height;
        private int numberOfFloors;
        private int numberOfApartments;
        private int numberOfEntrances;

        // Конструктор, генерирующий уникальный номер здания
        public Building(double height, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
        {
            this.buildingNumber = GenerateBuildingNumber();
            this.height = height;
            this.numberOfFloors = numberOfFloors;
            this.numberOfApartments = numberOfApartments;
            this.numberOfEntrances = numberOfEntrances;
        }

        // Метод генерации уникального номера здания
        private int GenerateBuildingNumber()
        {
            return ++lastBuildingNumber;
        }


        // Свойства для доступа к атрибутам здания и их настройки
        public int BuildingNumber { get => buildingNumber; }
        public double Height { get => height; set => height = value; }
        public int NumberOfFloors { get => numberOfFloors; set => numberOfFloors = value; }
        public int NumberOfApartments { get => numberOfApartments; set => numberOfApartments = value; }
        public int NumberOfEntrances { get => numberOfEntrances; set => numberOfEntrances = value; }

        // Метод расчета высоты пола
        public double CalculateFloorHeight()
        {
            if (numberOfFloors > 0)
            {
                return height / numberOfFloors;
            }
            else
            {
                return 0; 
            }
        }


        // Метод расчета количества квартир в каждом подъезде
        public double CalculateApartmentsPerEntrance()
        {
            if (numberOfEntrances > 0)
            {
                return (double)numberOfApartments / numberOfEntrances;
            }
            else
            {
                return 0; 

            }
        }

        // Метод расчета количества квартир на этаже
        public double CalculateApartmentsPerFloor()
        {
            if (numberOfFloors > 0)
            {
                return (double)numberOfApartments / numberOfFloors;
            }
            else
            {
                return 0; 
            }
        }

        // Метод печати информации о здании
        public void PrintBuildingInfo()
        {
            Console.WriteLine($"Building Number: {buildingNumber}");
            Console.WriteLine($"Height: {height} meters");
            Console.WriteLine($"Number of Floors: {numberOfFloors}");
            Console.WriteLine($"Number of Apartments: {numberOfApartments}");
            Console.WriteLine($"Number of Entrances: {numberOfEntrances}");
            Console.WriteLine($"Floor Height: {CalculateFloorHeight():F2} meters");
            Console.WriteLine($"Apartments per Entrance: {CalculateApartmentsPerEntrance():F0}");
            Console.WriteLine($"Apartments per Floor: {CalculateApartmentsPerFloor():F0}");
        }
    }
}
