//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace Next.item
{

public sealed partial class ItemExchange :  Bright.Config.BeanBase 
{
    public ItemExchange(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["num"].IsNumber) { throw new SerializationException(); }  Num = _json["num"]; }
        PostInit();
    }

    public ItemExchange(int id, int num ) 
    {
        this.Id = id;
        this.Num = num;
        PostInit();
    }

    public static ItemExchange DeserializeItemExchange(JSONNode _json)
    {
        return new item.ItemExchange(_json);
    }

    public int Id { get; private set; }
    public int Num { get; private set; }

    public const int __ID__ = 1814660465;
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
        + "Id:" + Id + ","
        + "Num:" + Num + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
