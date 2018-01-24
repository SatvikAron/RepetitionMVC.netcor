using RepetitionclassWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepetitionclassWebApp.TimeServices
{
    public class RealTimeProvide : ITimeProvider
    {
        public DateTime Now { get => DateTime.Now; set => throw new NotImplementedException(); }

    }
}
