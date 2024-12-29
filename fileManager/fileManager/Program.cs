

using System.Text;

namespace fileManager
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("Введіть шлях до вихідного файлу:");
                string sourcePath = Console.ReadLine();

                if (!File.Exists(sourcePath))
                {
                    Console.WriteLine("Вихідний файл не знайдено. Перевірте шлях.");
                    return;
                }
                Console.WriteLine("Введіть шлях до файлу призначення:");
                string destinationPath = Console.ReadLine();
                File.Copy(sourcePath, destinationPath, overwrite: true);
                Console.WriteLine($"Файл успішно скопійовано до '{destinationPath}'.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Помилка доступу до файлу. Перевірте дозволи.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Несподівана помилка: {ex.Message}");
            }
        }
    }
}




