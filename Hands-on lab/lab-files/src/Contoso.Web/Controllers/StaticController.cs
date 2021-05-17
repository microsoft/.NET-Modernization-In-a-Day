﻿using Contoso.Web.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Contoso.Web.Controllers
{
    [Authorize]
    public class StaticController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly IHttpClientFactory _httpClientfactory;

        public StaticController(IConfiguration configuration, IHttpClientFactory client , ILogger<StaticController> logger)
        {
            _logger = logger;
            _configuration = configuration;
            _httpClientfactory = client;
        }
        public IActionResult Index()
        {
            var config = new WebAppConfiguration
            {
                ApiUrl = _configuration["ApiUrl"],
                PolicyDocumentsPath = _configuration["PolicyDocumentsPath"],
                ApimSubscriptionKey = _configuration["ApimSubscriptionKey"]
            };
            return View(config);
        }

        public IActionResult Dependents()
        {
            return View();
        }

        public IActionResult Dependent()
        {
            return View();
        }

        public IActionResult People()
        {
            return View();
        }

        public IActionResult Person()
        {
            return View();
        }

        public IActionResult Policies()
        {
            return View();
        }

        public IActionResult Policy()
        {
            return View();
        }

        public IActionResult PolicyHolders()
        {
            return View();
        }

        public IActionResult PolicyHolder()
        {
            return View();
        }

        [HttpGet("download/{policyHolder}/{policyNumber}")]
        public async Task<IActionResult> DownloadPolicyDocument(string policyHolder, string policyNumber)
        {
            try
            {
                var client = _httpClientfactory.CreateClient();
                
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _configuration["ApimSubscriptionKey"]);                                
                var policyDocumentsPath = _configuration["PolicyDocumentsPath"];
                var url = policyDocumentsPath.Replace("{policyHolder}", policyHolder).Replace("{policyNumber}", policyNumber);                
                var bytes = await client.GetByteArrayAsync(url);             
                return File(bytes, "application/pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception while downloading the policy Document. Holder: {policyHolder} , Number: {policyNumber} , Message : {message}", policyHolder, policyNumber, ex.Message);
                return NotFound();
            }

        }
    }
}