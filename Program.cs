using Task13.Exceptions;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Controller controller = new Controller();
                    controller.AddUser();
                }
                catch (InvalidNameException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidAgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidPhoneFormat ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (PasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}