using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaxxa.EnhancedDevelopment.Core.Comp.Interface
{
    public interface IRequiresShipResources
    {
        
        bool Satisfied { get;  }
                
        string StatusString { get; }

        bool UseResources();

    }
}
