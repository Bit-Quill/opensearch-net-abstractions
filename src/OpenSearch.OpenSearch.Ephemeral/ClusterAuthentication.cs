/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

namespace OpenSearch.OpenSearch.Ephemeral
{
	/// <summary>
	///     Authentication credentials for the cluster
	/// </summary>
	public class ClusterAuthentication
	{
		/// <summary>
		///     Administrator credentials
		/// </summary>
		public static Credentials Admin => new Credentials {Username = "opensearch_admin", Role = "admin"};

		/// <summary>
		///     User credentials
		/// </summary>
		public static Credentials User => new Credentials {Username = "opensearch_user", Role = "user"};

		/// <summary>
		///     Credentials for all users
		/// </summary>
		public static Credentials[] AllUsers { get; } = {Admin, User};

		/// <summary>
		///     Authentication credentials
		/// </summary>
		public class Credentials
		{
			public string Username { get; set; }
			public string Role { get; set; }
			public string Password => Username;
		}
	}
}