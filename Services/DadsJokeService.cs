﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class DadsJokeService : IDadsJokeInterface
    {
        public DadsJokeService()
        {

        }

        public async Task<string> GetDadsJoke()
        {
            string result = "";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://dad-jokes.p.rapidapi.com/random/joke"),
                Headers =
                {
                    { "X-RapidAPI-Key", "050010e3e5msha13df771d68d33dp16075ajsn666c38a9761a" },
                    { "X-RapidAPI-Host", "dad-jokes.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                result = body.ToString();
            }

            return result;
        }
    }
}
