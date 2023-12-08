using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.HomeWork
{
    internal class Program
    {
        static void Main()
        {
            string logFilePath = "log.txt";

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Просмотр содержимого директории");
                Console.WriteLine("2. Создание файла/директории");
                Console.WriteLine("3. Удаление файла/директории");
                Console.WriteLine("4. Копирование файла/директории");
                Console.WriteLine("5. Перемещение файла/директории");
                Console.WriteLine("6. Чтение из файла");
                Console.WriteLine("7. Запись в файл");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListDirectoryContents();
                        break;
                    case "2":
                        CreateFileOrDirectory();
                        break;
                    case "3":
                        DeleteFileOrDirectory();
                        break;
                    case "4":
                        CopyFileOrDirectory();
                        break;
                    case "5":
                        MoveFileOrDirectory();
                        break;
                    case "6":
                        ReadFromFile();
                        break;
                    case "7":
                        WriteToFile();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите существующую опцию.");
                        break;
                }
            }
        }

        static void ListDirectoryContents()
        {
            Console.WriteLine("Введите путь к директории:");
            string path = Console.ReadLine();

            try
            {
                string[] files = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);

                Console.WriteLine("Файлы:");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine("\nДиректории:");
                foreach (var directory in directories)
                {
                    Console.WriteLine(directory);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void CreateFileOrDirectory()
        {
            Console.WriteLine("Выберите тип (1 - файл, 2 - директория):");
            string typeChoice = Console.ReadLine();

            Console.WriteLine("Введите путь:");
            string path = Console.ReadLine();

            try
            {
                if (typeChoice == "1")
                {
                    File.Create(path).Close();
                    Console.WriteLine("Файл создан успешно.");
                }
                else if (typeChoice == "2")
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Директория создана успешно.");
                }
                else
                {
                    Console.WriteLine("Неверный выбор типа.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void DeleteFileOrDirectory()
        {
            Console.WriteLine("Введите путь к файлу/директории:");
            string path = Console.ReadLine();

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("Файл удален успешно.");
                }
                else if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    Console.WriteLine("Директория удалена успешно.");
                }
                else
                {
                    Console.WriteLine("Файл или директория не существует.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void CopyFileOrDirectory()
        {
            Console.WriteLine("Введите путь к исходному файлу/директории:");
            string sourcePath = Console.ReadLine();

            Console.WriteLine("Введите путь к целевому месту:");
            string targetPath = Console.ReadLine();

            try
            {
                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, Path.Combine(targetPath, Path.GetFileName(sourcePath)));
                    Console.WriteLine("Файл скопирован успешно.");
                }
                else if (Directory.Exists(sourcePath))
                {
                    CopyDirectory(sourcePath, Path.Combine(targetPath, Path.GetFileName(sourcePath)));
                    Console.WriteLine("Директория скопирована успешно.");
                }
                else
                {
                    Console.WriteLine("Исходный файл или директория не существует.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void MoveFileOrDirectory()
        {
            Console.WriteLine("Введите путь к исходному файлу/директории:");
            string sourcePath = Console.ReadLine();

            Console.WriteLine("Введите путь к целевому месту:");
            string targetPath = Console.ReadLine();

            try
            {
                if (File.Exists(sourcePath))
                {
                    File.Move(sourcePath, Path.Combine(targetPath, Path.GetFileName(sourcePath)));
                    Console.WriteLine("Файл перемещен успешно.");
                }
                else if (Directory.Exists(sourcePath))
                {
                    Directory.Move(sourcePath, Path.Combine(targetPath, Path.GetFileName(sourcePath)));
                    Console.WriteLine("Директория перемещена успешно.");
                }
                else
                {
                    Console.WriteLine("Исходный файл или директория не существует.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void ReadFromFile()
        {
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();

            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine($"Содержимое файла:\n{content}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void WriteToFile()
        {
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();

            Console.WriteLine("Введите текст для записи:");
            string content = Console.ReadLine();

            try
            {
                File.WriteAllText(filePath, content);
                Console.WriteLine("Текст записан в файл успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void CopyDirectory(string sourceDir, string targetDir)
        {
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDir, fileName);
                File.Copy(file, destFile);
            }

            foreach (var subDir in Directory.GetDirectories(sourceDir))
            {
                string dirName = Path.GetFileName(subDir);
                string destDir = Path.Combine(targetDir, dirName);
                CopyDirectory(subDir, destDir);
            }
        }
    }
}
