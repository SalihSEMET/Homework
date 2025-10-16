using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Dosya indirme simülasyonu başlatılıyor...");
        Console.WriteLine("------------------------------------------");
        
        var filesToDownload = new List<string>
        {
            "film_arsivi.zip",
            "oyun_setup.exe",
            "guncel_suruculer.msi",
            "proje_dokumanlari.rar"
        };
        
        var downloadProgresses = filesToDownload.Select((file, index) =>
            new DownloadProgress(file, index, filesToDownload.Count)
        ).ToList();
        
        var downloadTasks = new List<Task>();
        foreach (var progress in downloadProgresses)
        {
            var progressReporter = new Progress<int>(percent =>
            {
                progress.UpdateProgress(percent);
            });

            downloadTasks.Add(DownloadFileAsync(progress.FileName, progressReporter));
        }
        await Task.WhenAll(downloadTasks);
        
        Console.SetCursorPosition(0, filesToDownload.Count + 2);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Tüm dosyaların indirilmesi tamamlandı!");
    }
    
    public static async Task DownloadFileAsync(string fileName, IProgress<int> progress)
    {
        Console.WriteLine($"'{fileName}' indirmesi başlıyor...");
        
        for (int i = 0; i <= 100; i++)
        {
            await Task.Delay(Random.Shared.Next(20, 100));
            progress.Report(i);
        }
    }
}

public class DownloadProgress
{
    public string FileName { get; }
    private readonly int _consoleRow;
    private readonly object _lock = new object();

    public DownloadProgress(string fileName, int index, int totalFiles)
    {
        FileName = fileName;
        _consoleRow = index + 2; 
        
        lock (_lock)
        {
            Console.SetCursorPosition(0, _consoleRow);
            Console.Write($"{FileName,-25} | [                                        ] 0%");
        }
    }

    public void UpdateProgress(int percent)
    {
        lock (_lock)
        {
            Console.SetCursorPosition(0, _consoleRow);

            int progressBarWidth = 40;
            int progressChars = (int)((percent / 100.0) * progressBarWidth);

            string progressBar = new string('█', progressChars) + new string(' ', progressBarWidth - progressChars);

            Console.Write($"{FileName,-25} | [{progressBar}] {percent,3}%");
        }
    }
}