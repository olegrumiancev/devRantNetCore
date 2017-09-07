//     File:  devRantNetCore/devRantNetCore/UserContent.cs
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
//     Created: 04.09.2017 11:39 AM
//     Last Edited: 04.09.2017 11:39 AM

#region Using Directives

using Newtonsoft.Json;

#endregion

namespace devRantNetCore
{
    [JsonObject(MemberSerialization.OptIn)]

    public abstract class UserContent : IHasContent
    {

        [JsonProperty("created_time")]
        public int CreatedTime { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("user_avatar")]
        public UserAvatar UserAvatar { get; set; }

        [JsonProperty("user_dpp")]
        public int UserDpp { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("user_username")]
        public string UserName { get; set; }

        [JsonProperty("user_score")]
        public int UserScore { get; set; }

        [JsonProperty("vote_state")]
        public int VoteState { get; set; }

        public abstract string Content { get; set; }
    }

    public interface IHasContent
    {
        string Content { get; set; }
    }
}