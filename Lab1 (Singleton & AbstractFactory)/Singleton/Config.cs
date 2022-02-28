using System;
using System.ComponentModel.Design;
using System.Data;
using System.IO;

namespace DAOSS
{
    public class Config
    {
        private static string path = "config.txt";
        
        public string Login { get; init; }
        public string Password { get; init; }
        
        private static Config _instance;

        public static Config Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Config();
                }

                return _instance;
            }
        }

        private Config()
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("No file at this path");
            }

            var sr = new StreamReader(path);
            Login = sr.ReadLine();
            Password = sr.ReadLine();

            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                throw new DataException("File doesn't contain Login and/or password");
            }
            
            sr.Close();
        }

        public override string ToString()
        {
            return $"Login: {Login}\nPassword: {Password}";
        }
    }
}