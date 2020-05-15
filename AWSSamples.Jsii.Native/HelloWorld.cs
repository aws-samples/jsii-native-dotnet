// Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: MIT-0

using System.Collections.Generic;

namespace AWSSamples.Jsii.Native
{
    public class HelloWorld
    {
        public string SayHello(string name)
        {
            return $"Hello, {name}";
        }

        public int Fibonacci(int num)
        {
            var array = new List<int> {0, 1};
            for (var i = 2; i < num + 1; i++)
            {
                array.Add(array[i - 2] + array[i - 1]);
            }

            return array[num];
        }
    }
}