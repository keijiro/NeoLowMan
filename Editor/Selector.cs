using UnityEditor;

namespace JP.Keijiro.NeoLowMan
{
    static class Selector
    {
        [MenuItem("Packages/NeoLowMan")]
        static void OpenPackageDirectory()
        {
            var path = "Packages/jp.keijiro.neolowman/README.md";
            Selection.activeObject = AssetDatabase.LoadMainAssetAtPath(path);
            EditorGUIUtility.PingObject(Selection.activeObject);
        }
    }
}
