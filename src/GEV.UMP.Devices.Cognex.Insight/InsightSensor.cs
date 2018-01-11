using GEV.UMP.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEV.UMP.Core;
using GEV.UMP.Core.Data;
using GEV.UMP.Core.Samples;
using System.Collections.Concurrent;

namespace GEV.UMP.Devices.Cognex.Insight
{
    public class InsightSensor : IProcessor
    {
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ConcurrentQueue<ISampleUnit> Samples
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ComponentStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<StatusMessage> StatusMessages
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler<ISampleUnit> ProcessingComplete;

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
