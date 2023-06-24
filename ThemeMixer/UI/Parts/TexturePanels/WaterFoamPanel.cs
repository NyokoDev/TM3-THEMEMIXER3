using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.TexturePanels
{
    public class WaterFoamPanel : TexturePanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Water;
            TextureID = TextureID.WaterFoam;
            base.Awake();
        }
    }
}
