namespace Next.Backend.Entities
{
    public class Item : Entity<int>
    {
        /// <summary>
        /// 这是key
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
        /// 价格
        /// </summary>
        [ES3Serializable]
        public int Price { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [ES3Serializable]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 能否批量使用
        /// </summary>
        [ES3Serializable]
        public bool BatchUseable { get; set; }
    }
}