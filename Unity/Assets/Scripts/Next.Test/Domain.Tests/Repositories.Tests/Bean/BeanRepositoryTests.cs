using Next.Core.Bean;
using Next.Core.Entities;
using Next.Core.Mapper;
using Next.Core.Repositories;
using NUnit.Framework;

namespace Next.Test.Domain.Tests
{
    public class BeanRepositoryTests
    {
        private readonly BeanRepository<Item, ItemBean, string> repository;

        public BeanRepositoryTests()
        {
            var table = BeanHelper.GetTable<ItemBean, string>();
            var mapper = new ItemMapper();
            repository = new BeanRepository<Item, ItemBean, string>(table, mapper);
        }

        [Test]
        public void Get_Should_Return_Entity()
        {
            var entity = repository.Get("道具甲");
            Assert.IsNotNull(entity);
            Assert.AreEqual("道具甲", entity.Key);
            Assert.AreEqual("发型", entity.Name);
        }

        [Test]
        public void GetOrDefault_Should_Return_EntityOrNull()
        {
            var entity = repository.GetOrDefault("道具甲");
            Assert.IsNotNull(entity);
            Assert.AreEqual("道具甲", entity.Key);
            Assert.AreEqual("发型", entity.Name);
            var nullEntity = repository.GetOrDefault("0");
            Assert.IsNull(nullEntity);
        }

        [Test]
        public void GetAll_Should_Return_Entity_List()
        {
            var entities = repository.GetAll();
            Assert.IsNotNull(entities);
        }

        [Test]
        public void GetCount_Should_Return_Number()
        {
            var count = repository.GetCount();
            Assert.AreEqual(2, count);
        }
    }
}