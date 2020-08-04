﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Claytondus.ShippyPro.Models;
using Xunit;
using Xunit.Abstractions;

namespace Claytondus.ShippyPro.Test
{
    public class ClientTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ClientTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        const string token = "d6ee8eb03a489b9baa63a3d7695bd08a";

        [Fact]
        public async Task PutOrderTest()
        {
            var client = new ShippyProClient(token);

            var parms = new PutOrderParams
            {
                to_address = new Address
                {
                    name = "Clayton Davis",
                    company = "Clayton Davis Ventures",
                    street1 = "C/ L'Aljub, 7",
                    city = "Marratxi",
                    state = "Baleares",
                    country = "ES",
                    phone = "+34555444333",
                    email = "clayton@agonswim.com"
                },
                parcels = new []
                {
                    new Parcel
                    {
                        length = 10,
                        height = 10,
                        width = 10,
                        weight = 1
                    }
                },
                TransactionID = "20731AB3D5F7",
                Date = ((DateTimeOffset)new DateTime(2020,7,31,4,56,34)).ToUnixTimeSeconds(),
                Currency = "EUR",
                ItemsCount = 1,
                ContentDescription = "Swimwear",
                Total = 23.5m,
                Status = "Paid",
                ShipmentAmountPaid = 23.5m,
                Incoterm = "DDP",
                ShippingService = "Economy",
                Note = "Test"
            };
            var request = new PutOrder
            {
                Params = parms
            };
            var response = await client.PutOrder(request);

            Assert.NotNull(response);
        }

        [Fact]
        public async Task GetRatesTest()
        {
            var client = new ShippyProClient(token);

            var parms = new GetRatesParams()
            {
                to_address = new Address
                {
                    name = "Clayton Davis",
                    company = "Clayton Davis Ventures",
                    street1 = "C/ L'Aljub, 7",
                    city = "Marratxi",
                    state = "Baleares",
                    country = "ES",
                    phone = "+34555444333",
                    email = "clayton@agonswim.com"
                },
                from_address = new Address
                {
                    name = "Henar Alonso-Pimentel",
                    company = "Rainbowwear SL",
                    street1 = "C/ Miguel Angel Abia B12",
                    city = "La Cisterniga",
                    state = "Valladolid",
                    country = "ES",
                    phone = "+34555666777",
                    email = "info@agonswim.com"
                },
                parcels = new []
                {
                    new Parcel
                    {
                        length = 10,
                        height = 10,
                        width = 10,
                        weight = 1
                    }
                },
                ContentDescription = "Swimwear",
                ShippingService = "Economy",
            };
            var request = new GetRates()
            {
                Params = parms
            };
            var response = await client.GetRates(request);

            Assert.NotNull(response);
        }

        [Fact]
        public async Task ShipTest()
        {
            var client = new ShippyProClient(token);

            var parms = new ShipParams()
            {
                to_address = new Address
                {
                    name = "Clayton Davis",
                    company = "Clayton Davis Ventures",
                    street1 = "C/ L'Aljub, 7",
                    city = "Marratxi",
                    state = "Baleares",
                    country = "ES",
                    zip = "07141",
                    phone = "+34555444333",
                    email = "clayton@agonswim.com"
                },
                from_address = new Address
                {
                    name = "Henar Alonso-Pimentel",
                    company = "Rainbowwear SL",
                    street1 = "C/ Miguel Angel Abia B12",
                    city = "La Cisterniga",
                    state = "Valladolid",
                    zip = "47193",
                    country = "ES",
                    phone = "+34555666777",
                    email = "info@agonswim.com"
                },
                parcels = new []
                {
                    new Parcel
                    {
                        length = 10,
                        height = 10,
                        width = 10,
                        weight = 1
                    }
                },
                ContentDescription = "Swimwear",
                Incoterm = "DDP",
                Async = false,
                CarrierName = "Generic",
                CarrierService = "Standard",
                CarrierID = 1740,
                TransactionID = "123-2020",
                Note = "123-2020"
            };
            var request = new Ship()
            {
                Params = parms
            };
            var response = await client.Ship(request);

            Assert.NotNull(response);
        }
    }
}
