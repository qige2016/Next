using Next.Backend.Entities;
using Next.Backend.Repositories;
using NUnit.Framework;

namespace Next.Test.Domain.Tests
{
    public class SaveRepositoryTests
    {
        private readonly string filePath = "save_repository_tests";
        private SaveRepository<Item, int> repository;

        public SaveRepositoryTests()
        {
            repository = new SaveRepository<Item, int>(filePath);
        }

        [Test]
        public void Insert_Should_Return_Entity()
        {
            var item = new Item
            {
                Key = "10000",
                Name = "发型",
                Price = 100
            };
            var insertItem = repository.Insert(item);
            Assert.AreEqual(item, insertItem);
        }

        [Test]
        public void Get_Should_Return_Entity()
        {
            Insert_Should_Return_Entity();
            var entity = repository.Get(1);
            Assert.IsNotNull(entity);
            Assert.AreEqual("10000", entity.Key);
            Assert.AreEqual("发型", entity.Name);
            Assert.AreEqual(100, entity.Price);
        }

        [Test]
        public void Find_Should_Return_Entity()
        {
            Insert_Should_Return_Entity();
            var entity = repository.Find(1);
            Assert.IsNotNull(entity);
            Assert.AreEqual("10000", entity.Key);
            Assert.AreEqual("发型", entity.Name);
            Assert.AreEqual(100, entity.Price);
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
            Assert.AreEqual(100, entity.Price);
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
            Assert.AreEqual(100, entityList[0].Price);
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