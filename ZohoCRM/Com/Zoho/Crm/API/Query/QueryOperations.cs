using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.Query
{

	public class QueryOperations
	{
		/// <summary>The method to get records</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRecords(BodyWrapper request)
		{
			var handlerInstance=new CommonAPIHandler();

			var apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v2.1/coql");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


	}
}