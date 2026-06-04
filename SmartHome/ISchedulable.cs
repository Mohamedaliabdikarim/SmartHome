using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public interface ISchedulable
    {
        DateTime NextRun { get; set; }
        void Schedule(DateTime time);
    }
}