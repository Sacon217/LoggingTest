using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LoggingTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogTrace("Estoy accediendo el Index");
            _logger.LogDebug("Estoy accediendo el Index");
            _logger.LogInformation(LogginId.CodigoEmergencia,"Estoy accediendo el Index");
            _logger.LogWarning("Estoy accediendo el Index");
            _logger.LogError("Estoy accediendo el Index");
            _logger.LogCritical("Estoy accediendo el Index");
            //_logger.LogInformation("Estoy accediendo el Index el {Time}",DateTime.UtcNow);
        }

        public class LogginId
        {
            public const int CodigoEmergencia = 911;
        }
    }
}
