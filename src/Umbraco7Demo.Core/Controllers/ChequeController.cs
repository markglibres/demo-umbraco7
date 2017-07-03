using Our.Umbraco.Ditto;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Zoombraco.ComponentModel.Caching;
using Zoombraco.Controllers;
using Zoombraco.Models;

namespace Umbraco7Demo.Core.Controllers
{
    [UmbracoOutputCache]
    public class ChequeController : ZoombracoController
    {
        /// <inheritdoc />
        public override ActionResult Index(RenderModel model)
        {
            var page = model.As<Cheque>();
            RenderPage<Cheque> viewModel = new RenderPage<Cheque>(page);

            return this.CurrentTemplate(viewModel);
        }
    }
}
