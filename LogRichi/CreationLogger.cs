using Serilog;
using Serilog.Sinks.File.Archive;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace LogRichi
{
    public class CreationLogger
    {
        private string globalFolderPath;
        private string globalNameLog;
        private string globalFolderPathC;

        public void CreationFolders(string folderPath, string nameLog)
        {
            globalFolderPath = folderPath;
            globalNameLog = nameLog;

            //Variable creation 
            string folderPathC = @$"{folderPath}\Logs\LogsComprimidos";

            globalFolderPathC = folderPathC;

            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MMMM").ToUpper();

            //Validation of the existence of the folders, if they do not exist, they are created
            if (!Directory.Exists(@$"{folderPath}\Logs"))
            {
                Directory.CreateDirectory(@$"{folderPath}\Logs");

                if (!Directory.Exists(@$"{folderPath}\Logs\Log"))
                {
                    Directory.CreateDirectory(@$"{folderPath}\Logs\Log");

                    if (!Directory.Exists(folderPathC))
                    {
                        Directory.CreateDirectory(folderPathC);

                        if (!Directory.Exists($@"{folderPathC}\{year}"))
                        {
                            Directory.CreateDirectory($@"{folderPathC}\{year}");

                            if (!Directory.Exists($@"{folderPathC}\{year}\{month}"))
                            {
                                Directory.CreateDirectory($@"{folderPathC}\{year}\{month}");

                                //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
                                Log.Logger = new LoggerConfiguration()
                                               .MinimumLevel.Debug()
                                               //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                                               //.Enrich.FromLogContext()
                                               .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                                               .CreateLogger();
                            }
                        }
                    }
                }
            }
            else if (!Directory.Exists(@$"{folderPath}\Logs\Log"))
            {
                Directory.CreateDirectory(@$"{folderPath}\Logs\Log");

                if (!Directory.Exists(folderPathC))
                {
                    Directory.CreateDirectory(folderPathC);

                    if (!Directory.Exists($@"{folderPathC}\{year}"))
                    {
                        Directory.CreateDirectory($@"{folderPathC}\{year}");

                        if (!Directory.Exists($@"{folderPathC}\{year}\{month}"))
                        {
                            Directory.CreateDirectory($@"{folderPathC}\{year}\{month}");

                            //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
                            Log.Logger = new LoggerConfiguration()
                                           .MinimumLevel.Debug()
                                           //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                                           //.Enrich.FromLogContext()
                                           .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                                           .CreateLogger();
                        }
                    }
                }
            }
            else if (!Directory.Exists(folderPathC))
            {
                Directory.CreateDirectory(folderPathC);

                if (!Directory.Exists($@"{folderPathC}\{year}"))
                {
                    Directory.CreateDirectory($@"{folderPathC}\{year}");

                    if (!Directory.Exists($@"{folderPathC}\{year}\{month}"))
                    {
                        Directory.CreateDirectory($@"{folderPathC}\{year}\{month}");

                        //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
                        Log.Logger = new LoggerConfiguration()
                                       .MinimumLevel.Debug()
                                       //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                                       //.Enrich.FromLogContext()
                                       .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                                       .CreateLogger();
                    }
                }
            }
            else if (!Directory.Exists($@"{folderPathC}\{year}"))
            {
                Directory.CreateDirectory($@"{folderPathC}\{year}");

                if (!Directory.Exists($@"{folderPathC}\{year}\{month}"))
                {
                    Directory.CreateDirectory($@"{folderPathC}\{year}\{month}");

                    //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
                    Log.Logger = new LoggerConfiguration()
                                   .MinimumLevel.Debug()
                                   //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                                   //.Enrich.FromLogContext()
                                   .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                                   .CreateLogger();
                }
            }
            else if (!Directory.Exists($@"{folderPathC}\{year}\{month}"))
            {
                Directory.CreateDirectory($@"{folderPathC}\{year}\{month}");

                //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
                Log.Logger = new LoggerConfiguration()
                               .MinimumLevel.Debug()
                               //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                               //.Enrich.FromLogContext()
                               .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                               .CreateLogger();
            }
            else
            {
                //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
                Log.Logger = new LoggerConfiguration()
                               .MinimumLevel.Debug()
                               //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                               //.Enrich.FromLogContext()
                               .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                               .CreateLogger();
            }
        }
        //public void Verbose(string mensaje)
        //{
        //    string year = DateTime.Now.ToString("yyyy");
        //    string month = DateTime.Now.ToString("MMMM").ToUpper();
        //    //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
        //    Log.Logger = new LoggerConfiguration()
        //                   .MinimumLevel.Debug()
        //                   //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
        //                   //.Enrich.FromLogContext()
        //                   .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
        //                   .CreateLogger();
        //    Log.Verbose(mensaje);
        //    CallItAfterClosingIt();
        //}
        //public void Debug(string mensaje)
        //{
        //    string year = DateTime.Now.ToString("yyyy");
        //    string month = DateTime.Now.ToString("MMMM").ToUpper();
        //    //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
        //    Log.Logger = new LoggerConfiguration()
        //                   .MinimumLevel.Debug()
        //                   //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
        //                   //.Enrich.FromLogContext()
        //                   .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
        //                   .CreateLogger();
        //    Log.Debug(mensaje);
        //    Log.CloseAndFlush();
        //    EditLastLine();
        //    CallItAfterClosingIt();
        //}
        public void Information(string mensaje)
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MMMM").ToUpper();
            //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
            Log.Logger = new LoggerConfiguration()
                           .MinimumLevel.Debug()
                           //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                           //.Enrich.FromLogContext()
                           .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                           .CreateLogger();
            Log.Information(mensaje);
            Log.CloseAndFlush();
            EditLastLine();
            CallItAfterClosingIt();
        }
        public void Warning(string mensaje)
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MMMM").ToUpper();
            //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
            Log.Logger = new LoggerConfiguration()
                           .MinimumLevel.Debug()
                           //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                           //.Enrich.FromLogContext()
                           .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                           .CreateLogger();
            Log.Warning(mensaje);
            Log.CloseAndFlush();
            EditLastLine();
            CallItAfterClosingIt();
        }
        public void Error(Exception ex, string mensaje)
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MMMM").ToUpper();
            string lineError = ErrorLine(ex);
            //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
            Log.Logger = new LoggerConfiguration()
                           .MinimumLevel.Debug()
                           //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                           //.Enrich.FromLogContext()
                           .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                           .CreateLogger();
            Log.Error($"Error on the line: {lineError} {mensaje}");
            Log.CloseAndFlush();
            EditLastLine();
            CallItAfterClosingIt();
        }
        public void Fatal(Exception ex, string mensaje)
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MMMM").ToUpper();
            string lineError = ErrorLine(ex);
            //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
            Log.Logger = new LoggerConfiguration()
                           .MinimumLevel.Debug()
                           //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                           //.Enrich.FromLogContext()
                           .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                           .CreateLogger();
            Log.Fatal($"Error fatal on the line: {lineError} {mensaje}");
            Log.CloseAndFlush();
            EditLastLine();
            CallItAfterClosingIt();
        }    

        public void CallItAfterClosingIt()
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MMMM").ToUpper();
            //The log is created, with the functions of rotating by day, automatically deleting every 7 days, compressing the log, all with the help of serilog
            Log.Logger = new LoggerConfiguration()
                           .MinimumLevel.Debug()
                           //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                           //.Enrich.FromLogContext()
                           .WriteTo.File(@$"{globalFolderPath}\Logs\Log\{globalNameLog}.txt", hooks: new ArchiveHooks(CompressionLevel.Fastest, $@"{globalFolderPathC}\{year}\{month}"), outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Exception} {Message:lj}{NewLine}", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                           .CreateLogger();
        }
        public string ErrorLine(Exception ex)
        {
            string exMessage = ex.ToString();
            int index = exMessage.IndexOf("line ");
            string line = exMessage.Substring(index + 5);
            return line;
        }
        public void EditLastLine()
        {
            //Variable creation 
            string day = DateTime.Now.ToString("dd");
            string month = DateTime.Now.ToString("MM");
            string year = DateTime.Now.ToString("yyyy");
            StreamWriter temporary = new StreamWriter($@"{globalFolderPath}\Logs\Log\" + "temporary.txt", true); //A temporary txt is created
            List<string> line = new List<string>();

            //Get all the lines of the current file, entering them into a list of strings
            foreach (var item in File.ReadAllLines(@$"{globalFolderPath}\Logs\Log\{globalNameLog}{year}{month}{day}.txt"))
            {
                line.Add(item);
            }

            int j = line.Count - 1;
            //The previously obtained lines are entered in descending order
            for (int i = -1; i < line.Count - 1; i++)
            {
                if (j == line.Count - 1)
                {
                    temporary.WriteLine(line[j]);
                    j--;
                }
                else
                {
                    temporary.WriteLine(line[i]);
                }
            }

            temporary.Flush();
            temporary.Close();

            //Finally the old file is deleted and a new one is created
            File.Delete($@"{globalFolderPath}\Logs\Log\{globalNameLog}{year}{month}{day}.txt");
            File.Move($@"{globalFolderPath}\Logs\Log\" + "temporary.txt", $@"{globalFolderPath}\Logs\Log\{globalNameLog}{year}{month}{day}.txt");
        }
    }
}
