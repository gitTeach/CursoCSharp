﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.DInjection
{
    public class ClassType<i, t> : IClassType
    {
        public ClassType()
        {

        }

        public Type GetClass()
        {
            return typeof(t);
        }

        public Type GetInterface()
        {
            return typeof(i);
        }
    }
}
