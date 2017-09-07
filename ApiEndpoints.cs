//     File:  devRantNetCore/devRantNetCore/ApiEndpoins.cs
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
//     Created: 04.09.2017 3:57 AM
//     Last Edited: 04.09.2017 11:39 AM

namespace devRantNetCore
{
    public static class ApiEndpoints    
    {
        public const string API = "/api";

        public const string API_AUTH_TOKEN = API_USERS + "/auth-token";

        public const string API_COLLABS = API_DEVRANT + "/collabs";

        public const string API_COMMENT = "/comments";

        public const string API_DEVRANT = API + "/devrant";

        public const string API_NOTIFS = API_USERS + "/me/notif-feed";

        public const string API_RANTS = API_DEVRANT + "/rants";

        public const string API_SEARCH = API_DEVRANT + "/search";

        public const string API_STORIES = API_DEVRANT + "/story-rants";

        public const string API_SURPRISE = API_RANTS + "/surprise";

        public const string API_USER_ID = API + "/get-user-id";

        public const string API_USERS = API + "/users";

        public const string API_VOTE = "/vote";

        public const string API_WEEKLY = API_DEVRANT + "/weekly-rants";

        public const string APP_ID = "3";

        public const string AVATARS_URL = "https://avatars.devrant.io";

        public const string BASE_URL = "https://www.devrant.io";

        public const string COLLAB_URL = "/collabs";

        public const string PLAT_ID = "3";

        public const string RANT_URL = "/rants";

        public const string USER_URL = "/users";
    }
}