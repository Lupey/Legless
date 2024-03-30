using ModelReplacement;
using UnityEngine;

namespace ModelReplacement
{
    public class ModelReplacementPlaceholder : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "legless";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}