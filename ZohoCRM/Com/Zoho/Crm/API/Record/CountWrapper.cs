using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class CountWrapper : Model, CountHandler
	{
		long? count;
		Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? Count
		{
			/// <summary>The method to get the count</summary>
			/// <returns>long? representing the count</returns>
			get
			{
				return  count;

			}
			/// <summary>The method to set the value to count</summary>
			/// <param name="count">long?</param>
			set
			{
				 count=value;

				 keyModified["count"] = 1;

			}
		}

		/// <summary>The method to check if the user has modified the given key</summary>
		/// <param name="key">string</param>
		/// <returns>int? representing the modification</returns>
		public int? IsKeyModified(string key)
		{
			if((( keyModified.ContainsKey(key))))
			{
				return  keyModified[key];

			}
			return null;


		}

		/// <summary>The method to mark the given key as modified</summary>
		/// <param name="key">string</param>
		/// <param name="modification">int?</param>
		public void SetKeyModified(string key, int? modification)
		{
			 keyModified[key] = modification;


		}


	}
}