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

public sealed partial class TbRole :ITable<RoleBean, string>{
    private readonly Dictionary<string, RoleBean> _dataMap;
    private readonly List<RoleBean> _dataList;
    
    public TbRole(JSONNode _json)
    {
        _dataMap = new Dictionary<string, RoleBean>();
        _dataList = new List<RoleBean>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = RoleBean.DeserializeRoleBean(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Key, _v);
        }
        PostInit();
    }

    public Dictionary<string, RoleBean> DataMap => _dataMap;
    public List<RoleBean> DataList => _dataList;

    public RoleBean GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public RoleBean Get(string key) => _dataMap[key];
    public RoleBean this[string key] => _dataMap[key];

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