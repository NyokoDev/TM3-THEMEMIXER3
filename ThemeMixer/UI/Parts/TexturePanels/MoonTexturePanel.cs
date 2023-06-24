using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.TexturePanels
{
    public class MoonTexturePanel : TexturePanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Atmosphere;
            TextureID = TextureID.MoonTexture;
            base.Awake();
        }
    }
}
