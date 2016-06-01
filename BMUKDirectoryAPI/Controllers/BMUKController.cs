using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BMUKDirectoryAPI.Models;

namespace BMUKDirectoryAPI.Controllers
{
    [RoutePrefix("api/BMUK")]
    public class BMUKController : ApiController
    {
        private readonly BMUKContext context = new BMUKContext();

        [Route("GetHeadMembers")]
        public IEnumerable<DirectoryData> GetHeadMembers()
        {
            return context.DirectoryData.Where(m => m.ParentId == -1).AsEnumerable();
        }
    }
}