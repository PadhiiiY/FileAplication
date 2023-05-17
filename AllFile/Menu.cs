namespace Owner;

public class Menu
{
    public static void RegisterAndLoginMenu()
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
                RegisterAndLogin.Register();
                break;
            
            case "2":
                RegisterAndLogin.Login();
                break;
        }
        
    }

    public static void MainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("---===MAIN MENU===---");
        Console.WriteLine();
        Console.WriteLine("1-Personal Account");
        Console.WriteLine("2-Create Folder or File");
        Console.WriteLine("3-Terminal");
        Console.WriteLine("Back");
        Console.WriteLine("Exit");
        Console.WriteLine();
        
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
                
                break;
                
            case "Exit":
                Exit();
                break;
        }
    }

    public static void CreateMenu()
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
                         Console.WriteLine("Сколько файлов нужно прочитать?: ");
                         int FcountRead = int.Parse(Console.ReadLine());
                         for (int i = 0; i < FcountRead; i++)
                         {
                             Console.WriteLine("Введите путь к файлу");
                             string WayReadFile = Console.ReadLine();
                             Console.WriteLine("Введите Имя файла");
                             string ReadFileName = Console.ReadLine();
                             string FReadFile = Path.Combine(WayReadFile, ReadFileName);
                             string FileContent = File.ReadAllText(FReadFile);
                             Console.WriteLine(FileContent);
                             Console.ReadKey();
                         }
                                    
                                    
                         break;
                                    
                     case "2":
                         Console.WriteLine("Сколько Файлов необходимо Изменить: ");
                         int Fcount = int.Parse(Console.ReadLine());
                         for (int i = 0; i < Fcount; i++)
                         {
                             Console.WriteLine("Открыть фаил для изменения ");
                             Console.WriteLine("Введите путь файла");
                             string WayEditFile = Console.ReadLine();
                             Console.WriteLine("Ввелите имя файла");
                             string EditFileName = Console.ReadLine();

                             string EditFilePath = Path.Combine(WayEditFile, EditFileName);
                         }
                                    
                                    
                                    
                                    
                         break;
                 }
                 break;
                        
             case "5":
                 Console.WriteLine("Сколько файлов необходимо конвертировать ? : ");
                 int FcountConvertor = int.Parse(Console.ReadLine());
                 for (int i = 0; i < FcountConvertor; i++)
                 {
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
                 }
                            
                 break;
             case "Back":
                 MainMenu();
                 break;
                        
             case "Exit":
                 Exit();
                 break;
         }
    }

    public static void Exit()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Нажмите Esc Для Выхода");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
    
}