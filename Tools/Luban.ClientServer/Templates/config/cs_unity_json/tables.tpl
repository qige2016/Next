using System;
using System.Collections.Generic;
using Bright.Config;
using Bright.Serialization;
using SimpleJSON;
{{
    name = x.name
    namespace = x.namespace
    tables = x.tables
}}

{{cs_start_name_space_grace x.namespace}} 
   
public sealed partial class {{name}}
{
    private readonly Dictionary<string, object> _tables = new Dictionary<string, object>();

    public {{name}}()
    {
    }

    public ITable<TBean, TKey> GetTable<TBean, TKey>(Func<string, JSONNode> loader) where TBean : BeanBase
    {
        var _type = typeof(TBean);
        {{~for table in tables ~}}
        if(_type == typeof({{table.value_type}}))
        {
            var _table = new {{table.full_name}}(loader("{{table.output_data_file}}"));
            _tables.Add("{{table.value_type}}", _table);
            PostInit();
            _table.Resolve(_tables);
            PostResolve();
            return _table as ITable<TBean, TKey>;
        }
        {{~end~}}
        throw new Exception($"Table not found for {_type}");
    }
    
    partial void PostInit();
    partial void PostResolve();
}

{{cs_end_name_space_grace x.namespace}}