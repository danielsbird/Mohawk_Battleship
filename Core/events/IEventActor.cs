﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBC.Core.Events
{
    public interface IEventActor
    {
        void ReflectEvent(Event ev);
    }
}