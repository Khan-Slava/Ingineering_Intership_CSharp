using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Module04.HomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Furniture[] furnitureItems = new Furniture[5];
            //8. массив элементов класса
            furnitureItems[0] = new Furniture("Стол", "Дерево", 200, true, 2);
            furnitureItems[1] = new Furniture("Диван", "Ткань", 500, false, 0);
            furnitureItems[2] = new Furniture("Шкаф", "ДСП", 300, true, 1);
            furnitureItems[3] = new Furniture("Кровать", "Металл", 400, true, 1);
            furnitureItems[4] = new Furniture("Стул", "Пластик", 50, true, 4);

            // Вызов метода передачи по ссылке метода
            Furniture updateFurniture = new Furniture("Кресло","Кожа",300,true,2);

            furnitureItems[4].UpdateFurniture(ref updateFurniture);
            Console.WriteLine(furnitureItems[4].GetType());

            Console.WriteLine($"Всего предметов мебели: {Furniture.FurnitureCount}");
            Console.WriteLine($"Общая стоимость: ${Furniture.TotalValue:F2}");



        }
    }


}
