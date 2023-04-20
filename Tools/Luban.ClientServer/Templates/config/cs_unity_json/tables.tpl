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

    {{~for table in tables ~}}
{{~if table.comment != '' ~}}
    /// <summary>
    /// {{table.escape_comment}}
    /// </summary>
{{~end~}}
    public {{table.full_name}} {{table.name}} {get; }
    {{~end~}}

    public {{name}}(Func<string, JSONNode> loader)
    {
        {{~for table in tables ~}}
        {{table.name}} = new {{table.full_name}}(loader("{{table.output_data_file}}")); 
        _tables.Add("{{table.value_type}}", {{table.name}});
        {{~end~}}
        PostInit();

        {{~for table in tables ~}}
        {{table.name}}.Resolve(_tables); 
        {{~end~}}
        PostResolve();
    }

    public ITable<TBean, TKey> GetTable<TBean, TKey>() where TBean : BeanBase
    {
        return (ITable<TBean, TKey>) _tables[typeof(TBean).Name];
    }

    public void TranslateText(Func<string, string, string> translator)
    {
        {{~for table in tables ~}}
        {{table.name}}.TranslateText(translator); 
        {{~end~}}
    }
    
    partial void PostInit();
    partial void PostResolve();
}

{{cs_end_name_space_grace x.namespace}}