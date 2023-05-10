using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;
using Next.Backend.Repositories;
using NUnit.Framework;

namespace Next.Test.Domain.Tests
{
    public class RepositoryBaseTests
    {
        private readonly RepositoryBase<Item, ItemBean, string, int> repository;

        public RepositoryBaseTests()
        {
            var filePath = "save_repository_tests";
            var table = BeanHelper.GetTable<ItemBean, string>();
            var mapper = new ItemMapper();
            repository = new RepositoryBase<Item, ItemBean, string, int>(filePath, table, mapper);
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
    }
}