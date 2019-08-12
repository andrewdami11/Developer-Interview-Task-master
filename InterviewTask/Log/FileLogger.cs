using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace InterviewTask.Helpers
{
    public class FileLogger : LogBase
    {
        public string filePath = @"~\Log\MarieCurieLog.txt"; 
        public override void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}