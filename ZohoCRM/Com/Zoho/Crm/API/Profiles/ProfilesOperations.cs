using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;
using System;

namespace Com.Zoho.Crm.API.Profiles
{

	public class ProfilesOperations
	{
		DateTimeOffset? ifModifiedSince;

		/// <summary>		/// Creates an instance of ProfilesOperations with the given parameters
		/// <param name="ifModifiedSince">DateTimeOffset?</param>
		
		public ProfilesOperations(DateTimeOffset? ifModifiedSince)
		{
			 this.ifModifiedSince=ifModifiedSince;


		}

		/// <summary>The method to get profiles</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetProfiles()
		{
			var handlerInstance=new CommonAPIHandler();

			var apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v2.1/settings/profiles");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddHeader(new Header<DateTimeOffset?>("If-Modified-Since", "com.zoho.crm.api.Profiles.GetProfilesHeader"),  ifModifiedSince);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get profile</summary>
		/// <param name="id">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetProfile(long? id)
		{
			var handlerInstance=new CommonAPIHandler();

			var apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v2.1/settings/profiles/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddHeader(new Header<DateTimeOffset?>("If-Modified-Since", "com.zoho.crm.api.Profiles.GetProfileHeader"),  ifModifiedSince);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetProfilesHeader
		{
		}


		public static class GetProfileHeader
		{
		}

	}
}