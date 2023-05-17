using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

namespace Editor
{
    [ScriptedImporter( 1, "lua" )]
    public class LuaFileExtendImporter : ScriptedImporter {
        public override void OnImportAsset( AssetImportContext ctx ) {
            TextAsset subAsset = new TextAsset( File.ReadAllText( ctx.assetPath ) );
            ctx.AddObjectToAsset( "text", subAsset );
            ctx.SetMainObject( subAsset );
        }
    }
}