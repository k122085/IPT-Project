using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace FileWatcherService
{
    
    
    public class FileWatcher
    {
        
            
        private FileSystemWatcher _fileWatcher;
        string DestPath = ConfigurationManager.AppSettings["DestPath"];

        public FileWatcher()
        {
            _fileWatcher = new FileSystemWatcher(PathLocation());
            _fileWatcher.Created += new FileSystemEventHandler (_fileWatcher_Created);
            _fileWatcher.Deleted += new FileSystemEventHandler (_fileWatcher_Deleted);
            _fileWatcher.Changed += new FileSystemEventHandler (_fileWatcher_Changed);
            _fileWatcher.EnableRaisingEvents = true;
        }

        private string PathLocation()
        {
            string value = string.Empty;
            try
            {
                value = ConfigurationManager.AppSettings["WatchPath"];
               
            }
            catch (Exception ex)
            {
                
                
            }
            return value;
        }

        void _fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {

            ShowFileName _file = new ShowFileName("Changed");
            Logger.Log(string.Format("File Changed: Path:{0} Name:{1}", PathLocation(), e.Name));
            string SourceFile = Path.Combine(PathLocation(), e.Name);
            string DestFile = Path.Combine(DestPath, e.Name);
            File.Copy(SourceFile, DestFile,true);
            _file.setcount(1);
            _file.show(e.Name);
            _file.Show();
        }

        void _fileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            
            ShowFileName _file = new ShowFileName("Created");
            Logger.Log(string.Format("File Created: Path:{0} Name:{1}", PathLocation(), e.Name));
            _file.setcount(2);
            _file.show(e.Name);
            _file.Show();
        }

        void _fileWatcher_Deleted(object sender, FileSystemEventArgs e)
        {

            ShowFileName _file = new ShowFileName("Deleted");
            Logger.Log(string.Format("File Deleted: Path:{0} Name:{1}", PathLocation(), e.Name));
            _file.setcount(3);
            _file.show(e.Name);
            _file.Show();
        }

    }
}
