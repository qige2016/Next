using System.Collections.Generic;

namespace Next.Core.Entities
{
    public class Role : AggregateRoot<int>
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
        /// 背包
        /// </summary>
        [ES3Serializable]
        public List<Item> Items { get; set; }

        public Role()
        {
        }


        public Role(int id, string key, string name, string desc, List<Item> items) : base(id)
        {
            Key = key;
            Name = name;
            Desc = desc;
            Items = items;
        }
    }
}