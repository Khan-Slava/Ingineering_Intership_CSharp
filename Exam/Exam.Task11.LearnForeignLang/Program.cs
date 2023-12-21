using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.DLL;
using LiteDB;

namespace Exam.Task11.LearnForeignLang
{
    public class Program
    {
        static void Main(string[] args)
        {
            //сделать подключение к litedb
            using (var db = new LiteDatabase(@"database.db"))
            {
                
                var col = db.GetCollection<WordPair>("WordPair");

                WordPair word = new WordPair("English","Привет","Hello");
                //col.Insert(word);
                

                Console.WriteLine("--------");
                var result = col.FindAll();

               
                foreach (var item in result)
                {
                    Console.WriteLine(item.WordInOriginal);
                    

                }
                col.DeleteAll();


            }
            var repo = new Repository<WordPair>(@"database.db");
            var lll = repo.GetAll();
            foreach (var item in lll.ListData)
            {
                Console.WriteLine(item.WordInOriginal);
            }



        }
        static void AddNewWord()
        {
            //сделать добавление новых слов в лдб
        }
        static void StartTesting()
        {
            //сделать тестирование слов
            //вывод слово-оригинал
            //пользователь вводит слово перевод
            //проверка правильности слова
            //подсчет правильных и неправильных слов

        }
        static void StartLearning()
        {
            //слово - перевод Изучение слов
        }



    }
}
