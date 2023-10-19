namespace SmurfAdventures.Enhancements;

public class MayorElection
{

    public static void CreateReportFile(string directoryPath, string reportFilePath)
    {
        string report = "File Report :";
        DirectoryInfo di = new DirectoryInfo(directoryPath);
        
        foreach (var file in di.GetFiles())
        {
            report += "\n\nCandidate : " + file.Name + "\nSpeech size in bytes : " + file.Length +
                      "\nLast modification date : " + file.LastWriteTime;
        }

        try
        {
            if (!File.Exists(directoryPath + "/" + reportFilePath))
                File.Create(directoryPath + "/" + reportFilePath).Close();
            
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

    public static void Main()
    {
        CreateReportFile("candidateDirectory", "report.txt");
    }
    
}