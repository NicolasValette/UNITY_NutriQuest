﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriQuest.Interfaces
{
    public interface IObservable<T>
    {
        public event Action<T> OnValueChange;
        public T Value { get; }
    }
}
