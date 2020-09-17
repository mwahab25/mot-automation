﻿using System;
using System.IO;
using Newtonsoft.Json;
using Framework.Logging;
using NUnit.Framework;

namespace Framework
{
    public static class FW
    {
        [ThreadStatic] public static DirectoryInfo CurrentTestDirectory;

        [ThreadStatic] private static Logger _logger;

        private static Config _configuration;

        public static string WORKSPACE_DIRECTORY => Path.GetFullPath(@"../../../../");

        public static Logger Log => _logger ?? throw new NullReferenceException("_logger is null. SetLogger() first.");

         public static Config Config => _configuration ?? throw new Exception("_configuration null. Call Init() first.");

        public static void Init()
        {
            if (_configuration == null)
            {
                var jsonString = File.ReadAllText(WORKSPACE_DIRECTORY + "/config.json");
                _configuration = JsonConvert.DeserializeObject<Config>(jsonString);
            }
        }

        public static DirectoryInfo CreateTestResultsDirectory()
        {
            var testDirectory = WORKSPACE_DIRECTORY + "TestResults";

            if (Directory.Exists(testDirectory))
            {
                Directory.Delete(testDirectory, recursive: true);
            }

            return Directory.CreateDirectory(testDirectory);
        }

        public static void SetLogger()
        {
            lock (_setLoggerLock)
            {
                var testResultsDir = WORKSPACE_DIRECTORY + "TestResults";
                var testName = TestContext.CurrentContext.Test.Name;
                var fullPath = $"{testResultsDir}/{testName}";

                if (Directory.Exists(fullPath))
                {
                    CurrentTestDirectory = Directory.CreateDirectory(fullPath + TestContext.CurrentContext.Test.ID);
                }
                else
                {
                    CurrentTestDirectory = Directory.CreateDirectory(fullPath);
                }

                _logger = new Logger(testName, CurrentTestDirectory.FullName + "/log.txt");
            }
        }

        private static object _setLoggerLock = new object();
    }

    public class Config
    {
        public DriverSettings Driver { get; set; }
    }

    public class DriverSettings
    {
        public string Browser { get; set; }

        public string Type { get; set; }

        public int Wait { get; set; }
    }
}
