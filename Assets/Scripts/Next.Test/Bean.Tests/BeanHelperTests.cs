using Next.Backend.Bean;
using NUnit.Framework;

namespace Next.Test.Bean.Tests
{
    public class BeanHelperTests
    {
        [Test]
        public void GetTables_Should_Return_Tables()
        {
            var tables = BeanHelper.GetTables();
            Assert.IsNotNull(tables);
            var tbItem = tables.TbItem;
            Assert.IsNotNull(tbItem);
        }
    }
}