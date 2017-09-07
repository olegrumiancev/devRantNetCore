//     File:  devRantNetCore/devRantNetCore/BuildRequestUrl.cs
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
//     Created: 04.09.2017 3:43 AM
//     Last Edited: 04.09.2017 11:39 AM

#region Using Directives

using System.Collections.Generic;
using System.Linq;

#endregion

namespace devRantNetCore
{
    public class BuildRequestUrl : IBuildRequestUrl
    {
        private readonly string _baseAdress;

        private readonly IEnumerable<IParameter> _reoccuringParameters;

        public BuildRequestUrl(
            string baseAdress,
            IEnumerable<IParameter> reoccuringParameters)
        {
            this._baseAdress = baseAdress;
            this._reoccuringParameters = reoccuringParameters;
        }

        public string Build(
            string apiEndPoint,
            IEnumerable<IParameter> parameters = null)
        {
            var value = this._baseAdress + apiEndPoint;

            var @params = new List<IParameter>();

            if (this._reoccuringParameters != null)
                @params.AddRange(this._reoccuringParameters);

            if (parameters != null)
                @params.AddRange(parameters);

            var first = @params.First();

            value += "?" + first.Get();

            @params.Remove(first);

            var aggregate = @params.Aggregate(
                value,
                (current, param) => current + "&" + param.Get());

            return aggregate;
        }
    }
}