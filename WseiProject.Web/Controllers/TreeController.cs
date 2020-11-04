using Microsoft.AspNetCore.Mvc;
using WseiProject.Web.Models;
using WseiProject.Web.Models.Responses;

namespace WseiProject.Web.Controllers
{
    [ApiController]
    [Route("api/tree")]
    public class TreeController : ControllerBase
    {
        /// <summary>
        /// Adds new tree to the database.
        /// </summary>
        public AddNewItemResponse Post(TreeModel tree)
        {
            bool isValid = tree.IsValid();
            AddNewItemResponse response = new AddNewItemResponse() { IsSuccess = isValid };
            return response;
        }
    }
}
