#if UNITY_EDITOR
using UnityEditor;

namespace CreateClasses
{
    public class CreateUnityScripts
    {
        private const string path = "Assets/CreateClasses/ClassTemplates/UnityScripts/";

        #region EMPTY SCRIPT
        private const string emptyScriptTemplate = "EmptyScript.cs.txt";

        [MenuItem(itemName: "Assets/Create/C# Unity Script", isValidateFunction: false, priority: 50)]
        public static void CreateScriptFromTemplate()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(path + emptyScriptTemplate, "EmptyScript.cs");
        }
        #endregion

        #region SINGLETON SCRIPT
        private const string emptySingletonScriptTemplate = "EmptySingletonScript.cs.txt";

        [MenuItem(itemName: "Assets/Create/C# Unity Singleton Script", isValidateFunction: false, priority: 50)]
        public static void CreateSingletonScriptFromTemplate()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(path + emptySingletonScriptTemplate, "EmptySingletonScript.cs");
        }
        #endregion
    }
}
#endif