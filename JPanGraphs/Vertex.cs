﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPanGraphs
{
    public class Vertex<T> where T : IComparable<T>
    {
        public T item;
        public Vertex(T value)
        {
            item = value;
        }
        public List<Vertex<T>> connections = new List<Vertex<T>>();
    }
}
