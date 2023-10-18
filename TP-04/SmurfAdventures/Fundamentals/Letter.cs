namespace SmurfAdventures.Fundamentals;

public class Letter
{
    public static void SendLetter(string villagePath, string message, uint houseNumber)
    {
        string content = "";
        string path = villagePath + "house" + houseNumber + ".txt";
        
        if (!File.Exists(path))
            File.Create(path).Close();
        
        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    content += sr.ReadLine() + "\n";
                }

                content += message + "\n";
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(content);
            }
        }
        catch (Exception e)
        {
            throw new FileNotFoundException("File can not be opened.");
        }
    }


    public static void MergeLetters(string dest, string src)
    {
        string srcContent = "";
        string destContent = "";

        try
        {
            using (StreamReader sr = new StreamReader(src))
            {
                while (sr.Peek() >= 0)
                {
                    srcContent += sr.ReadLine() + "\n";
                }
            }
            
            using (StreamReader sr = new StreamReader(dest))
            {
                while (sr.Peek() >= 0)
                {
                    destContent += sr.ReadLine() + "\n";
                }
            }
            
            using (StreamWriter sw = new StreamWriter(dest))
            {
                sw.Write(destContent + srcContent);
            }
        }
        catch
        {
            throw new FileNotFoundException("One of the file can not be opened.");
        }
    }
    
    
    public static void Main()
    {
        MergeLetters("file1.txt", "");
    }
    
}