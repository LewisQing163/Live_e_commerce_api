using Live_e_commerce.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using static System.Net.Mime.MediaTypeNames;
namespace Live_e_commerce.IReptile
{
    public interface IReptileService:IApplicationService
    {
        Task<ReturnResult<int>> HtmlRequest(string requestUrl);
    }
}
