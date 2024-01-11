
#if UNITY_EDITOR
namespace GAS.Editor.AttributeSet
{
    using System.Collections.Generic;
    using GAS.Core;
    using GAS.Runtime.AttributeSet;
    using UnityEditor;
    using GAS.Editor.GameplayAbilitySystem;

    public static class AttributeSetEditorUtil
    {
        public static List<string> GetAttributeSetChoice()
        {
            var choices = new List<string>();
            var asset = AssetDatabase.LoadAssetAtPath<AttributeSetAsset>(GASSettingAsset.GAS_ATTRIBUTESET_ASSET_PATH);
            foreach (var attributeSetConfig in asset.AttributeSetConfigs)
            {
                var config = attributeSetConfig;
                choices.Add(config.Name);
            }

            return choices;
        }
    }
}
#endif