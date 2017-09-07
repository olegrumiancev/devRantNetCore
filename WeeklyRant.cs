//     File:  devRantNetCore/devRantNetCore/WeeklyRant.cs
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
//     Created: 04.09.2017 10:45 AM
//     Last Edited: 04.09.2017 11:39 AM

#region Using Directives

using System.Collections.Generic;

using Newtonsoft.Json;

#endregion

namespace devRantNetCore
{
    [JsonObject(MemberSerialization.OptIn)]
    public class WeeklyRant
    {
        [JsonProperty("attached_image", Required = Required.AllowNull)]
        public AttachedImage AttachedImage { get; set; }


        [JsonProperty("num_comments", Required = Required.Always)]
        public int Comments { get; set; }


        [JsonProperty("created_time", Required = Required.Always)]
        public int CreatedTime { get; set; }


        [JsonProperty("edited", Required = Required.Always)]
        public bool Edited { get; set; }


        [JsonProperty("id", Required = Required.Always)]
        public int ID { get; set; }


        [JsonProperty("score", Required = Required.Always)]
        public int Score { get; set; }


        [JsonProperty("tags", Required = Required.Always)]
        public IEnumerable<string> Tags { get; set; }


        [JsonProperty("text", Required = Required.Always)]
        public string Text { get; set; }


        [JsonProperty("user_avatar", Required = Required.Always)]
        public UserAvatar UserAvatar { get; set; }


        [JsonProperty("user_dpp", Required = Required.Default)]
        public int UserDpp { get; set; }


        [JsonProperty("user_id", Required = Required.Always)]
        public int UserID { get; set; }


        [JsonProperty("user_username", Required = Required.Always)]
        public string Username { get; set; }


        [JsonProperty("user_score", Required = Required.Always)]
        public int UserScore { get; set; }


        [JsonProperty("vote_state", Required = Required.Always)]
        public int VoteState { get; set; }

        [JsonProperty("weekly")]
        public Weekly Weekly { get; set; }
    }
}