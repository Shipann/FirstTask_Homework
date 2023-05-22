using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        // 1
        string phonesFilePath = "phones.txt";
        string phonesOutputFilePath = "Phones.txt";

        try
        {
            using (StreamReader reader = new StreamReader(phonesFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string name = parts[0].Trim();
                        string phoneNumber = parts[1].Trim();
                        phoneBook[name] = phoneNumber;
                        File.AppendAllText(phonesOutputFilePath, phoneNumber + Environment.NewLine);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Файл {phonesFilePath} не найден.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при чтении файла: {ex.Message}");
        }

        // 2) Поиск и вывод номера телефона
        Console.WriteLine("Введите имя для поиска:");
        string searchName = Console.ReadLine();
        if (phoneBook.ContainsKey(searchName))
        {
            string phoneNumber = phoneBook[searchName];
            Console.WriteLine($"Найденный номер: {phoneNumber}");
        }
        else
        {
            Console.WriteLine("Номер не найден.");
        }

        // 3) Изменение формата номеров 
        string newPhonesOutputFilePath = "New.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(newPhonesOutputFilePath))
            {
                foreach (var pair in phoneBook)
                {
                    string name = pair.Key;
                    string phoneNumber = pair.Value;

                    if (phoneNumber.StartsWith("80") && phoneNumber.Length == 11)
                    {
                        phoneNumber = "+38" + phoneNumber.Substring(2);
                    }

                    writer.WriteLine($"{name}: {phoneNumber}");
                }
            }

            Console.WriteLine($"Формат номеров телефонов изменен и записан в файл {newPhonesOutputFilePath}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eror: {ex.Message}");
        }
    }
}
