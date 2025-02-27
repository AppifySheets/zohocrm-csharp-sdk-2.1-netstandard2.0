using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.RelatedLists
{

	public class RelatedListsOperations
	{
		string module;

		/// <summary>		/// Creates an instance of RelatedListsOperations with the given parameters
		/// <param name="module">string</param>
		
		public RelatedListsOperations(string module)
		{
			 this.module=module;


		}

		/// <summary>The method to get related lists</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRelatedLists()
		{
			var handlerInstance=new CommonAPIHandler();

			var apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v2.1/settings/related_lists");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.RelatedLists.GetRelatedListsParam"),  module);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get related list</summary>
		/// <param name="id">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRelatedList(long? id)
		{
			var handlerInstance=new CommonAPIHandler();

			var apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v2.1/settings/related_lists/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.RelatedLists.GetRelatedListParam"),  module);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetRelatedListsParam
		{
		}


		public static class GetRelatedListParam
		{
		}

	}
}