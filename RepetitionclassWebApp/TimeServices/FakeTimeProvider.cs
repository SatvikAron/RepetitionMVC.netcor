﻿using RepetitionclassWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepetitionclassWebApp.TimeServices
{
    public class FakeTimeProvider : ITimeProvider
    {
        private DateTime _now;
        public DateTime Now { get => _now; set => _now = value; }
    }
}
