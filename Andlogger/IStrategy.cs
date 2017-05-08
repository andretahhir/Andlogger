﻿namespace Andlogger
{
    public interface IStrategy
    {
        void Save(Log log);
    }

    public enum Level
    {
        Debug,
        Info,
        Warning,
        Error
    }
}