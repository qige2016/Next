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



namespace Next.Core.Bean
{

public sealed partial class ItemBean : BeanBase
{
    public ItemBean(JSONNode _json) 
    {
        { if(!_json["Key"].IsString) { throw new SerializationException(); }  Key = _json["Key"]; }
        { if(!_json["Name"].IsString) { throw new SerializationException(); }  Name = _json["Name"]; }
        { if(!_json["Desc"].IsString) { throw new SerializationException(); }  Desc = _json["Desc"]; }
        PostInit();
    }

    public ItemBean(string Key, string Name, string Desc ) 
    {
        this.Key = Key;
        this.Name = Name;
        this.Desc = Desc;
        PostInit();
    }

    public static ItemBean DeserializeItemBean(JSONNode _json)
    {
        return new ItemBean(_json);
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

    public const int __ID__ = 1241621891;
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
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}