using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.Layouts
{

	public class LayoutsOperations
	{
		string module;

		/// <summary>		/// Creates an instance of LayoutsOperations with the given parameters
		/// <param name="module">string</param>
		
		public LayoutsOperations(string module)
		{
			 this.module=module;


		}

		/// <summary>The method to get layouts</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetLayouts()
		{
			var handlerInstance=new CommonAPIHandler();

			var apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v2.1/settings/layouts");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.Layouts.GetLayoutsParam"),  module);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get layout</summary>
		/// <param name="id">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetLayout(long? id)
		{
			var handlerInstance=new CommonAPIHandler();

			var apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v2.1/settings/layouts/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.Layouts.GetLayoutParam"),  module);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetLayoutsParam
		{
		}


		public static class GetLayoutParam
		{
		}

	}
}