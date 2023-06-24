using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction.ColorPanel;

namespace ThemeMixer3.UI.Parts.ColorPanels
{
    public class SkyTintPanel : ColorPanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Atmosphere;
            ColorID = ColorID.SkyTint;
            base.Awake();
        }
    }
}
