namespace SmurfAdventures.Fundamentals;

public class Basics
{
    
    public static bool CheckExistence(string filePath)
    {
        return File.Exists(filePath);
    }

    public static bool CustomFileExists(string filePath)
    {
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                sr.Close();
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    public static bool MyWrite(string filePath, string message)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(message);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }


    public static string MyRead(string filePath)
    {
        string content = "";
        
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    content += sr.ReadLine() + "\n";
                }
            }
        }
        catch
        {
            throw new ArgumentException("File can not be read.");
        }

        return content;
    }

    public static void Main()
    {
        Console.WriteLine(MyRead("example"));
    }
}