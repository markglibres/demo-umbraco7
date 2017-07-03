using Our.Umbraco.Ditto;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Zoombraco.ComponentModel.Caching;
using Zoombraco.Controllers;
using Zoombraco.Models;
using System.Collections.Generic;
using Umbraco.Web;
using Umbraco;
using umbraco;
using Umbraco.Core.Models;

namespace Umbraco7Demo.Core.Controllers
{
    [UmbracoOutputCache]
    public class ChequesController : ZoombracoController
    {
        public override ActionResult Index(RenderModel model)
        {
            var page = model.As<Cheques>();
            RenderPage<Cheques> viewModel = new RenderPage<Cheques>(page);

            viewModel.Content.Listing = model.Content.Children.OrderBy("chequeDate desc").As<Cheque>();

            return this.CurrentTemplate(viewModel);
        }
    }
}
