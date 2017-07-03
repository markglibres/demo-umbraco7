using Zoombraco.Models;
using System.Collections.Generic;
using Umbraco.Core.Models;
using umbraco.NodeFactory;
namespace Umbraco7Demo.Core
{
    public class Cheques : Page
    {
        public virtual IEnumerable<ICheque> Listing { get; set; }
    }
}
