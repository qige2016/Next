using System.Collections.Generic;
using Mapster;

namespace Next.Backend.Entities
{
    public class Menpai : AggregateRoot<int>
    {
        /// <summary>
        /// key
        /// </summary>
        [ES3Serializable]
        public string Key { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [ES3Serializable]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [ES3Serializable]
        public string Desc { get; set; }

        /// <summary>
        /// 门人
        /// </summary>
        [AdaptIgnore]
        [ES3Serializable]
        public ICollection<Role> Roles { get; set; }

        public Menpai()
        {
        }

        public Menpai(int id, string key, string name, string desc) : base(id)
        {
            Key = key;
            Name = name;
            Desc = desc;
            Roles = new List<Role>();
        }
    }
}