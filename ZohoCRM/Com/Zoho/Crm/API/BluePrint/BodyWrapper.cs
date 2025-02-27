using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.BluePrint
{

	public class BodyWrapper : Model
	{
		List<BluePrint> blueprint;
		Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<BluePrint> Blueprint
		{
			/// <summary>The method to get the blueprint</summary>
			/// <returns>Instance of List<BluePrint></returns>
			get
			{
				return  blueprint;

			}
			/// <summary>The method to set the value to blueprint</summary>
			/// <param name="blueprint">Instance of List<BluePrint></param>
			set
			{
				 blueprint=value;

				 keyModified["blueprint"] = 1;

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