﻿using System;

namespace Com.Zoho.Crm.API.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho CRM in CN Domain.
    /// </summary>
    public class CNDataCenter : DataCenter
    {
        static readonly CNDataCenter CN = new CNDataCenter();

        CNDataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Production Environment in CN Domain.
        /// </summary>
        public static readonly  Environment PRODUCTION = new Environment("cn_prd", "https://www.zohoapis.com.cn", CN.GetIAMUrl(), CN.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Sandbox Environment in CN Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("cn_sdb", "https://sandbox.zohoapis.com.cn", CN.GetIAMUrl(), CN.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Developer Environment in CN Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("cn_dev", "https://developer.zohoapis.com.cn", CN.GetIAMUrl(), CN.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.com.cn/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://content.zohoapis.com.cn";
        }
    }
}
