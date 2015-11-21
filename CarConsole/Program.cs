using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Model;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = "Лада";
            var category = 'D';
            var car = new Car(category, model) {Color = Color.DarkOrchid};

            try
            {
                Console.WriteLine("Имя владельца {0}: {1}", car.Model, car.CarPassport.Owner.Name);
            }
            catch (NullReferenceException exeption)
            {
                Console.WriteLine("Владельца {0} не существует! Сообщение об ошибке: {1}", car.Model, exeption.Message);
            }

            var Name = "Вольдемар";
            var Category = "BC";
            var driver = new Driver(new DateTime(2014, 07, 29), Name) { Category = Category };

            var CarNumber = "o777oo";
            try
            {
                car.ChangeOwner(driver, CarNumber);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            driver.Category = driver.Category + "D";
            try
            {
                car.ChangeOwner(driver, CarNumber);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
           
            Console.WriteLine(driver.Car.CarNumber);
            Console.WriteLine(driver.Name);
            Console.ReadKey();
        }
    }
}
