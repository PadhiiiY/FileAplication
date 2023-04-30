using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;


namespace FileJarvis
{
    
    
    public class Register
    {
        
        
        public int User_ID { get; set; }
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string RegeadPassword { get; set; }
    }
    
    public class Program
    { 
        
        static void RegisterAndLoginMenu()
        {
            Console.WriteLine("---===Регистрация и Вход===---");
            Console.WriteLine();
            Console.WriteLine("1-Register");
            Console.WriteLine("2-Login");
            Console.WriteLine("Exit");
            Console.WriteLine();

            string RegisterAndLoginMenu = Console.ReadLine();

            switch (RegisterAndLoginMenu)
            {
                case "1":
                    Register();
                    break;
                
                case "2":
                    Login();
                    break;
                case "Exit":
                    Exit();
                    break;
            }
            
            
        }

        static void CreateMenu()
        {
                    Console.WriteLine();
                    Console.WriteLine("1-Search Folder");
                    Console.WriteLine("2-Search File");
                    Console.WriteLine("3-Сreate Folder");
                    Console.WriteLine("4-Сreate File");
                    Console.WriteLine("Back");
                    Console.WriteLine("Exit");
                    Console.WriteLine();
                    string Create = Console.ReadLine();
                    switch (Create)
                    {
                        
                        case "1":
                            Console.WriteLine("Путь по которому хотите посмотреть Папки"+ "Y/N");
                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Введите путь к Папкам");
                                string SearchWayFolder = Console.ReadLine();

                                string[] List_FolderPath = Directory.GetDirectories(SearchWayFolder);
                                Console.WriteLine("Список Папок");
                                foreach (var SearchReadFolder in List_FolderPath)
                                {
                                    Console.WriteLine(SearchReadFolder);
                                }

                            }
                            else if (Console.ReadKey().Key == ConsoleKey.N)
                            {
                                CreateMenu();    
                            }
                            
                            break;
                        
                        case "2":
                                Console.WriteLine("Путь по которому хотите посмотреть файлы "+ "Y/N");
                                Console.WriteLine();
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Введите путь к файлам");
                                    string SearchWayFile = Console.ReadLine();

                                    string[] List_FilePath = Directory.GetFiles(SearchWayFile);
                                    foreach (var SearchReadFile  in List_FilePath)
                                    {
                                        Console.WriteLine(SearchReadFile);
                                    }
                                }
                                else if(Console.ReadKey().Key == ConsoleKey.N)
                                {
                                    CreateMenu();
                                }
                                
                                break;

                        case "3" :
                            Console.WriteLine("Создать папку?"+ "Y/N");
                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Введите название папки");
                                string NewFolder = Console.ReadLine();
                                Console.WriteLine("Введите путь к папке");
                                string WayFolder = Console.ReadLine();

                                string FolderPath = Path.Combine(WayFolder, NewFolder);
                                Directory.CreateDirectory(FolderPath);

                            }
                            else if (Console.ReadKey().Key == ConsoleKey.N)
                            {
                                CreateMenu();    
                            }
                            
                            break;
                        
                        case "4":
                            Console.WriteLine("Создать Фаил?"+"Y/N");
                            Console.WriteLine();
                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Введите название Файла");
                                string NewFile = Console.ReadLine();
                                Console.WriteLine("Введите путь к файлу");
                                string WayFile = Console.ReadLine();

                                string FilePath = Path.Combine(WayFile, NewFile);
                                File.Create(FilePath);
                            }
                            else if (Console.ReadKey().Key == ConsoleKey.N)
                            {
                                CreateMenu();
                            }
                            else
                            {
                                
                            }
                            
                            
                            break;
                        
                        case "Back" :
                            MainMenu();
                            break;
                        
                        case "Exit":
                            Exit();
                            break;
                    }
        }

        
        
        static void MainMenu()
        {
            Console.WriteLine("---===MAIN MENU===---");
            Console.WriteLine();
            Console.WriteLine("1-Personal Account");
            Console.WriteLine("2-Create Folder or File");
            Console.WriteLine("Back");
            Console.WriteLine("Exit");


            string MainMenu = Console.ReadLine();
            switch (MainMenu)
            {
                
                case "1":
                    
                    break;
                
                case "2":
                    CreateMenu();
                    break;
                case "Back":
                    RegisterAndLoginMenu();
                    break;
                
                case "Exit":
                    Exit();
                    break;
            }
        }

        static void Exit()
        {
            
            do
            {
                Console.Clear();
                Console.WriteLine("Нажмите Esc Для Выхода");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static void CreateAllFolder()
        {
            
            // Create Folder "Users"
            string Folder = ("../../../");
            string PFolder = ("../../../Users");
            if (!Directory.Exists(PFolder))
            {
                string FolderPath = Path.Combine(Folder, "Users");
                Directory.CreateDirectory(FolderPath);
            }
            else
            {
                
            }
            
            
            //Create File "Password on Users"

            string path = @"../../../Users/Account";
            if (!File.Exists(path))
            {
                File.Create(@"../../../Users//Account");
                File.SetAttributes(path,FileAttributes.Hidden);
            }
            else
            {
                File.SetAttributes(path,FileAttributes.Hidden);
            }

            
            
        }

        static void Register()
        {
            Register Reg = new Register();
            Console.Write("Введите ваш UserName: ");
            Reg.Username = Console.ReadLine();
            Console.Write("Придумайте пароль: ");
            Reg.Password = Console.ReadLine();
            Console.Write("Повоторите пароль: ");
            Reg.RegeadPassword = Console.ReadLine();
            if (Reg.Password == Reg.RegeadPassword && Reg.RegeadPassword == Reg.Password)
            {
                string AccountPath = @"../../../Users/Account";
                using (StreamWriter sw = File.AppendText(AccountPath))
                {
                    
                    sw.WriteLine();
                    
                    sw.WriteLine("==================");
                    sw.WriteLine("Логин: " + Reg.Username );
                    sw.WriteLine("Пароль: " + Reg.Password );
                    sw.WriteLine("==================");
                    
                    sw.Close();
                }

                string UserWorkFolder = @"../../../Users";
                string PUserWorkFolder = $@"../../../Users/{Reg.Username}";
                if (!Directory.Exists(PUserWorkFolder))
                {
                    string WorkFolder = Path.Combine(UserWorkFolder, $"{Reg.Username}");
                    Directory.CreateDirectory(PUserWorkFolder);
                }
                
                Console.WriteLine("Вы успешно зарегистрировались ");
                Console.WriteLine("Для дальнейшей работы вам необходимо пройти авторизацию");
                RegisterAndLoginMenu();
                
            }
            else if (Reg.Password != Reg.RegeadPassword && Reg.RegeadPassword != Reg.Password)
            {
                Console.WriteLine("Пароль не совподает попробуйте еще раз");
                Register();
            }
        }

        static void Login()
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
                        MainMenu();
                        return;
                        
                    }
                }
            }

            Console.WriteLine("Неверный логин или пароль");
            Login();
        }

        static void Main()
        {
            CreateAllFolder();
            RegisterAndLoginMenu();
            
            
        }
    }
}
