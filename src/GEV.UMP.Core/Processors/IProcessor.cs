using GEV.UMP.Core.Samples;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Processors
{
    public interface IProcessor : IComponent
    {
        ConcurrentQueue<ISampleUnit> Samples { get; }

        void Run();

        event EventHandler<ISampleUnit> ProcessingComplete;
    }
}
