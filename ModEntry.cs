using System;
using StardewModdingAPI;

namespace AbigailPortrait
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod, IAssetLoader
    {
        public override void Entry(IModHelper helper) {
            Translate.Init(helper.Translation);
            helper.Content.AssetEditors.Add(new EdnaldoPereira());
        }

        public bool CanLoad<T>(IAssetInfo asset)
        {
            return asset.AssetName.Equals("Portraits/Abigail");
        }

        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Portraits/Abigail"))
            {
                return this.Helper.Content.Load<T>("assets/abigail-portraits.png", ContentSource.ModFolder);
            }

            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
            
        }
    }
}