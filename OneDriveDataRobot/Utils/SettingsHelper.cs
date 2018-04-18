/*
 * OneDrive Data Robot - Sample Code
 * Copyright (c) Microsoft Corporation
 * All rights reserved. 
 * 
 * MIT License
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the ""Software""), to deal in 
 * the Software without restriction, including without limitation the rights to use, 
 * copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the
 * Software, and to permit persons to whom the Software is furnished to do so, 
 * subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all 
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
 * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

namespace OneDriveDataRobot
{
    using System.Configuration;


    public class SettingsHelper
    {
        private static string _clientId = ConfigurationManager.AppSettings.Get("ida:ClientId");
        private static string _appKey = ConfigurationManager.AppSettings.Get("ida:ClientSecret") ?? ConfigurationManager.AppSettings.Get("ida:AppKey");

        private static string _graphResourceId = ConfigurationManager.AppSettings.Get("ida:GraphResourceId");
        private static string _authority = ConfigurationManager.AppSettings.Get("ida:AADInstance");

        private static string _consentUri = Authority1 + "oauth2/authorize?response_type=code&client_id={0}&resource={1}&redirect_uri={2}";
        private static string _adminConsentUri = Authority1 + "oauth2/authorize?response_type=code&client_id={0}&resource={1}&redirect_uri={2}&prompt={3}";

        private static string _notificationUrl = ConfigurationManager.AppSettings.Get("ida:NotificationUrl");

        public static string ClientId
        {
            get
            {
                return ClientId1;
            }
        }

        public static string AppKey
        {
            get
            {
                return AppKey1;
            }
        }

        public static string Authority
        {
            get
            {
                return Authority1;
            }
        }

        public static string MicrosoftGraphBaseUrl
        {
            get
            {
                return GraphResourceId;
            }
        }

        public static string NotificationUrl { get { return NotificationUrl1; } }

        public static string ClientId1 { get => _clientId; set => _clientId = value; }
        public static string AppKey1 { get => _appKey; set => _appKey = value; }
        public static string Authority1 { get => _authority; set => _authority = value; }
        public static string GraphResourceId { get => _graphResourceId; set => _graphResourceId = value; }
        public static string NotificationUrl1 { get => _notificationUrl; set => _notificationUrl = value; }
    }
}