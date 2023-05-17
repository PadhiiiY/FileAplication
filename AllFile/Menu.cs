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
                         Methods.SearchFolder();
                         break;
                
                     case "2":
                         Methods.SearchFile();
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
                             Methods.CreateFolder();
                         }
                         break;
                
                     case "2":
                         Console.WriteLine("Сколько Файлов Надо создать?:");
                         int FileCount = int.Parse(Console.ReadLine());
                         for (int i = 0; i < FileCount; i++)
                         {
                             Methods.CreateFile();
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
                             Methods.DeleteFolder();
                             break;
                                    
                         case "2":
                             Methods.DeleteFile();
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
                             Methods.ReadElement();
                         }
                                    
                                    
                         break;
                                    
                     case "2":
                         Console.WriteLine("Сколько Файлов необходимо Изменить: ");
                         int Fcount = int.Parse(Console.ReadLine());
                         for (int i = 0; i < Fcount; i++)
                         {
                             Methods.EditElement();
                         }
                         
                         break;
                 }
                 break;
                        
             case "5":
                 Console.WriteLine("Сколько файлов необходимо конвертировать ? : ");
                 int FcountConvertor = int.Parse(Console.ReadLine());
                 for (int i = 0; i < FcountConvertor; i++)
                 {
                     Methods.ConvertElement();
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