//     File:  devRantNetCore/devRantNetCore/Profile.cs
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

using Newtonsoft.Json;

#endregion

namespace devRantNetCore
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Profile
    {
        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("avatar")]
        public UserAvatar Avatar { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("created_time")]
        public int CreatedTime { get; set; }

        [JsonProperty("dpp")]
        public int Dpp { get; set; }

        [JsonProperty("github")]
        public string Github { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("skills")]
        public string Skills { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }
}