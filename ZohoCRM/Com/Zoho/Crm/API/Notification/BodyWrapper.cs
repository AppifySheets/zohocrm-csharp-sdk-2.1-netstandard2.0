using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Notification
{

	public class BodyWrapper : Model
	{
		List<Notification> watch;
		Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Notification> Watch
		{
			/// <summary>The method to get the watch</summary>
			/// <returns>Instance of List<Notification></returns>
			get
			{
				return  watch;

			}
			/// <summary>The method to set the value to watch</summary>
			/// <param name="watch">Instance of List<Notification></param>
			set
			{
				 watch=value;

				 keyModified["watch"] = 1;

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