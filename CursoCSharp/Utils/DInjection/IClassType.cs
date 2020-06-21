using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.DInjection
{
    public interface IClassType
    {
        Type GetInterface();
        Type GetClass();
    }
}
