using DatabaseTest.DBConnection;
using DatabaseTest.Util;
using NUnit.Framework;

namespace DatabaseTest.Tests
{
    public class Tests
    {
        private readonly string minTimeOfWorkQuery = FileReader.GetMinTimeOfWorkQuery();
        private readonly string uniqueTestQuery = FileReader.GetUniqueTestsQuery();
        private readonly string particularTimeQuery = FileReader.GetParticularTimeQuery();
        private readonly string browserTypesQuery = FileReader.GetBrowserTypesQuery();

        [Test]
        public void DbTest()
        {
            Utils.ShowTable(DBWork.SendRequest(minTimeOfWorkQuery));
            Utils.ShowTable(DBWork.SendRequest(uniqueTestQuery));
            Utils.ShowTable(DBWork.SendRequest(particularTimeQuery));
            Utils.ShowTable(DBWork.SendRequest(browserTypesQuery));
        }
    }
}
