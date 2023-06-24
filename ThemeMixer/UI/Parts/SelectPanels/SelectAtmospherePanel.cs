using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.SelectPanels
{
    public class SelectAtmospherePanel : SelectPanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Atmosphere;
            base.Awake();
            ButtonPanel.isVisible = true;
        }

        public override void Start()
        {
            base.Start();
            CenterToParent();
        }
    }
}
