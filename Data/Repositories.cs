using Microsoft.Extensions.Options;

namespace TestWebApplication1.Data
{
    public class Repositories : IRepositories
    {
        private readonly GlobalSettings globalSettings;

        public Repositories(IOptions<GlobalSettings> globalSettings)
        {
            this.globalSettings = globalSettings.Value;
        }

        public string GetConnectionString()
        {
            return this.globalSettings.ConnectionString;
        }
    }
}
