namespace Domain.Models
{
    public static class Constants
    {
#if DEBUG
        public const string DefaultConnection = "Server=DESKTOP-7NM2Q2N;Database=UsaToBrazilBd;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True";
        //public const string DefaultConnection =
        //    "Server=12.10.25.222;Database=UsaToBrazilBd;Persist Security Info=True;User ID=eau199;Password=SafeBroker%100;TrustServerCertificate=True";

        //public const string TaskRouterEndPoint = "https://localhost:44368/TaskRouter/EndPoint";
        //public const string TaskRouterEndPoint = "https://localhost:44368/TaskRouter/EndPoint";
        //public const string TaskRouterEndPoint = "https://67641c7f.ngrok.io/TaskRouter/EndPoint";
        //public const string Domain = "https://c83c8e9b6afd.ngrok.io";
        public const string Domain = "https://localhost:44313";
#else
        //.184
        //public const string DefaultConnection = "Server=S50-62-56-184;Database=GlobalMessagingBd;Persist Security Info=True;User ID=eau199;Password=SafeBroker%100";
        public const string DefaultConnection =
 "Server=SP-DH;Database=UsaToBrazilBd;Persist Security Info=True;User ID=eau199;Password=SafeBroker%100;TrustServerCertificate=True";

        //public const string TaskRouterEndPoint = "https://sms.vegas/TaskRouter/EndPoint";
        public const string Domain = "https://sms.vegas";
#endif
        public const string NexmoNumber = "NexmoNumber";
        public const string NexmoKey = "NexmoKey";
        public const string NexmoKeyPassword = "NexmoKeyPassword";

        public const string TwilioAccountSid = "TwilioAccountSid";
        public const string TwilioAuthToken = "TwilioAuthToken";

        public const string TwilioNumberDeactivate = "TwilioNumberDeactivate";

        //TaskRouter
        public const string TwilioWorkspaceSid = "TwilioWorkspaceSid";
        public const string TwilioWorkflowSid = "TwilioWorkflowSid";

        public const int ImageSize = 200;
        public const int MmsImageSize = 800;

        public const string TwilioApiDomain = "https://api.twilio.com";
        public const string ContactPhoneStatus = "PhoneStatus";

        public const int CountChatItems = 3;
        public const string TwilioAccountDateParseModel = "TwilioAccountDateParseModel";
        public const string QrCode = "QRcode";
        public const string Voice = "Voice";
        public const string StaticPath = "static";
        public const string SiteName = "SMS.Vegas";

        public const string RoleAdmin = "admin";
        public const string RolePromoter = "promoter";
        public const string PingSite = "https://redlightgirlslv.com";
        public const int ServerTimeCorrect = 0;

        public const string ContactDocuments = "ContactDocuments";
        public const string Upload = "Upload";
    }
}
