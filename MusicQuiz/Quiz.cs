using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace MusicQuiz
{
    static class Quiz
    {
        static public List<string> listOfMusic = new List<string>();

        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomStartPartInMusic = false;
        static public string lastFolder = "";
        static public bool allFolders = false;
        static public string nameOfSong;
        static string registryKeyName = "Software\\MusicGame\\Quiz\\";


        static public void AddMusic()
        {
            try
            {
                string[] music_files = Directory.GetFiles(lastFolder, "*.mp3",
                                        allFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                listOfMusic.Clear();
                listOfMusic.AddRange(music_files);
            }
            catch
            {

            }
        }

        public static void WriteSettings()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(registryKeyName);
                if(rk == null)
                {
                    return;
                }
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("Random", randomStartPartInMusic);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllFolders", allFolders);
            }
            finally
            {
                if(rk != null)
                {
                    rk.Close();
                }
            }
        }

        public static void ReadSettings()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(registryKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    randomStartPartInMusic = Convert.ToBoolean(rk.GetValue("Random"));
                    gameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    allFolders = Convert.ToBoolean(rk.GetValue("AllFolders"));
                }
            }
            finally
            {
                if (rk != null)
                {
                    rk.Close();
                }
            }
        }
    }
}
