using StardewModdingAPI;

namespace AbigailPortrait
{
    internal class EdnaldoPereira : IAssetEditor
    {

        public bool CanEdit<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals("Strings/StringsFromCSFiles");
        }

        public void Edit<T>(IAssetData asset)
        {
            var editor = asset.AsDictionary<string, string>();
            editor.Data["TV.cs.13105"] = Translate.EdnaldoPereira();
            
        }
    }
}
