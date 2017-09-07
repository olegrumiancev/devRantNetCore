//     File:  devRantNetCore/devRantNetCore/Content.cs
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
//     Created: 04.09.2017 10:49 AM
//     Last Edited: 04.09.2017 11:39 AM

#region Using Directives

using System.Collections.Generic;

using Newtonsoft.Json;

#endregion

namespace devRantNetCore
{
    [JsonObject(MemberSerialization.OptIn)]

    public class Content
    {
        [JsonProperty("comments")]
        public IEnumerable<Comment> Comments { get; set; }

        [JsonProperty("counts")]
        public Counts Counts { get; set; }

        [JsonProperty("favorites")]
        public IEnumerable<object> Favorites { get; set; }

        [JsonProperty("rants")]
        public IEnumerable<Rant> Rants { get; set; }

        [JsonProperty("upvoted")]
        public IEnumerable<Rant> Upvoted { get; set; }
    }
}