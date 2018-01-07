using GEV.UMP.Core.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Configuration
{
    public class CommandLineParser
    {
        Dictionary<string, string> Values { get; } = new Dictionary<string, string>();

        public CommandLineParser(string[] args)
        {
            foreach(string arg in args)
            {
                if(arg[0] == '/')
                {
                    string[] argument = arg.Remove(0, 1).Split('=');

                    this.Values.Set(argument[0], argument[1]);
                }
            }
        }
    }
}
