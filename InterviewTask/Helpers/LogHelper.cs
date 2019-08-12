using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTask.Helpers
{
    public class LogHelper
    {
        private static LogBase logger = null;
        public static void Log(FileLogger target, string message)
        {
            logger = new FileLogger();
            logger.Log(message);
        }
    }
}