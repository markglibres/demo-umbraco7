using System;
using Zoombraco.Models;

namespace Umbraco7Demo.Core
{
    public class Cheque : Page, ICheque
    {
        public virtual string ChequeName { get; set; }
        public virtual double ChequeAmount { get; set; }
        public virtual DateTime ChequeDate { get; set; }
        public virtual string ChequePay { get; set; }
    }
}
