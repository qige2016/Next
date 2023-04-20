namespace Next.Backend.Entities
{
    public class Item : Entity<int>
    {
        public int Id { get; set; }

        /// <summary>
        /// 这是key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 能否批量使用
        /// </summary>
        public bool BatchUseable { get; set; }
    }
}