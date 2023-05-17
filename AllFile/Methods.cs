namespace Owner;

public class Methods
{
    public static void SearchFolder()
    {
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
    }

    public static void SearchFile()
    {
        Console.WriteLine();
        Console.WriteLine("Введите путь до файла"+ "   "+"../../../Users=>");
        string WaySearchFile = Console.ReadLine();
        string[] SearchFileName = Directory.GetFiles(WaySearchFile);
        foreach (string ReadFileName in SearchFileName )
        {
            Console.WriteLine(ReadFileName);
        }
        Console.WriteLine();
    }

    public static void CreateFolder()
    {
        Console.WriteLine("Введите путь созранения Папки"+ "   "+"../../../Users=>");
        string WayFolder = Console.ReadLine();
        Console.WriteLine("Введите Имя папки");
        string FolderName = Console.ReadLine();

        string CreateFolder = Path.Combine(WayFolder, FolderName);
        Directory.CreateDirectory(CreateFolder);
        Console.WriteLine("Папка успешно создана");
    }

    public static void CreateFile()
    {
        Console.WriteLine("Введите путь создания Файла"+ "   "+"../../../Users=>");
        string WayFile = Console.ReadLine();
        Console.WriteLine("Введите Имя Файла");
        string FileName = Console.ReadLine();

        string CreateFile = Path.Combine(WayFile, FileName);
        File.Create(CreateFile);
        Console.WriteLine("Фаил Успешно создан");
    }

    public static void DeleteFolder()
    {
        Console.WriteLine("Введите путь для удаления элементов");
        string WayDelElement1 = Console.ReadLine();
        Console.WriteLine("Введите Имя элемента");
        string DelElementName1 = Console.ReadLine();
        string DelFolder = Path.Combine(WayDelElement1, DelElementName1);
        Directory.Delete(DelFolder);
    }
    
    public static void DeleteFile()
    {
        Console.WriteLine("Введите путь для удаления элементов");
        string WayDelElement2 = Console.ReadLine();
        Console.WriteLine("Введите Имя элемента");
        string DelElementName2 = Console.ReadLine();
        string DelFile = Path.Combine(WayDelElement2, DelElementName2);
        File.Delete(DelFile);
    }

    public static void ReadElement()
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
    
    public static void EditElement()
    {
        Console.WriteLine("Открыть фаил для изменения ");
        Console.WriteLine("Введите путь файла");
        string WayEditFile = Console.ReadLine();
        Console.WriteLine("Ввелите имя файла");
        string EditFileName = Console.ReadLine();

        string EditFilePath = Path.Combine(WayEditFile, EditFileName);
    }

    public static void ConvertElement()
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
}