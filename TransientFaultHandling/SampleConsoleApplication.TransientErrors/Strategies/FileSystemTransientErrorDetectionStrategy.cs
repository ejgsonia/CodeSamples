﻿using System;
using System.IO;
using Microsoft.Practices.TransientFaultHandling;

namespace SampleConsoleApplication.TransientErrors.Strategies
{
    public class FileSystemTransientErrorDetectionStrategy : ITransientErrorDetectionStrategy
    {
        #region ITransientErrorDetectionStrategy Members

        public bool IsTransient(Exception ex)
        {
            return ex is FileNotFoundException;
        }

        #endregion
    }
}