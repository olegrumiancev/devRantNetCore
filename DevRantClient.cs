//     File:  ddevRantNetCoreddevRantNetCoreDevRantClient.cs
//     Copyright (C) 2017 Rethought
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//     Created: 03.09.2017 1:09 PM
//     Last Edited: 04.09.2017 11:39 AM

#region Using Directives

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

#endregion

namespace devRantNetCore
{
    public class DevRantClient
    {
        private readonly HttpClient _httpClient;

        private readonly IBuildRequestUrl builder;

        private DevRantClient(HttpClient httpClient, IBuildRequestUrl builder)
        {
            this._httpClient = httpClient;
            this.builder = builder;
        }

        public static DevRantClient Create(HttpClient httpClient)
        {
            var client = new DevRantClient(
                httpClient,
                new BuildRequestUrl(
                    ApiEndpoints.BASE_URL,
                    new List<IParameter>
                    {
                        new Parameter("app", "3"),
                    }));

            httpClient.BaseAddress = new Uri(ApiEndpoints.BASE_URL);

            return client;
        }

        public async Task<RantResponse> GetCollaboration(int id)
        {
            return await this.Request<RantResponse>(
                this.builder.Build(
                    ApiEndpoints.API_RANTS + "/" + id));
        }

        public async Task<CollaborationsResponse> GetCollaborations(
            int limit = 0,
            int skip = 0,
            bool hideReposts = true)
        {
            return await this.Request<CollaborationsResponse>(
                this.builder.Build(
                    ApiEndpoints.API_COLLABS,
                    new List<IParameter>
                    {
                        new Parameter("limit", limit.ToString()),
                        new Parameter("skip", skip.ToString())
                    }));
        }

        public async Task<RantResponse> GetRant(int id)
        {
            return await this.Request<RantResponse>(
                this.builder.Build(ApiEndpoints.API_RANTS + "/" + id));
        }

        public async Task<RantsResponse> GetRants(
            Sort sort = Sort.Algo,
            int limit = 0,
            int skip = 0,
            bool hideReposts = true)
        {
            return await this.Request<RantsResponse>(
                this.builder.Build(
                    ApiEndpoints.API_RANTS,
                    new List<IParameter>
                    {
                        new Parameter("sort", sort.ToString().ToLower()),
                        new Parameter("limit", limit.ToString()),
                        new Parameter("skip", skip.ToString())
                    }));
        }

        public async Task<RantResponse> GetStories(
            Sort sort = Sort.Algo,
            int limit = 0,
            int skip = 0,
            bool hideReposts = true)
        {
            return await this.Request<RantResponse>(
                this.builder.Build(
                    ApiEndpoints.API_STORIES,
                    new List<IParameter>
                    {
                        new Parameter("sort", sort.ToString().ToLower()),
                        new Parameter("limit", limit.ToString()),
                        new Parameter("skip", skip.ToString())
                    }));
        }

        public async Task<SurpriseResponse> GetSurprise()
        {
            return await this.Request<SurpriseResponse>(
                this.builder.Build(ApiEndpoints.API_SURPRISE));
        }

        public async Task<UserResponse> GetUser(int id)
        {
            return await this.Request<UserResponse>(
                this.builder.Build(
                    ApiEndpoints.API_USERS + "/" + id));
        }

        public async Task<UserIDResponse> GetUserID(string username)
        {
            return await this.Request<UserIDResponse>(
                this.builder.Build(
                    ApiEndpoints.API_USER_ID,
                    new List<IParameter>
                    {
                        new Parameter("username", username)
                    }));
        }

        public async Task<WeeklyRantsResponse> GetWeeklyRants(
            Sort sort = Sort.Algo,
            int limit = 0,
            int skip = 0,
            bool hideReposts = true)
        {
            return await this.Request<WeeklyRantsResponse>(
                this.builder.Build(
                    ApiEndpoints.API_WEEKLY,
                    new List<IParameter>
                    {
                        new Parameter("sort", sort.ToString().ToLower()),
                        new Parameter("limit", limit.ToString()),
                        new Parameter("skip", skip.ToString()),
                    }));
        }

        public async Task<SearchRespone> SearchRants(string term)
        {
            return await this.Request<SearchRespone>(
                this.builder.Build(
                    ApiEndpoints.API_SEARCH,
                    new List<IParameter>
                    {
                        new Parameter("term", term),
                    }));
        }


        private async Task<T> Request<T>(string request)
        {
            var respone = await this._httpClient.GetAsync(request);

            var responseText = await respone.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(responseText);
        }
    }
}