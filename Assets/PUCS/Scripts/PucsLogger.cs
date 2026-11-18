using UnityEngine;

namespace PUCS.Scripts
{
    public enum LogType
    {
        Info,
        Warning,
        Error
    }
    public static class PucsLogger
    {
        public static void Log(string message, LogType logType = LogType.Info)
        {
            Debug.Log($"[PUCS {logType}] {message}");
        }
    }
}