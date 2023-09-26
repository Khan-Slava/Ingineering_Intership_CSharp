using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Module04.HomeWork
{
    public partial class Furniture
    {
        /*Разработать один из классов на ваше усмотрение (примеры описаны ниже).

2. Реализовать не менее пяти закрытых полей (различных типов), представляющих основные характеристики рассматриваемого класса.

3. Создать не менее трех методов управления классом и методы доступа к его закрытым полям.

4. Создать метод, в который передаются аргументы по ссылке.

5. Создать не менее двух статических полей (различных типов), представляющих общие характеристики объектов данного класса.

6. Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы которых определяются студентом, исходя из специфики реализуемого класса, а также реализация конструктора по умолчанию.

7. Создать статический конструктор.

8. Создать массив (не менее 5 элементов) объектов созданного класса.

9. Создать дополнительный метод для данного класса в другом файла, используя ключевое слово partial.*/


        //7. Статический конструктор
        static Furniture(){}

        // Конструктор по умолчанию
        public Furniture()
        {
            furnitureCount++;
        }
        //6. Перегруженные конструкторы

        public Furniture(string type, string material, double price) : this(type, material, price, true, 1)
        {
        }
        public Furniture(string type, string material, double price, bool isInStock, int quantity)
        {
            this.type = type;
            this.material = material;
            this.price = price;
            this.isInStock = isInStock;
            this.quantity = quantity;
            furnitureCount++;
            totalValue += price * quantity;
        }
        


        // 2.  Закрытые поля 
        private string type;
        private string material;
        private double price;
        private bool isInStock;
        private int quantity;

        //5. Статические поля (общие характеристики для всех предметов мебели)
        private static int furnitureCount = 0;
        private static double totalValue = 0;

      

        

  

        //3.  Методы доступа к закрытым полям
        
        public string GetType()
        {
            return type;
        }

        public void SetType(string newType)
        {
            type = newType;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double newPrice)
        {
            price = newPrice;
            totalValue -= price * quantity;
            totalValue += newPrice * quantity;
        }

        //4. Метод для передачи аргументов по ссылке
        public void UpdateFurniture(ref Furniture updatedFurniture)
        {
            this.type = updatedFurniture.type;
            this.material = updatedFurniture.material;
            this.price = updatedFurniture.price;
            this.isInStock = updatedFurniture.isInStock;
            this.quantity = updatedFurniture.quantity;
        }


        // Свойства для доступа к статическим полям
        public static int FurnitureCount
        {
            get { return furnitureCount; }
        }

        public static double TotalValue
        {
            get { return totalValue; }
        }
    


}
}
