﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Claytondus.ShippyPro.Models;

namespace Claytondus.ShippyPro
{

	public class ShippyProClient : RestClient
	{

		public ShippyProClient(string authToken) : base(authToken)
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
