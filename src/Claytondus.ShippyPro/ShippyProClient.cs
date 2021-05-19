using System.Threading.Tasks;
using Claytondus.ShippyPro.Models;
using Microsoft.Extensions.Logging;

namespace Claytondus.ShippyPro
{
	public class ShippyProClient : RestClient
	{
		public ShippyProClient(string authToken, ILogger? logger = null) : base(authToken, logger)
		{
		}

	    public async Task<Response> PutOrder(PutOrder request)
	    {
	        return await PostAsync<Response>(request);
	    }

	    public async Task<GetRatesResponse> GetRates(GetRates request)
	    {
		    return await PostAsync<GetRatesResponse>(request);
	    }

	    public async Task<ShipResponse> Ship(Ship request)
	    {
		    return await PostAsync<ShipResponse>(request);
	    }
	}
}
