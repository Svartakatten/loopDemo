namespace loopDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int myNumber = 0;

            //while (myNumber <= 5)
            //{
            //    Console.WriteLine(myNumber);
            //    myNumber++;
            //}

            //int Number = 1;

            //string myPassword = "12345";
            //string userPasswordInput = "";

            //do
            //{
            //    Console.WriteLine("Skriv lösenord: ");
            //    userPasswordInput = Console.ReadLine();

            //} while (userPasswordInput != myPassword);

            //int number = 0;

            //Console.WriteLine("while loop starts here!");
            //while (number <= 10)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            //string myString = "Hello World";

            //for (int number1 = 0; number1 <= 10; number1 = number1 + 2)
            //{
            //    Console.WriteLine(number1);
            //}

            //char[] helloWorld = {'h','e','l','l','o' };

            //for (int i = 0; i < helloWorld.Length; i++)
            //{
            //    Console.Write(helloWorld[i]);
            //}

            //Skapar en array med 3 värden.
            string[] users = { "Aldor", "Reidar", "Anders" };


            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }

            foreach (string user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}