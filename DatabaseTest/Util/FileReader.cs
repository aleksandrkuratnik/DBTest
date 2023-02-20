using System;
using Newtonsoft.Json;

namespace DatabaseTest.Util
{
    internal static class FileReader
    {
        private const string PathToBrowserTypesQuery = @"Resources\browserTypesQuery.sql";
        private const string PathToFromParticularTimeQuery = @"Resources\fromParticularTimeQuery.sql";
        private const string PathToMinTimeOfWorkQuery = @"Resources\minTimeOfWorkQuery.sql";
        private const string PathToUniqueTestsQuery = @"Resources\uniqueTestsQuery.sql";
        private const string PathToPassword = @"Resources\password.txt";

        private static string ReadFile(string path)
        {
            using StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }

        public static T? ReadJsonData<T>(string path)
        {
            return JsonConvert.DeserializeObject<T>(ReadFile(path));
        }

        public static string GetBrowserTypesQuery()
        {
            return ReadFile(PathToBrowserTypesQuery);
        }

        public static string GetParticularTimeQuery()
        {
            return ReadFile(PathToFromParticularTimeQuery);
        }

        public static string GetMinTimeOfWorkQuery()
        {
            return ReadFile(PathToMinTimeOfWorkQuery);
        }

        public static string GetUniqueTestsQuery()
        {
            return ReadFile(PathToUniqueTestsQuery);
        }

        public static string GetPassword()
        {
            return ReadFile(PathToPassword);
        }
    }
}
