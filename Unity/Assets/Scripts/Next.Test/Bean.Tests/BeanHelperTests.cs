using Next.Backend.Bean;
using NUnit.Framework;

namespace Next.Test.Bean.Tests
{
    public class BeanHelperTests
    {
        [Test]
        public void GetTable_Should_Return_Table()
        {
            var table = BeanHelper.GetTable<ItemBean, string>();
            Assert.IsNotNull(table);
        }

        [Test]
        public void GetBean_Should_Return_Bean()
        {
            var bean = BeanHelper.GetBean<ItemBean, string>("道具甲");
            Assert.IsNotNull(bean);
        }
    }
}