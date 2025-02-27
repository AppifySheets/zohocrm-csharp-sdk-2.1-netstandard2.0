using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailTemplates
{

	public class Attachment : Model
	{
		long? size;
		string fileName;
		string fileId;
		long? id;
		Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? Size
		{
			/// <summary>The method to get the size</summary>
			/// <returns>long? representing the size</returns>
			get
			{
				return  size;

			}
			/// <summary>The method to set the value to size</summary>
			/// <param name="size">long?</param>
			set
			{
				 size=value;

				 keyModified["size"] = 1;

			}
		}

		public string FileName
		{
			/// <summary>The method to get the fileName</summary>
			/// <returns>string representing the fileName</returns>
			get
			{
				return  fileName;

			}
			/// <summary>The method to set the value to fileName</summary>
			/// <param name="fileName">string</param>
			set
			{
				 fileName=value;

				 keyModified["file_name"] = 1;

			}
		}

		public string FileId
		{
			/// <summary>The method to get the fileId</summary>
			/// <returns>string representing the fileId</returns>
			get
			{
				return  fileId;

			}
			/// <summary>The method to set the value to fileId</summary>
			/// <param name="fileId">string</param>
			set
			{
				 fileId=value;

				 keyModified["file_id"] = 1;

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 id=value;

				 keyModified["id"] = 1;

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