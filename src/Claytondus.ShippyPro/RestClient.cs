using System.Threading.Tasks;
using Claytondus.ShippyPro.Models;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Logging;

namespace Claytondus.ShippyPro
{
	public class RestClient
	{
		protected readonly Url ShippyProUrl = "https://www.shippypro.com/api";
		private readonly string _authToken;
		private readonly ILogger? _logger;


		public RestClient(string authToken, ILogger? logger = null)
		{
			_authToken = authToken;
			_logger = logger;
		}

		protected async Task<T> PostAsync<T>(object body)
		{
			try
			{
				var request = ShippyProUrl
					.WithDefaults()
					.WithBasicAuth(_authToken, "");
				var response = await request.PostJsonAsync(body);
				_logger?.LogTrace(response.ResponseMessage.RequestMessage.ToString());
				return await response.GetJsonAsync<T>();
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
					Method = "POST",
					HttpStatus = ex.Call.HttpResponseMessage.StatusCode,
					HttpMessage = ex.Message,
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
