using System;
using System.Collections.Generic;
using System.Linq;
using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public class SaveRepository<TEntity, TId> : ISaveRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
    {
        private readonly string filePath;

        public SaveRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public List<TEntity> GetAll() => ES3.GetKeys(filePath).Select(key => ES3.Load<TEntity>(key, filePath)).ToList();

        public int GetCount() => ES3.GetKeys(filePath).Length;

        public TEntity Insert(TEntity entity, bool autoSave = false)
        {
            SetIdIfNeeded(entity);
            ES3.Save(entity.Id.ToString(), entity, filePath);
            return entity;
        }

        private void SetIdIfNeeded(TEntity entity)
        {
            if (typeof(TId) == typeof(int) ||
                typeof(TId) == typeof(long) ||
                typeof(TId) == typeof(Guid))
            {
                if (entity.Id.Equals(default(TId)))
                {
                    var nextId = new InSaveIdGenerator().GenerateNext<TId>();
                    entity.GetType().GetProperty("Id")?.SetValue(entity, nextId);
                }
            }
        }

        public void InsertMany(IEnumerable<TEntity> entities, bool autoSave = false)
        {
            foreach (var entity in entities)
            {
                Insert(entity);
            }
        }

        public TEntity Update(TEntity entity, bool autoSave = false)
        {
            if (ES3.KeyExists(entity.Id.ToString(), filePath))
            {
                ES3.Save(entity.Id.ToString(), entity, filePath);
                return entity;
            }

            throw new KeyNotFoundException("Id \"" + entity.Id + "\" was not found in file \"" + filePath + "\"");
        }

        public void UpdateMany(IEnumerable<TEntity> entities, bool autoSave = false)
        {
            foreach (var entity in entities)
            {
                Update(entity);
            }
        }

        public void Delete(TEntity entity, bool autoSave = false)
        {
            Delete(entity.Id, autoSave);
        }

        public void DeleteMany(IEnumerable<TEntity> entities, bool autoSave = false)
        {
            foreach (var entity in entities)
            {
                Delete(entity);
            }
        }

        public TEntity Get(TId id)
        {
            return ES3.Load<TEntity>(id.ToString(), filePath);
        }

        public TEntity Find(TId id)
        {
            if (ES3.KeyExists(id.ToString(), filePath))
            {
                return ES3.Load<TEntity>(id.ToString(), filePath);
            }

            return null;
        }

        public void Delete(TId id, bool autoSave = false)
        {
            if (ES3.KeyExists(id.ToString(), filePath))
            {
                ES3.DeleteKey(id.ToString(), filePath);
            }
            else
            {
                throw new KeyNotFoundException("Id \"" + id + "\" was not found in file \"" + filePath + "\"");
            }
        }

        public void DeleteMany(IEnumerable<TId> ids, bool autoSave = false)
        {
            foreach (var id in ids)
            {
                Delete(id);
            }
        }
    }
}