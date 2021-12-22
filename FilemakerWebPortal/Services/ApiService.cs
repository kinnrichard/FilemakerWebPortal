using System;

namespace FilemakerWebPortal.Services
{
    public class ApiService
    {
        public string URL_BASE_AUTH = "https://209.141.7.130/fmi/data/v1/";
        public string URL_POST = "https://209.141.7.130/fmi/data/v1/databases/Fabtech/layouts/FilemakerMobileAttendance/records";
        public string URL_GET = "https://209.141.7.130/fmi/data/v1/databases/Fabtech/layouts/FilemakerMobileAttendance/records/";
        public string URL_PATCH = "https://209.141.7.130/fmi/data/v1/databases/Fabtech/layouts/FilemakerMobileAttendance/records/";
        public string URL_DELETE = "https://209.141.7.130/fmi/data/v1/databases/Fabtech/layouts/FilemakerMobileAttendance/records/";

        public string? TOKEN;
        public Dictionary<string, string> fieldData;

        public string Database = "Fabtech";
        public string Username = "root";
        public string Password = "f@bt3ch";

    }
}
