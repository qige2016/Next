//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace Next.Backend.Bean
{ 

public sealed partial class TbMenpai :ITable<MenpaiBean, string>{
    private readonly Dictionary<string, MenpaiBean> _dataMap;
    private readonly List<MenpaiBean> _dataList;
    
    public TbMenpai(JSONNode _json)
    {
        _dataMap = new Dictionary<string, MenpaiBean>();
        _dataList = new List<MenpaiBean>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = MenpaiBean.DeserializeMenpaiBean(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Key, _v);
        }
        PostInit();
    }

    public Dictionary<string, MenpaiBean> DataMap => _dataMap;
    public List<MenpaiBean> DataList => _dataList;

    public MenpaiBean GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public MenpaiBean Get(string key) => _dataMap[key];
    public MenpaiBean this[string key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    
    partial void PostInit();
    partial void PostResolve();
}

}