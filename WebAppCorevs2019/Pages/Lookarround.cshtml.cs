using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppCorevs2019.Pages
{
    public class LookarroundModel : PageModel
    {
        private readonly ILogger<LookarroundModel> _logger;

        public LookarroundModel(ILogger<LookarroundModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}