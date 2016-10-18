using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Data;

namespace ReadData
{
    static public class FileAnalysis
    {
        private static void Initialization()
        {
            if (!Directory.Exists(EnvironmentData.UserDataDir))
                Directory.CreateDirectory(EnvironmentData.UserDataDir);
            if (!Directory.Exists(EnvironmentData.LocalRecord))
                Directory.CreateDirectory(EnvironmentData.LocalRecord);
        }

        static FileAnalysis()
        {
            string dir = Environment.CurrentDirectory + "\\";

            EnvironmentData.RootDir = dir;
            EnvironmentData.UserDataDir = dir + "users\\";
            EnvironmentData.LocalRecord = dir + "records\\";

            Initialization();
        }

        static public string ReadUsersFile(string name)
        {
            if (!File.Exists(EnvironmentData.UserDataDir + name))
                return Flags.FILE_NOT_EXISTS;

            StreamReader sr = new StreamReader(EnvironmentData.UserDataDir + name);
            string get = sr.ReadToEnd();
            sr.Close();
            return get;
        }

        static public bool CreateUsersFile(string name,string content ,bool overWrite = false)
        {
            if (File.Exists(EnvironmentData.UserDataDir + name))
                if (!overWrite)
                    return false;

            File.Delete(EnvironmentData.UserDataDir + name);
            StreamWriter sw = File.CreateText(EnvironmentData.UserDataDir + name);
            sw.Write(content);
            sw.Close();
            return true;
        }

        static public bool DeleteUserFile(string name)
        {
            if (!File.Exists(EnvironmentData.UserDataDir + name))
                return false;

            File.Delete(EnvironmentData.UserDataDir + name);
            return true;
        }
    }
}
