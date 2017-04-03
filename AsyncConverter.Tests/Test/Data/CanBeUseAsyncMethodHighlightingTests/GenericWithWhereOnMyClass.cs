﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class MyClass
    {
        public async Task TestAsync()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            Method(5);
        }

        public void Method<T>(T i)
        {
        }

        public Task MethodAsync<T>(T i) where T : MyClass
        {
            return Task.CompletedTask;
        }
    }
}
