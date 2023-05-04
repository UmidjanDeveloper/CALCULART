namespace CalculatR.Classes
{ 

    class Security
    {
        public void CheckPassword()
        {
            string password = "";

            do 
            {
                Console.WriteLine("Enter you password to continue: ");
                password = Console.ReadLine();
            } while(password != "Umid@123");
            Thread.Sleep(2000);
            Console.WriteLine("Congratulation the password is coorect :) ");
            Thread.Sleep(2000);
        }
    }
}