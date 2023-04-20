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

        [Test]
        public void GetTable_Should_Return_Table()
        {
            var table = BeanHelper.GetTable<ItemBean, string>();
            Assert.IsNotNull(table);
        }

        [Test]
        public void GetBean_Should_Return_Bean()
        {
            var bean = BeanHelper.GetBean<ItemBean, string>("10000");
            Assert.IsNotNull(bean);
        }
    }
}