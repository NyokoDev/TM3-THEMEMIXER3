using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.TexturePanels
{
    public class BuildingAbandonedDiffusePanel : TexturePanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Structures;
            TextureID = TextureID.BuildingAbandonedDiffuse;
            base.Awake();
        }
    }
}
