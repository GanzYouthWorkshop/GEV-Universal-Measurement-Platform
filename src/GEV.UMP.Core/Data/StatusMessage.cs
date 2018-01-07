using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data
{
    public struct StatusMessage
    {
        public enum Type
        {
            Info,
            Debug,
            Warning,
            Error,
            Event
        }

        public Type MessageType { get; set; }
        public string Message { get; set; }

        public StatusMessage(Type type, string message)
        {
            this.MessageType = type;
            this.Message = message;
        }
    }
}
