using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ContactRoles
{

	public class RecordBodyWrapper : Model
	{
		List<ContactRoleWrapper> data;
		Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ContactRoleWrapper> Data
		{
			/// <summary>The method to get the data</summary>
			/// <returns>Instance of List<ContactRoleWrapper></returns>
			get
			{
				return  data;

			}
			/// <summary>The method to set the value to data</summary>
			/// <param name="data">Instance of List<ContactRoleWrapper></param>
			set
			{
				 data=value;

				 keyModified["data"] = 1;

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