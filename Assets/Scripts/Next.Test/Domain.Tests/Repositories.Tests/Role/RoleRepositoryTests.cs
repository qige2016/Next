using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;
using Next.Backend.Repositories;
using NUnit.Framework;

namespace Next.Test.Domain.Tests
{
    public class RoleRepositoryTests
    {
        private readonly RoleRepository repository;

        public RoleRepositoryTests()
        {
            var filePath = "role_repository_tests";
            var table = BeanHelper.GetTable<RoleBean, string>();
            var mapper = new RoleMapper();
            repository = new RoleRepository(filePath, table, mapper);
        }

        [Test]
        public void Get_Should_Return_Entity_From_Bean()
        {
            var entity = repository.Get("路人甲");
            Assert.IsNotNull(entity);
            Assert.AreEqual("路人甲", entity.Key);
            Assert.AreEqual("路人甲", entity.Name);
        }

        [Test]
        public void GetOrDefault_Should_Return_EntityOrNull()
        {
            var entity = repository.GetOrDefault("路人甲");
            Assert.IsNotNull(entity);
            Assert.AreEqual("路人甲", entity.Key);
            Assert.AreEqual("路人甲", entity.Name);
            var nullEntity = repository.GetOrDefault("0");
            Assert.IsNull(nullEntity);
        }

        [Test]
        public void Insert_Should_Return_Entity()
        {
            var role = new Role
            {
                Key = "路人丙",
                Name = "路人丙"
            };
            var insertRole = repository.Insert(role);
            Assert.AreEqual(role, insertRole);
        }

        [Test]
        public void Get_Should_Return_Entity_From_Save()
        {
            Insert_Should_Return_Entity();
            var entity = repository.Get(1);
            Assert.IsNotNull(entity);
            Assert.AreEqual("路人丙", entity.Key);
            Assert.AreEqual("路人丙", entity.Name);
        }

        [Test]
        public void Find_Should_Return_Entity()
        {
            Insert_Should_Return_Entity();
            var entity = repository.Find(1);
            Assert.IsNotNull(entity);
            Assert.AreEqual("路人丙", entity.Key);
            Assert.AreEqual("路人丙", entity.Name);
            var nullEntity = repository.Find(0);
            Assert.IsNull(nullEntity);
        }

        [Test]
        public void Update_Should_Return_Entity()
        {
            Insert_Should_Return_Entity();
            var entity = repository.Get(1);
            entity.Name = "路人丙-改";
            var updateEntity = repository.Update(entity);
            Assert.IsNotNull(updateEntity);
            Assert.AreEqual(entity, updateEntity);
            Assert.AreEqual("路人丙", entity.Key);
            Assert.AreEqual("路人丙-改", entity.Name);
        }

        [Test]
        public void GetAll_Should_Return_Entity_List()
        {
            Insert_Should_Return_Entity();
            var entityList = repository.GetAll();
            Assert.IsNotNull(entityList);
            Assert.AreEqual(1, entityList.Count);
            Assert.AreEqual("路人丙", entityList[0].Key);
            Assert.AreEqual("路人丙", entityList[0].Name);
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