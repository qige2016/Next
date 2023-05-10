using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;
using Next.Backend.Repositories;
using NUnit.Framework;

namespace Next.Test.Domain.Tests
{
    public class ItemRepositoryTests
    {
        private readonly ItemRepository repository;

        public ItemRepositoryTests()
        {
            var filePath = "save_repository_tests";
            var table = BeanHelper.GetTable<ItemBean, string>();
            var mapper = new ItemMapper();
            repository = new ItemRepository(filePath, table, mapper);
        }

        [Test]
        public void Get_Should_Return_Entity_From_Bean()
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
        public void Insert_Should_Return_Entity()
        {
            var item = new Item
            {
                Key = "10000",
                Name = "发型"
            };
            var insertItem = repository.Insert(item);
            Assert.AreEqual(item, insertItem);
        }

        [Test]
        public void Get_Should_Return_Entity_From_Save()
        {
            Insert_Should_Return_Entity();
            var entity = repository.Get(1);
            Assert.IsNotNull(entity);
            Assert.AreEqual("10000", entity.Key);
            Assert.AreEqual("发型", entity.Name);
        }

        [Test]
        public void Find_Should_Return_Entity()
        {
            Insert_Should_Return_Entity();
            var entity = repository.Find(1);
            Assert.IsNotNull(entity);
            Assert.AreEqual("10000", entity.Key);
            Assert.AreEqual("发型", entity.Name);
            var nullEntity = repository.Find(0);
            Assert.IsNull(nullEntity);
        }

        [Test]
        public void Update_Should_Return_Entity()
        {
            Insert_Should_Return_Entity();
            var entity = repository.Get(1);
            entity.Name = "发型2";
            var updateEntity = repository.Update(entity);
            Assert.IsNotNull(updateEntity);
            Assert.AreEqual(entity, updateEntity);
            Assert.AreEqual("10000", entity.Key);
            Assert.AreEqual("发型2", entity.Name);
        }

        [Test]
        public void GetAll_Should_Return_Entity_List()
        {
            Insert_Should_Return_Entity();
            var entityList = repository.GetAll();
            Assert.IsNotNull(entityList);
            Assert.AreEqual(1, entityList.Count);
            Assert.AreEqual("10000", entityList[0].Key);
            Assert.AreEqual("发型", entityList[0].Name);
        }

        [Test]
        public void GetCount_Should_Return_Number()
        {
            Insert_Should_Return_Entity();
            var count = repository.GetCount();
            Assert.AreEqual(1, count);
        }

        [Test]
        public void Delete_Should_Return_True()
        {
            Insert_Should_Return_Entity();
            repository.Delete(1);
            var entityList = repository.GetAll();
            Assert.AreEqual(0, entityList.Count);
        }
    }
}