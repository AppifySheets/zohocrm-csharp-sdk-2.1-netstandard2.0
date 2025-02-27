using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ContactRoles
{

	public class ContactRoleWrapper : Model
	{
		string contactRole;
		Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string ContactRole
		{
			/// <summary>The method to get the contactRole</summary>
			/// <returns>string representing the contactRole</returns>
			get
			{
				return  contactRole;

			}
			/// <summary>The method to set the value to contactRole</summary>
			/// <param name="contactRole">string</param>
			set
			{
				 contactRole=value;

				 keyModified["Contact_Role"] = 1;

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