using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApplication1.Config;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserConfig _userConfig;
        public string UserName { get; set; }
        public string UserNo { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IOptions<UserConfig> userConfig)
        {
            _logger = logger;
            _userConfig = userConfig.Value;
        }

        public void OnGet()
        {
            UserName = _userConfig.UserName;
            UserNo = _userConfig.UserNo;
        }
    }
}
