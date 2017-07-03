using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Umbraco7Demo.Core
{
    public interface ICheque
    {
        [Required]
        string ChequeName { get; set; }
        [RegularExpression(@"^\d+(\.\d{1,2})$", ErrorMessage = "Amount must be in numeric format with two maximum decimal places.")]
        double ChequeAmount { get; set; }
        [Required]
        DateTime ChequeDate { get; set; }
    }
}
