using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.TexturePanels
{
    public class GrassDiffusePanel : TexturePanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Terrain;
            TextureID = TextureID.GrassDiffuseTexture;
            base.Awake();
        }
    }
}
