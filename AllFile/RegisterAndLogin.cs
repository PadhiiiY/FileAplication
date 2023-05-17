using System.Text;

namespace Owner
{
    class Register
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RepeadPassword { get; set; }
    }

    public class RegisterAndLogin
    {
        public static void Register()
        {
            Register Reg = new Register();

            Console.Write("Введите ваш UserName: ");
            Reg.UserName = Console.ReadLine();
            Console.Write("Придумайте пароль: ");
            Reg.Password = Console.ReadLine();
            Console.Write("Повоторите пароль: ");
            Reg.RepeadPassword = Console.ReadLine();
            if (Reg.Password == Reg.RepeadPassword && Reg.RepeadPassword == Reg.Password)
            {
                Random randomID = new Random();
                StringBuilder userID = new StringBuilder();

                for (int i = 0; i < 5; i++)
                {
                    userID.Append(randomID.Next(0, 10));
                }

                string AccountPath = @"../../../Users/Account";
                using (StreamWriter sw = File.AppendText(AccountPath))
                {

                    sw.WriteLine();
                    sw.WriteLine("ID: " + userID);
                    sw.WriteLine("==================");
                    sw.WriteLine("Логин: " + Reg.UserName);
                    sw.WriteLine("Пароль: " + Reg.Password);
                    sw.WriteLine("==================");

                    sw.Close();
                }
                
                

                Console.WriteLine("Вы успешно зарегистрировались ");
                Console.WriteLine("Для дальнейшей работы вам необходимо пройти авторизацию");
                Menu.RegisterAndLoginMenu();

            }
            else if (Reg.Password != Reg.RepeadPassword && Reg.RepeadPassword != Reg.Password)
            {
                Console.WriteLine("Пароль не совподает попробуйте еще раз");
                Register();
            }
        }
        public static void Login()
        {
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            string fileName = @"../../../Users/Account";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2 && parts[0].Trim() == "Логин" && parts[1].Trim() == login)
                {
                    string nextLine = lines[Array.IndexOf(lines, line) + 1];
                    string[] passwordParts = nextLine.Split(':');
                    if (passwordParts.Length == 2 && passwordParts[0].Trim() == "Пароль" && passwordParts[1].Trim() == password)
                    {
                        Console.WriteLine("Вы успешно вошли в систему.");
                        Console.WriteLine();
                        Menu.MainMenu();
                        return;
                        
                    }
                }
            }

            Console.WriteLine("Неверный логин или пароль");
            Login();
        }
    }
}

