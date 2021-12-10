// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;
using Microsoft.Extensions.Options;

namespace BicepFlex.Models
{
    public class LoggerProvider<T> : IOptionsMonitor<T>
    {
        private readonly T options;

        public LoggerProvider(T options)
        {
            this.options = options;
        }

        public T CurrentValue => options;

        public T Get(string name) => options;

        public IDisposable OnChange(Action<T, string> listener) => new NullDisposable();

        private class NullDisposable : IDisposable
        {
            public void Dispose() { }
        }
    }
}
