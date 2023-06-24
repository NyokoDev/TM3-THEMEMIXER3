using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.OffsetPanels
{
    public class GrassFieldPanel : OffsetPanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Terrain;
            OffsetID = OffsetID.GrassFieldColorOffset;
            base.Awake();
        }
    }
}
