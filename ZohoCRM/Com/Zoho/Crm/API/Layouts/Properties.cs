using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Layouts
{

	public class Properties : Model
	{
		bool? reorderRows;
		ToolTip tooltip;
		int? maximumRows;
		Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? ReorderRows
		{
			/// <summary>The method to get the reorderRows</summary>
			/// <returns>bool? representing the reorderRows</returns>
			get
			{
				return  reorderRows;

			}
			/// <summary>The method to set the value to reorderRows</summary>
			/// <param name="reorderRows">bool?</param>
			set
			{
				 reorderRows=value;

				 keyModified["reorder_rows"] = 1;

			}
		}

		public ToolTip Tooltip
		{
			/// <summary>The method to get the tooltip</summary>
			/// <returns>Instance of ToolTip</returns>
			get
			{
				return  tooltip;

			}
			/// <summary>The method to set the value to tooltip</summary>
			/// <param name="tooltip">Instance of ToolTip</param>
			set
			{
				 tooltip=value;

				 keyModified["tooltip"] = 1;

			}
		}

		public int? MaximumRows
		{
			/// <summary>The method to get the maximumRows</summary>
			/// <returns>int? representing the maximumRows</returns>
			get
			{
				return  maximumRows;

			}
			/// <summary>The method to set the value to maximumRows</summary>
			/// <param name="maximumRows">int?</param>
			set
			{
				 maximumRows=value;

				 keyModified["maximum_rows"] = 1;

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