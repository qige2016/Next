//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Config;
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace Next.Backend.Bean
{

public sealed partial class RoleBean : BeanBase
{
    public RoleBean(JSONNode _json) 
    {
        { if(!_json["Key"].IsString) { throw new SerializationException(); }  Key = _json["Key"]; }
        { if(!_json["Name"].IsString) { throw new SerializationException(); }  Name = _json["Name"]; }
        { if(!_json["Desc"].IsString) { throw new SerializationException(); }  Desc = _json["Desc"]; }
        { var __json0 = _json["ItemList"]; if(!__json0.IsArray) { throw new SerializationException(); } ItemList = new System.Collections.Generic.List<string>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { string __v0;  { if(!__e0.IsString) { throw new SerializationException(); }  __v0 = __e0; }  ItemList.Add(__v0); }   }
        PostInit();
    }

    public RoleBean(string Key, string Name, string Desc, System.Collections.Generic.List<string> ItemList ) 
    {
        this.Key = Key;
        this.Name = Name;
        this.Desc = Desc;
        this.ItemList = ItemList;
        PostInit();
    }

    public static RoleBean DeserializeRoleBean(JSONNode _json)
    {
        return new RoleBean(_json);
    }

    /// <summary>
    /// key
    /// </summary>
    public string Key { get; private set; }
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 描述
    /// </summary>
    public string Desc { get; private set; }
    /// <summary>
    /// 背包
    /// </summary>
    public System.Collections.Generic.List<string> ItemList { get; private set; }

    public const int __ID__ = -202489498;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Key:" + Key + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "ItemList:" + Bright.Common.StringUtil.CollectionToString(ItemList) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
