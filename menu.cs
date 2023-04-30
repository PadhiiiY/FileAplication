using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileJarvis;

/*class Program
{
    
    
    
    
    
    
    
    static void Main()
    {
        
        
        void DeleteFile()
        {
            Console.WriteLine("Для удаления файла ведите NameFile: ");
            
            string DeleteNameFile = Console.ReadLine();
            string DeletePath  =("../../../"+DeleteNameFile);
            File.Delete(DeletePath);
            Console.WriteLine("Фаил успешно удален");
        }
        
        void CreateFile()
        {
            
            Console.WriteLine("Введите NameFile: ");
            string CreateDateipfad , CreateNameFile = ("../../../") + Console.ReadLine();
            
            Console.WriteLine("Введите текст: ");
            string CreateFileContent = Console.ReadLine();
            
            File.WriteAllText(CreateNameFile  ,CreateFileContent);
            Console.WriteLine("Фаил создан и успешно заполнен");
        }
        
        void ReturnMenu()
        {
            ///Return Menu  ///Возврат в главное меню
            Console.WriteLine("--==Menu==--"); 
            Console.WriteLine();
            Console.WriteLine("MainMenu");
            Console.WriteLine("Back");
            Console.WriteLine("Exit");
        
            string Menu1 = Console.ReadLine();
        
            switch (Menu1)
            {
                case "MainMenu":
                    Console.Clear();
                    Main();
                    break;
                
                case "Back":
                    Main();
                    break;
                
                case "Exit":
                    Exit();
                    break;
            }
        }
        
        //Enter List Folder //Вывод списка Файлов
        void List_Folder()
        {
            
            Console.WriteLine();
            string ReadFolderPath = ("../../../");
            string[] fileNames = Directory.GetFiles(ReadFolderPath);
            Console.WriteLine("Список Файлов в Папке");
            foreach (string ReadFileName in fileNames)
            {
                Console.WriteLine(ReadFileName);
            }
            Console.WriteLine();
        }
        
        ///Conclusion list Files /// Вывод листа файлов
        void Read_Source() 
        {
            
            
            
            Console.WriteLine("Введите  NameFile: ");
            var ReadNewFile = Console.ReadLine();
            var ReadReadFile = File.ReadAllText("../../../" + ReadNewFile);
            Console.WriteLine(ReadReadFile);
        }
        //Metod Exit // Метод выхода
        
        void Exit()
        {
        
            Console.WriteLine("Досвиданья сэр");
            Console.WriteLine("Нажмите  Esc Выход");
            do
            {
            
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        
        
        //Main menu //Главное меню
        Console.WriteLine("-=FILE FOLDER=-");
        Console.WriteLine();
        Console.WriteLine("Create File");
        Console.WriteLine("Read File");
        Console.WriteLine("Edit File");
        Console.WriteLine("Exit");
        Console.WriteLine();
        
        //Select мод // Выбор элемента меню 
        Console.WriteLine("Выбирите Mode");
        string MainMenu = Console.ReadLine();
        
        //Menu || Swithm case;
        switch (MainMenu)
        {
            case "Create File":
                
                List_Folder();
                Console.WriteLine("Сколько файлов небходимо создать ?");
                int CreatFile = int.Parse(Console.ReadLine());
                for (int i = 0; i < CreatFile;i++)
                {
                    List_Folder();
                    CreateFile();
                }
                break;
            
            case "Read File":
                Console.WriteLine("Enter in Menu?: ");
                string Menu2 = Console.ReadLine();
                if (Menu2 == "Yes")
                {
                    ReturnMenu();
                }
                else if(Menu2 == "No")
                {
                    List_Folder();
                    Read_Source();
                    ReturnMenu();
                }
                break;
            
            case "Edit File":
                
                List_Folder();
                
                Console.WriteLine("Load File");
                Console.WriteLine("Delet File");
                Console.WriteLine("Edit File");
                Console.WriteLine();
                Console.WriteLine("Выбирите мод");
                string EditFile = Console.ReadLine();
                
                switch (EditFile)
                {
                    case "Load File":
                        
                        break;
                    
                    case "Delet File":
                        
                        Console.WriteLine("Сколько файлов нужно удалить");
                        int DelFile = int.Parse(Console.ReadLine());
                        for (int i = 0; i < DelFile; i++)
                        {
                            DeleteFile();
                        }
                        break;
                    
                    case "Edit File":
                        
                        break;
                }
                
                break;
            
            case "Exit":
                Exit();
                break;
        }

        //Endl;


    }   
}*/