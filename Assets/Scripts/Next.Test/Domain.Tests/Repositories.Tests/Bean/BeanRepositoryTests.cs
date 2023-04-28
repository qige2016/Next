using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;
using Next.Backend.Repositories;
using NUnit.Framework;

namespace Next.Test.Domain.Tests
{
    public class BeanRepositoryTests
    {
        [Test]
        public void Get_Should_Return_Entity()
        {
            var table = BeanHelper.GetTable<ItemBean, string>();
            var mapper = new ItemMapper();
            var repository = new BeanRepository<Item, ItemBean, string>(table, mapper);
            var entity = repository.Get("10000");
            Assert.IsNotNull(entity);
            Assert.AreEqual("10000", entity.Key);
            Assert.AreEqual("发型", entity.Name);
            Assert.AreEqual(100, entity.Price);
        }

        [Test]
        public void GetOrDefault_Should_Return_EntityOrNull()
        {
            var table = BeanHelper.GetTable<ItemBean, string>();
            var mapper = new ItemMapper();
            var repository = new BeanRepository<Item, ItemBean, string>(table, mapper);
            var entity = repository.GetOrDefault("10000");
            Assert.IsNotNull(entity);
            Assert.AreEqual("10000", entity.Key);
            Assert.AreEqual("发型", entity.Name);
            Assert.AreEqual(100, entity.Price);
            var nullEntity = repository.GetOrDefault("0");
            Assert.IsNull(nullEntity);
        }

        [Test]
        public void GetAll_Should_Return_Entity_List()
        {
            var table = BeanHelper.GetTable<ItemBean, string>();
            var mapper = new ItemMapper();
            var repository = new BeanRepository<Item, ItemBean, string>(table, mapper);
            var entities = repository.GetAll();
            Assert.IsNotNull(entities);
        }

        [Test]
        public void GetCount_Should_Return_Number()
        {
            var table = BeanHelper.GetTable<ItemBean, string>();
            var mapper = new ItemMapper();
            var repository = new BeanRepository<Item, ItemBean, string>(table, mapper);
            var count = repository.GetCount();
            Assert.AreEqual(10, count);
        }
    }
}