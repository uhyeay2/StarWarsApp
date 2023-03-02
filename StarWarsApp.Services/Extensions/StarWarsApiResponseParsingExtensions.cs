namespace StarWarsApp.Services.Extensions
{
    public static class StarWarsApiResponseParsingExtensions
    {
        /// <summary>
        /// Return -1 if url contains no '/'. 
        /// Return -2 if url is null/empty/whitespace. 
        /// Return -3 if unable to parse end of url as an int. 
        /// Return int if able to parse substring starting after last '/'.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static int ParseStarWarsApiId(this string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return -2;
            }

            if (url.EndsWith('/'))
            {
                url = url.TrimEnd('/');
            }

            var indexOfLastSlash = url.LastIndexOf('/');

            if (indexOfLastSlash == -1)
            {
                return indexOfLastSlash;
            }

            var id = url[++indexOfLastSlash..];

            return int.TryParse(id, out var i) ? i : -3;
        }

        public static string GetValueOrDefaultToUnknown(this string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "Unknown";
            }

            return value;
        }
    }
}
