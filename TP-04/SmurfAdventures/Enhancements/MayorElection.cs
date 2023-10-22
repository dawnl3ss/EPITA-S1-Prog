namespace SmurfAdventures.Enhancements;

public class MayorElection
{

    public static void CreateReportFile(string directoryPath, string reportFilePath)
    {
        string report = "File Report :";

        try
        {
            if (!File.Exists(directoryPath + "/" + reportFilePath))
                File.Create(directoryPath + "/" + reportFilePath).Close();
            
            DirectoryInfo di = new DirectoryInfo(directoryPath);
        
            foreach (var file in di.GetFiles())
            {
                report += "\n\nCandidate : " + file.Name + "\nSpeech size in bytes : " + file.Length +
                          "\nLast modification date : " + file.LastWriteTime;
            }
            
            using (StreamWriter sw = new StreamWriter(directoryPath + "/" + reportFilePath))
            {
                sw.Write(report);
            }
        }
        catch
        {
            throw new ArgumentException("directoryPath or reportFilePath is incorrect.");
        }
    }

    public static void EncryptDocumentWithCaesar(string filePath, int key)
    {
        int modNum = 10;
        int modLetter = 26;

        int startNum = 48;
        int startCapLetter = 65;
        int startLetter = 97;

        string content = "";

        using (StreamReader sr = new StreamReader(filePath))
        {
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();

                foreach (char chr in line)
                {
                    if (key > 0)
                    {
                        if ((int)chr >= startNum && (int)chr <= startNum + modNum - 1)
                            content += (char)(startNum + (((int)chr + key - startNum) % modNum));

                        else if ((int)chr >= startCapLetter && (int)chr <= startCapLetter + modLetter - 1)
                            content += (char)(startCapLetter + (((int)chr + key - startCapLetter) % modLetter));

                        else if ((int)chr >= startLetter && (int)chr <= startLetter + modLetter - 1)
                            content += (char)(startLetter + (((int)chr + key - startLetter) % modLetter));
                        else
                            content += chr;
                    }
                    else if (key < 0)
                    {
                        if ((int)chr >= startNum && (int)chr <= startNum + modNum - 1)
                            content += (char)(startNum + ((((int)(chr + key - startNum) % startNum) + modNum) % modNum));

                        else if ((int)chr >= startCapLetter && (int)chr <= startCapLetter + modLetter - 1)
                            content += (char)(startCapLetter + ((((int)(chr + key - startCapLetter) % startCapLetter) + modLetter) % modLetter));

                        else if ((int)chr >= startLetter && (int)chr <= startLetter + modLetter - 1)
                            content += (char)(startLetter + ((((int)(chr + key - startLetter) % startLetter) + modLetter) % modLetter));
                        else
                            content += chr;
                    }
                    else
                        content += chr;
                }
            }
        }

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.Write(content);
        }
    }

    public static void SortVotes(string votesFilePath, string candidatesName, string sortedVotesFilePath)
    {
        
    }

    public static void Main()
    {
        //Smthng.
    }
}