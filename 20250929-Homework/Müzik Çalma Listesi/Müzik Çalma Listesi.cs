using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using NAudio.Wave; //.Net 9 da audioPlayer Olmadıgı İçin Ekstra Nuget Paketi Kurdum

public class MusicPlayer
{
    private IWavePlayer? outputDevice;
    private AudioFileReader? audioFile;

    private List<string> playlist;
    private int currentTrackIndex = -1;
    private bool isShuffling = false;
    private Random random = new Random();

    public MusicPlayer(List<string> initialPlaylist)
    {
        playlist = initialPlaylist;
    }

    private void PlayTrack(int trackIndex)
    {
        Stop();

        if (playlist.Count == 0 || trackIndex < 0 || trackIndex >= playlist.Count)
        {
            currentTrackIndex = -1;
            return;
        }

        currentTrackIndex = trackIndex;
        var trackPath = playlist[currentTrackIndex];

        audioFile = new AudioFileReader(trackPath);
        outputDevice = new WaveOutEvent();
        outputDevice.PlaybackStopped += OnPlaybackStopped;
        
        outputDevice.Init(audioFile);
        outputDevice.Play();

        Console.WriteLine($"\nŞimdi Çalıyor: {Path.GetFileName(trackPath)}");
    }

    public void NextSong()
    {
        int nextIndex;
        
        if (isShuffling)
        {
            if (playlist.Count <= 1)
            {
                nextIndex = 0;
            }
            else
            {
                do
                {
                    nextIndex = random.Next(0, playlist.Count);
                } while (nextIndex == currentTrackIndex);
            }
        }
        else
        {
            nextIndex = currentTrackIndex + 1;
            if (nextIndex >= playlist.Count)
            {
                nextIndex = 0;
            }
        }
        
        PlayTrack(nextIndex);
    }

    public void PreviousSong()
    {
        int prevIndex;

        if (isShuffling)
        {
            NextSong(); 
        }
        else
        {
            prevIndex = currentTrackIndex - 1;
            if (prevIndex < 0)
            {
                prevIndex = playlist.Count - 1;
            }
            PlayTrack(prevIndex);
        }
    }
    
    public void ToggleShuffle()
    {
        isShuffling = !isShuffling;
        Console.WriteLine(isShuffling ? "\nKarıştırma modu: AÇIK" : "\nKarıştırma modu: KAPALI");
    }

    public void Stop()
    {
        if (outputDevice != null)
        {
            outputDevice.PlaybackStopped -= OnPlaybackStopped;
            outputDevice.Stop();
            outputDevice.Dispose();
            outputDevice = null;
        }
        if (audioFile != null)
        {
            audioFile.Dispose();
            audioFile = null;
        }
    }
    
    private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
    {
        if (currentTrackIndex != -1 && audioFile != null && audioFile.CurrentTime >= audioFile.TotalTime)
        {
             NextSong();
        }
    }
}