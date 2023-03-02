namespace StarWarsApp.Services.Interfaces
{
    public interface ISWApiService
    {
        public Task RefreshDataAsync();

        public long GetRefreshCount();

        public DateTime GetLastUpdateDateTimeUTC();
    }
}
