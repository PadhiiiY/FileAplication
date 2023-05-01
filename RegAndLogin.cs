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
        static void Installation()
        {
            Console.WriteLine("Для запуска программы необходима предустоновка");
            Console.WriteLine("---===Installation===---");
            Console.WriteLine();
            Console.WriteLine("Firs Install");
            Console.WriteLine();
            string First_Install = Console.ReadLine();
            switch (First_Install)
            {
                case "Install":
                    CreateAllFolder();
                    Console.WriteLine("Необходимо подождать пока загрузка закончится ");
                    
                    break;
                
                case "Exit":
                    Exit();
                    break;
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
        
        static void RegisterAndLoginMenu()
        {
            Console.WriteLine("---===Регистрация и Вход===---");
            Console.WriteLine();
            Console.WriteLine("1-Installation");
            Console.WriteLine("2-Register");
            Console.WriteLine("3-Login");
            Console.WriteLine("Exit");
            Console.WriteLine();

            string RegisterAndLoginMenu = Console.ReadLine();

            switch (RegisterAndLoginMenu)
            {
                case "1":
                    Installation();
                    break;
                
                case "2":
                    Register();
                    break;
                
                case "3":
                    Login();
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
            Console.WriteLine("3-Terminal");
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
                
                case "3":
                    
                    break;
                
                case "Back":
                    RegisterAndLoginMenu();
                    break;
                
                case "Exit":
                    Exit();
                    break;
            }
        }

        static void CreateMenu()
        {
                    Console.WriteLine();
                    Console.WriteLine("1-Поиск Папки или файла");
                    Console.WriteLine("2-Создание Папки или Файла");
                    Console.WriteLine("3-Удалить Папку или Фаил");
                    Console.WriteLine("4-Прочитать Фаил или изменить");
                    Console.WriteLine("5-Изменить формат");
                    Console.WriteLine("Back");
                    Console.WriteLine("Exit");
                    Console.WriteLine();
                    string Create = Console.ReadLine();
                    switch (Create)
                    {
                        case "1":
                            Console.WriteLine();
                            Console.WriteLine("Что найти?");
                            Console.WriteLine("1-Папку");
                            Console.WriteLine("2-Фаил");
                            Console.WriteLine();
                            string select2 = Console.ReadLine();

                            switch (select2)
                            {
                                case "1" :
                                    Console.WriteLine();
                                    Console.WriteLine("Введите путь до папки" + "   "+"../../../Users=>");
                                    string WaySearchFolder = Console.ReadLine();
                                    string[] SearchFolderName = Directory.GetDirectories(WaySearchFolder);
                                    Console.WriteLine("Список Папок");
                                    foreach (string ReadFolderName in SearchFolderName)
                                    {
                                        Console.WriteLine(ReadFolderName);
                                    }
                                    Console.WriteLine();
                                    break;
                
                                case "2":
                                    Console.WriteLine();
                                    Console.WriteLine("Введите путь до файла"+ "   "+"../../../Users=>");
                                    string WaySearchFile = Console.ReadLine();
                                    string[] SearchFileName = Directory.GetFiles(WaySearchFile);
                                    foreach (string ReadFileName in SearchFileName )
                                    {
                                        Console.WriteLine(ReadFileName);
                                    }
                                    Console.WriteLine();
                                    break;
                            }
                            break;
                        
                        case "2":
                            Console.WriteLine();
                            Console.WriteLine("Что Создать?");
                            Console.WriteLine("1-Папку");
                            Console.WriteLine("2-Фаил");
                            Console.WriteLine();
                            string select3 = Console.ReadLine();

                            switch (select3)
                            {
                                case  "1":
                                    Console.WriteLine("Сколько Папок надо создать?: ");
                                    int FolderCount =int.Parse(Console.ReadLine());
                                    for (int i = 0; i < FolderCount; i++)
                                    {
                                        Console.WriteLine("Введите путь созранения Папки"+ "   "+"../../../Users=>");
                                        string WayFolder = Console.ReadLine();
                                        Console.WriteLine("Введите Имя папки");
                                        string FolderName = Console.ReadLine();

                                        string CreateFolder = Path.Combine(WayFolder, FolderName);
                                        Directory.CreateDirectory(CreateFolder);
                                        Console.WriteLine("Папка успешно создана");
                                    }
                                    break;
                
                                case "2":
                                    Console.WriteLine("Сколько Файлов Надо создать?:");
                                    int FileCount = int.Parse(Console.ReadLine());
                                    for (int i = 0; i < FileCount; i++)
                                    {
                                        Console.WriteLine("Введите путь создания Файла"+ "   "+"../../../Users=>");
                                        string WayFile = Console.ReadLine();
                                        Console.WriteLine("Введите Имя Файла");
                                        string FileName = Console.ReadLine();

                                        string CreateFile = Path.Combine(WayFile, FileName);
                                        File.Create(CreateFile);
                                        Console.WriteLine("Фаил Успешно создан");
                                    }
                                    break;
                            }
                            break;

                        case "3":
                            Console.WriteLine("Солько элементов необходимо удалить?");
                            int DelCount = int.Parse(Console.ReadLine());
                            for (int i = 0; i < DelCount; i++)
                            {
                                
                                
                                Console.WriteLine("Что удалить?");
                                Console.WriteLine("1-Папку");
                                Console.WriteLine("2-Фаил");
                                string SelectDel = Console.ReadLine();
                                switch (SelectDel)
                                {
                                    case "1":
                                        Console.WriteLine("Введите путь для удаления элементов");
                                        string WayDelElement1 = Console.ReadLine();
                                        Console.WriteLine("Введите Имя элемента");
                                        string DelElementName1 = Console.ReadLine();
                                        string DelFolder = Path.Combine(WayDelElement1, DelElementName1);
                                        Directory.Delete(DelFolder);
                                        break;
                                    
                                    case "2":
                                        Console.WriteLine("Введите путь для удаления элементов");
                                        string WayDelElement2 = Console.ReadLine();
                                        Console.WriteLine("Введите Имя элемента");
                                        string DelElementName2 = Console.ReadLine();
                                        string DelFile = Path.Combine(WayDelElement2, DelElementName2);
                                        File.Delete(DelFile);
                                        break;
                                }
                                
                                

                            }
                            break;
                        
                        case "4":
                            Console.WriteLine();
                            Console.WriteLine("1-Прочитать");
                            Console.WriteLine("2-Изменить");
                            Console.WriteLine();
                            string select4 = Console.ReadLine();
                            switch (select4)
                            {
                                case "1":
                                    Console.WriteLine("Введите путь к файлу");
                                    string WayReadFile = Console.ReadLine();
                                    Console.WriteLine("Введите Имя файла");
                                    string ReadFileName = Console.ReadLine();
                                    string FReadFile = Path.Combine(WayReadFile, ReadFileName);
                                    string FileContent = File.ReadAllText(FReadFile);
                                    Console.WriteLine(FileContent);
                                    Console.ReadKey();
                                    
                                    break;
                                    
                                case "2":
                                    Console.WriteLine("Открыть фаил для изменения ");
                                    Console.WriteLine("Введите путь файла");
                                    string WayEditFile = Console.ReadLine();
                                    Console.WriteLine("Ввелите имя файла");
                                    string EditFileName = Console.ReadLine();

                                    string EditFilePath = Path.Combine(WayEditFile, EditFileName);
                                    
                                    
                                    
                                    break;
                            }
                            break;
                        
                        case "5":
                            Console.WriteLine("Конвертация Файла");
                            Console.WriteLine("Введите путь к файлу");
                            string WayFormatFile = Console.ReadLine();
                            Console.WriteLine("Введите имя файла");
                            string FormatFileName = Console.ReadLine();
                            Console.WriteLine("Введите формат в который новертировать фаил");
                            string Form1 = Console.ReadLine();
                            string FormatPath = Path.Combine(WayFormatFile, FormatFileName);
                            File.Move(FormatPath,FormatPath.Replace(Path.GetExtension(FormatPath),Form1));
                            Console.WriteLine("Фаил успешно конвертирован");
                            break;
                        case "Back":
                            MainMenu();
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
            Register Reg = new Register();
            string Folder = ("../../../");
            string PFolder = ("../../../Users");
            if (!Directory.Exists(PFolder))                         // Create Folder "Users"
            {
                string FolderPath = Path.Combine(Folder, "Users");
                Directory.CreateDirectory(FolderPath);
            }
            else
            {
                
            }
            
            
            string path = @"../../../Users/Account";
            if (!File.Exists(path))
            {
                File.Create(@"../../../Users//Account");        //Create File "Password on Users"
                File.SetAttributes(path,FileAttributes.Hidden);
            }
            else
            {
                File.SetAttributes(path,FileAttributes.Hidden);
            }

            


        }

        static void Terminal()
        {
            
        }

        

        

        static void Main()
        {
            RegisterAndLoginMenu();
        }
    }
}
