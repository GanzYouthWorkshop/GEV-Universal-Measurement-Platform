using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.ResultCalculation
{
    public class ResultCalculator
    {
        public string ScriptCode { get; set; }

        private Script<object> m_Script = null;

        public async void Run()
        {
            if(this.m_Script == null)
            {
                this.m_Script = CSharpScript.Create(this.ScriptCode);
            }

            ScriptState<object> result = await this.m_Script.RunAsync(null, null);
        }
    }
}
