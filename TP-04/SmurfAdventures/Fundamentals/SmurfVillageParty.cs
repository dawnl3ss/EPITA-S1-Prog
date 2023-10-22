namespace SmurfAdventures.Fundamentals;

public class SmurfVillageParty
{
    public static uint CountGuest(string filePath)
    {
        uint num = 0;
        
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    sr.ReadLine();
                    num++;
                }
            }
        }
        catch
        {
            throw new FileNotFoundException("File in 'filePath' not found.");
        }

        return num;
    }

    public static bool AddSmurf(string filePath, string smurfName)
    {
        if (smurfName == "")
            return false;
        
        string list = "";
        
        try
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
            
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    list += sr.ReadLine() + "\n";
                }

                list += smurfName + "\n";
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(list);
            }

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static void RemoveSmurf(string filePath, string smurfName)
    {
        string list = "";
        
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    string? name = sr.ReadLine();
                    
                    if (smurfName != name)
                        list += name + "\n";
                }
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(list);
            }
        }
        catch
        {
            throw new FileNotFoundException("File can not be opened.");
        }
    }

    public static bool IsInvited(string filePath, string smurfName)
    {
        bool isInvited = false;
        
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    if (sr.ReadLine() == smurfName)
                        return true;
                }
            }
        }
        catch
        {
            throw new FileNotFoundException("File can not be opened.");
        }

        return isInvited;
    }

    public static int CountOcc(string filePath, string smurfName)
    {
        int numOcc = 0;
        
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    if (sr.ReadLine() == smurfName)
                        numOcc++;
                }
            }
        }
        catch
        {
            throw new FileNotFoundException("File can not be opened.");
        }

        return numOcc;
    }

    public static bool RemoveDuplicates(string filePath)
    {
        string guests = "";
        bool removed = false;
        
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    string? name = sr.ReadLine();

                    if (guests.Contains(name))
                        removed = true;
                    else
                        guests += name + "\n";
                }
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(guests);
            }
        }
        catch
        {
            throw new FileNotFoundException("File can not be opened.");
        }

        return removed;
    }


    public static bool RemoveImproperNames(string filePath, string validNames)
    {
        string valid = "";
        string guests = "";
        bool removed = false;
        
        try
        {
            using (StreamReader sr = new StreamReader(validNames))
            {
                while (sr.Peek() >= 0)
                {
                    valid += sr.ReadLine() + "\n";
                }
            }
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    string ?name = sr.ReadLine();

                    if (valid.Contains(name))
                        guests += name + "\n";
                    else
                        removed = true;
                }
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(guests);
            }
        }
        catch
        {
            throw new FileNotFoundException("File can not be opened.");
        }

        return removed;
    }
}