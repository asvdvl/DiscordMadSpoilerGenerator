using System;
using System.Globalization;

namespace DiscordMadSpoilerGenerator
{
    class Program
    {
        static void Main()
        {
            var invitationToInputText = "Enter text: ";
            var ResultText = "Your result: ";
            switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
            {
                case "ru":
                    Console.WriteLine("Это простая программа для генерирования трудно открываемых спойлеров, например ||т||||а||||к||||и||||х||");
                    Console.WriteLine("Пожалуйста, не используйте во вред другим.");
                    invitationToInputText = "Введите текст: ";
                    ResultText = "Результат: ";
                    break;
                default:
                    Console.WriteLine("This is a simple program for generating hard-to-open spoilers, e.g. ||w||||o||||r||||d||");
                    Console.WriteLine("Please do not use it to the detriment of others.");
                    break;
            }
            while (true)
            {
                Console.Write(invitationToInputText);
                var inputText = Console.ReadLine();
                var result = "";
                foreach (var textPart in inputText)
                {
                    result += $"||{textPart}||";
                }
                Console.WriteLine(ResultText + result);
            }
        }
    }
}
