using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction.ColorPanel;

namespace ThemeMixer3.UI.Parts.ColorPanels
{
    public class WaterDirtyPanel : ColorPanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Water;
            ColorID = ColorID.WaterDirty;
            base.Awake();
        }
    }
}
