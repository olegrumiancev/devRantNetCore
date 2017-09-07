//     File:  devRantNetCore/devRantNetCore/Rant.cs
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

using System.Collections.Generic;

using Newtonsoft.Json;

#endregion

namespace devRantNetCore
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Rant : UserContent
    {
        [JsonProperty("attached_image")]
        public AttachedImage AttachedImage { get; set; }

        [JsonProperty("c_description")]
        public string CDescription { get; set; }

        [JsonProperty("c_team_size")]
        public string CTeamSize { get; set; }

        [JsonProperty("c_tech_stack")]
        public string CTechStack { get; set; }

        [JsonProperty("c_type")]
        public int CType { get; set; }

        [JsonProperty("c_type_long")]
        public string CTypeLong { get; set; }

        [JsonProperty("c_url")]
        public string CUrl { get; set; }

        [JsonProperty("edited")]
        public bool Edited { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("num_comments")]
        public int NumComments { get; set; }

        [JsonProperty("rt")]
        public int Rt { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }

        [JsonProperty("text")]
        public override string Content { get; set; }
    }
}