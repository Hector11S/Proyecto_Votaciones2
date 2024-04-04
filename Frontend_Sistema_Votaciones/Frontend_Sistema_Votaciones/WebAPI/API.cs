﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using Frontend_Sistema_Votaciones.Configuration;
using Frontend_Sistema_Votaciones.Models;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
//using Frontend_Sistema_Votaciones.Services;

namespace Frontend_Sistema_Votaciones.WebAPI
{
    public class API
    {
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContext;
        private readonly AppSettings _appSettings; 
        public API(IHttpContextAccessor httpContext, IOptions<AppSettings> appSettings)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
            _client = new HttpClient(httpClientHandler);
            _httpContext = httpContext;
            _appSettings = appSettings.Value;
            _client.BaseAddress = new Uri(_appSettings.BaseAddress);
            _client.Timeout = TimeSpan.FromSeconds(10);
        }

        public async Task<ApiResult<B>> Get<A, B>(Action<ApiCallConfiguration<A>> action, string token = null)
        {
            var config = new ApiCallConfiguration<A>();
            var result = new ApiResult<B>();
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                action(config);
                var requestUrl = new Uri(_client.BaseAddress, config.PathWithQueryStrings);
                var response = await _client.GetAsync(requestUrl);
                var content = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult<B>>(content);
                if (result.Data != null)
                {
                    result.Path = config.Path;
                    result.StatusCode = response.StatusCode;
                    result.Type = ApiResultType.Success;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = Helpers.GetMessage(ex);
            }
            return result;
        }

        public async Task<ApiResult<B>> Post<A, B>(Action<ApiCallConfiguration<A>> action, string token = null)
        {
            var config = new ApiCallConfiguration<A>();
            var result = new ApiResult<B>();
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                action(config);
                var requestUrl = new Uri(_client.BaseAddress, config.PathWithQueryStrings);
                var responseData = await _client.PostAsync(requestUrl, config.ContentJson);
                var content = await responseData.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult<B>>(content);
                result.Path = config.Path;
                if ((int)result.StatusCode == 1)
                {
                    result.StatusCode = HttpStatusCode.OK;
                    result.Success = true;
                }
                else
                {
                    result.Success = false;
                    result.StatusCode = HttpStatusCode.Forbidden;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = Helpers.GetMessage(ex);
            }
            return result;
        }

        public async Task<ApiResult<B>> Put<A, B>(Action<ApiCallConfiguration<A>> action, string token = null)
        {
            var config = new ApiCallConfiguration<A>();
            var result = new ApiResult<B>();
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                action(config);
                var requestUrl = new Uri(_client.BaseAddress, config.PathWithQueryStrings);
                var response = await _client.PutAsync(requestUrl, config.ContentJson);
                var content = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult<B>>(content);
                result.Path = config.Path;
                result.StatusCode = response.StatusCode;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = Helpers.GetMessage(ex);
            }

            return result;
        }

        public async Task<ApiResult<B>> Delete<A, B>(Action<ApiCallConfiguration<A>> action, string token = null)
        {
            var config = new ApiCallConfiguration<A>();
            var result = new ApiResult<B>();
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                action(config);
                var requestUrl = new Uri(_client.BaseAddress, config.PathWithQueryStrings);

                var response = await _client.DeleteAsync(requestUrl);
                var content = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult<B>>(content);
                result.Path = config.Path;
                result.StatusCode = response.StatusCode;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = Helpers.GetMessage(ex);
            }

            return result;
        }

    }
}
