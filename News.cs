//     File:  devRantNetCore/devRantNetCore/News.cs
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

using Newtonsoft.Json;

#endregion

namespace devRantNetCore
{
    [JsonObject(MemberSerialization.OptIn)]
    public class News
    {
        [JsonProperty("action", Required = Required.Always)]
        public string Action { get; set; }

        [JsonProperty("body", Required = Required.Always)]
        public string Body { get; set; }

        [JsonProperty("footer", Required = Required.Always)]
        public string Footer { get; set; }

        [JsonProperty("headline", Required = Required.Always)]
        public string Headline { get; set; }

        [JsonProperty("height", Required = Required.Always)]
        public int Height { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public int ID { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }
    }
}