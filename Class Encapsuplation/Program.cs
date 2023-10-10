using System.Security.Cryptography.X509Certificates;

namespace Class_Encapsuplation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mehemmed Memmedov",122323434,19);
            
            Console.WriteLine(person1.FullName + "\n"+ person1.PhoneNumber + "\n"+ person1.Age);

            Upper();



            //TASK 2 

            static void Upper()
            {
                 string name1 = Console.ReadLine();

                if (name1.Length>0 && name1 != null)
                {
                    char first = name1[0];
                    if (first >= 'a' && first <= 'z')
                    {
                        first = (char)(first - 32);
                        Console.WriteLine("Ilk herfi boyuk olan soz : " + first + name1[1..]);
                    }
                    else Console.WriteLine("Ilk herfe reqem ve ya boyuk herf daxil edilib ");


                }

                else Console.WriteLine("duzgun metn daxil edin");
            }
        }
    }
}