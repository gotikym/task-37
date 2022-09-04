using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dossiers = new Dictionary<string, string>();
        dossiers.Add("Васильев Иван Петрович", "Раб");
        dossiers.Add("Макаров Максим Владимирович", "Слуга");
        dossiers.Add("Мельников Евгений Михайлович", "Советник");
        dossiers.Add("Круглов Вадим Александрович", "Правитель");
        dossiers.Add("Упаковкин Сосиска Молокович", "Повелитель");

        OperateWithDossier(dossiers);
    }

    static void OperateWithDossier(Dictionary<string, string> dossiers)
    {
        const string Add = "Add";
        const string Show = "Show";
        const string Delete = "Delete";
        const string Exit = "Exit";
        bool exit = false;

        while (exit == false)
        {
            Console.WriteLine($"Для добавления нового досье, введите - {Add}, " +
                $"для просмотра всех досье - {Show}, для удаления досье - {Delete}, для выхода их программы - {Exit}");
            string UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case Add:
                    AddDossier(dossiers);
                    break;

                case Show:
                    ShowDossier(dossiers);
                    break;

                case Delete:
                    DeleteDossier(dossiers);
                    break;

                case Exit:
                    exit = true;
                    break;
            }
        }
    }

    static void AddDossier(Dictionary<string, string> dossiers)
    {
        Console.WriteLine("Введите ФИО сотрудника: ");
        string key = Console.ReadLine();
        Console.WriteLine("Введите должность сотрудника: ");
        string value = Console.ReadLine();

        if (dossiers.ContainsKey(key) == false)
        {
            dossiers.Add(key, value);
        }
        else
        {
            Console.WriteLine("Этот сотрудник уже добавлен");
        }
    }

    static void ShowDossier(Dictionary<string, string> dossiers)
    {
        foreach (var dossier in dossiers)
        {
            Console.WriteLine($"{dossier.Key} - {dossier.Value}");
        }
    }

    static void DeleteDossier(Dictionary<string, string> dossiers)
    {
        Console.WriteLine("Для удаления досье, введите ФИО полностью");
        string Key = Console.ReadLine();
        dossiers.Remove(Key);
    }
}
