namespace Owner;

public class LoadFile
{
    public static void LoadingMainFiles()
    {
        string Folder = ("../../../");
        string PFolder = ("../../../Users");
        if (!Directory.Exists(PFolder)) // Create Folder "Users"
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
            File.Create(@"../../../Users//Account"); //Create File "Password on Users"
            File.SetAttributes(path, FileAttributes.Hidden);
        }
        else
        {
            File.SetAttributes(path, FileAttributes.Hidden);
        }

    }

    public static void CreateNameFolder()
    {
        Register Reg = new Register();
        string UserWorkFolder = @"../../../Users";
        string PUserWorkFolder = $@"../../../Users/{Reg.UserName}";
        if (!Directory.Exists(PUserWorkFolder))
        {
            string WorkFolder = Path.Combine(UserWorkFolder, $"{Reg.UserName}");
            Directory.CreateDirectory(PUserWorkFolder);
        }
    }

    
}