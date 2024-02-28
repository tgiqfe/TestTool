using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTool.Manifest.Result;

namespace TestTool.Manifest
{
    internal class Exam
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TestType Test { get; set; }
        public string Text { get; set; }

        public ReturnCode ReturnCode { get; set; }

        
        public string OutputText { get; set; }
        

    }
}
