using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.SelectPanels
{
    public class SelectThemePanel : SelectPanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Themes;
            base.Awake();
            ButtonPanel.isVisible = false;
        }
    }
}
