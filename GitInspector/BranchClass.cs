using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitInspector
{
    internal class BranchClass
    {
        public BranchClass Instance = new BranchClass(true);

        private BranchClass(bool needsIHelloWorldFactory, bool ignoreFactoryRequest = true, bool ignoreIgnoreFactoryRequest = true)
        {
        }
    }
}
