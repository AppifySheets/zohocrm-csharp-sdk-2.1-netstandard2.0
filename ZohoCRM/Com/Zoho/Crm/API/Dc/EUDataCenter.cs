﻿using System;

namespace Com.Zoho.Crm.API.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho CRM in EU Domain.
    /// </summary>
    public class EUDataCenter : DataCenter
    {
        static readonly EUDataCenter EU = new EUDataCenter();

        EUDataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Production Environment in EU Domain.
        /// </summary>
        public static readonly  Environment PRODUCTION = new Environment("eu_prd", "https://www.zohoapis.eu", EU.GetIAMUrl(), EU.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Sandbox Environment in EU Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("eu_sdb", "https://sandbox.zohoapis.eu", EU.GetIAMUrl(), EU.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Developer Environment in EU Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("eu_dev", "https://developer.zohoapis.eu", EU.GetIAMUrl(), EU.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.eu/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://content.zohoapis.eu";
        }
    }
}
