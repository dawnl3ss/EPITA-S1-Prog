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
    

    public static bool MirrorLetter(string filePath)
    {
        string content = "";
        
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string revLine = "";
                    
                    foreach (char chr in line)
                    {
                        revLine = chr + revLine;
                    }

                    content = revLine + "\n" + content;
                }
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(content);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }


    public static string FindHeaviestWord(string filePath)
    {
        int weight = 0;
        string word = "";

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    int total = 0;

                    foreach (char chr in line)
                    {
                        total += chr;
                    }

                    if (total > weight)
                    {
                        weight = total;
                        word = line;
                    }
                }
            }
        }
        catch
        {
            throw new FileNotFoundException("File can not be opened");
        }

        if (word == "")
            word = "File empty.";
        
        return word;
    }
}