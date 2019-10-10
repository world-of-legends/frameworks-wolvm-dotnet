﻿using System;
using wolSystem.expressions;
using wolvm;

namespace wolSystem
{
    public class Main : VMLibrary
    {
        public Main()
        {
            expressions.Add("print", new PrintExpression());
            expressions.Add("input", new InputExpression());
            expressions.Add("sleep", new SleepExpression());
            expressions.Add("setconsolebg", new ConsoleBgExpression());
        }
    }
}
