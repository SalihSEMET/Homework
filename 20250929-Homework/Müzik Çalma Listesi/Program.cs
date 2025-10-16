class Program
{
    static void Main(string[] args)
    {
        // KENDİ MÜZİK DOSYALARINIZIN YOLLARINI BURAYA EKLEYİN!
        var songList = new List<string>
        {
            @"C:\Users\semet\OneDrive\Masaüstü\Yazılım\PushGithubHomework\Homework\Homework\29-09-2025-Homework\Müzik Çalma Listesi\Music\cascade-breathe-future-garage.wav",
            @"C:\Users\semet\OneDrive\Masaüstü\Yazılım\PushGithubHomework\Homework\Homework\29-09-2025-Homework\Müzik Çalma Listesi\Music\deep-abstract-ambient_snowcap.wav",
            @"C:\Users\semet\OneDrive\Masaüstü\Yazılım\PushGithubHomework\Homework\Homework\29-09-2025-Homework\Müzik Çalma Listesi\Music\the-last-point-beat-electronic-digital.wav"
        };

        var player = new MusicPlayer(songList);

        Console.WriteLine("Müzik Çalar Başlatıldı!");
        Console.WriteLine("-------------------------");
        Console.WriteLine("n: Sonraki Şarkı");
        Console.WriteLine("p: Önceki Şarkı");
        Console.WriteLine("s: Karıştırmayı Aç/Kapat (Shuffle)");
        Console.WriteLine("q: Çıkış");
        Console.WriteLine("-------------------------");

        player.NextSong();

        while (true)
        {
            char key = Console.ReadKey(true).KeyChar;

            if (key == 'n')
            {
                player.NextSong();
            }
            else if (key == 'p')
            {
                player.PreviousSong();
            }
            else if (key == 's')
            {
                player.ToggleShuffle();
            }
            else if (key == 'q')
            {
                Console.WriteLine("\nÇıkılıyor...");
                player.Stop();
                break;
            }
        }
    }
}