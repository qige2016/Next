using System.Collections.Generic;
using Next.Backend.Entities;
using Next.Backend.Mapper;

namespace Next.Backend.Repositories
{
    // public class SaveRepository<TEntity> : ISaveRepository<TEntity> where TEntity : class, IEntity
    // {
    //     protected readonly SaveDAO<TEntity> dao;
    //     protected readonly IMapper<TEntity> mapper;
    //
    //     public SaveRepository(SaveDAO<TEntity> dao, IMapper<TEntity> mapper)
    //     {
    //         this.dao = dao;
    //         this.mapper = mapper;
    //     }
    //
    //     public List<TEntity> GetAll() => mapper.Map(dao.GetAll());
    //
    //     public int GetCount() => dao.GetCount();
    // }
    //
    // public class SaveRepository<TEntity, TId> : SaveRepository<TEntity>, ISaveRepository<TEntity, TId>
    //     where TEntity : class, IEntity<TId>
    // {
    //     public SaveRepository(SaveDAO<TEntity> dao, IMapper<TEntity> mapper) : base(dao, mapper)
    //     {
    //     }
    //
    //     public TEntity Get(TId id) => mapper.Map(dao.Get(id));
    //
    //     public TEntity Find(TId id) => mapper.Map(dao.Find(id));
    // }
}