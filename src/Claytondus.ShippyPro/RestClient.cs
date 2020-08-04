﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Claytondus.ShippyPro.Models;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;

namespace Claytondus.ShippyPro
{
	public class RestClient
	{
		protected readonly string ShippyProUrl = "https://www.shippypro.com/api";
		private readonly string _authToken;

		public RestClient()
		{
		}

		public RestClient(string authToken)
		{
			_authToken = authToken;
		}


		protected async Task<T> PostAsync<T>(object body)
		{
			try
			{
				var request = new Url(ShippyProUrl)
					.WithDefaults()
					.WithBasicAuth(_authToken, "");
				return await request.PostJsonAsync(body)
					.ReceiveJson<T>();
			}
			catch (FlurlHttpTimeoutException)
			{
				throw new ShippyProException("timeout", "Request timed out.");
			}
			catch (FlurlHttpException ex)
			{
				var response = await ex.GetResponseStringAsync();
				var ShippyProEx = new ShippyProException("error", response)
				{
					Method = "POST", HttpStatus = ex.Call.HttpStatus, HttpMessage = ex.Message,
					RequestBody = ex.Call.RequestBody
				};
				throw ShippyProEx;
			}
		}
	}

	public static class UrlExtension
	{
		public static IFlurlRequest WithDefaults(this Url url)
		{
			return url
				.WithTimeout(20)
				.WithHeader("Accept", "application/json");
		}
	}
}
