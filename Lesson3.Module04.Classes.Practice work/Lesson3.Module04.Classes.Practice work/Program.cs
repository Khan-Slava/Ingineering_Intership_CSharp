using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Module04.Classes.Practice_work
{
    class Program
    {
        static void Main()
        {
            //task1();
            task2();
        }

        /*Создайте структуру с именем student, содержащую поля: фамилия и инициалы, номер группы, 
         * успеваемость (массив из пяти элементов). Создать массив из десяти элементов такого типа, 
         * упорядочить записи по возрастанию среднего балла. Добавить возможность вывода фамилий и 
         * номеров групп студентов, имеющих оценки, равные только 4 или 5.*/
        static void task1()
        {
            Students[] students = new Students[10];
            students[0] = new Students("Иванов И.И.", "Группа 1", new int[] { 5, 4, 5, 4, 5 });
            students[1] = new Students("Петров П.П.", "Группа 2", new int[] { 3, 4, 4, 3, 3 });
            students[2] = new Students("Сидоров С.С.", "Группа 1", new int[] { 5, 5, 5, 5, 5 });
            students[3] = new Students("Андреев А.А.", "Группа 3", new int[] { 4, 4, 4, 4, 4 });
            students[4] = new Students("Козлов К.К.", "Группа 2", new int[] { 3, 3, 3, 3, 3 });
            students[5] = new Students("Михайлов М.М.", "Группа 1", new int[] { 5, 5, 4, 5, 5 });
            students[6] = new Students("Николаев Н.Н.", "Группа 3", new int[] { 4, 4, 5, 4, 4 });
            students[7] = new Students("Григорьев Г.Г.", "Группа 2", new int[] { 3, 3, 4, 3, 3 });
            students[8] = new Students("Дмитриев Д.Д.", "Группа 1", new int[] { 5, 5, 5, 5, 5 });
            students[9] = new Students("Олегов О.О.", "Группа 2", new int[] { 4, 4, 4, 4, 4 });

            // Сортировка студентов по среднему баллу
            Array.Sort(students, (x, y) => x.GetAverageGrade().CompareTo(y.GetAverageGrade()));

            Console.WriteLine("Студенты с упорядоченными записями по возрастанию среднего балла:");
            foreach (Students student in students)
            {
                Console.WriteLine($"{student.FullName}, {student.GroupNumber}, Средний балл: {student.GetAverageGrade():F2}");
            }

            Console.WriteLine("\nСтуденты с оценками только 4 и 5:");
            foreach (Students student in students)
            {
                if (student.HasOnlyGoodGrades())
                {
                    Console.WriteLine($"{student.FullName}, {student.GroupNumber}");
                }
            }

        }

       
        /*Описать класс «домашняя библиотека». Предусмотреть возможность работы с произвольным числом книг,
         * поиска книги по какому-либо признаку (например, по автору или по году издания), добавления книг в библиотеку,
         * удаления книг из нее, сортировки книг по разным полям*/
        static void task2()
        {
            HomeLibrary library = new HomeLibrary();

            library.AddBook(new Book("Война и мир", "Лев Толстой", 1869, "Роман"));
            library.AddBook(new Book("Преступление и наказание", "Федор Достоевский", 1866, "Роман"));
            library.AddBook(new Book("1984", "Джордж Оруэлл", 1949, "Антиутопия"));
            library.AddBook(new Book("Мастер и Маргарита", "Михаил Булгаков", 1967, "Фэнтези"));
            library.AddBook(new Book("Гарри Поттер и философский камень", "Джоан Роулинг", 1997, "Фэнтези"));

            Console.WriteLine("Список всех книг в библиотеке:");
            library.DisplayBooks(library.SortBooksByTitle());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Книги автора 'Лев Толстой':");
            library.DisplayBooks(library.FindBooksByAuthor("Лев Толстой"));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Книги, изданные в 1967 году:");
            library.DisplayBooks(library.FindBooksByYear(1967));

            Console.WriteLine("-----------------------------------");
            // Удаление книги
            Book bookToRemove = library.FindBooksByTitle("1984").FirstOrDefault();
            if (bookToRemove != null)
            {
                library.RemoveBook(bookToRemove);
                Console.WriteLine("Книга '1984' удалена из библиотеки.");
            }
        
        }
    }
}
