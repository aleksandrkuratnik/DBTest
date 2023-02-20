using DatabaseTest.TestConfig;

namespace DatabaseTest.Util
{
    internal static class TestConfigManager
    {
        private const string PathToTestConfig = @"Resources\testConfig.json";

        public static readonly TestConfiguration? testConfig = FileReader.ReadJsonData<TestConfiguration>(PathToTestConfig);
    }
}
