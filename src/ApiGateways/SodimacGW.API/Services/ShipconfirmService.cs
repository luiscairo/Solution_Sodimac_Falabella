﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SodimacGW.API.Config;
using System.Net.Http;

namespace SodimacGW.API.Services
{
    public class ShipconfirmService : IShipconfirmService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ShipconfirmService> _logger;
        private readonly UrlsConfig _urls;

        public ShipconfirmService(HttpClient httpClient, ILogger<ShipconfirmService> logger, IOptions<UrlsConfig> config)
        {
            _httpClient = httpClient;
            _logger = logger;
            _urls = config.Value;
        }
    }
}
