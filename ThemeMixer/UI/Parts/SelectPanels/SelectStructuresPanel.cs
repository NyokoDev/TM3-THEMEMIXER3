using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.SelectPanels
{
    public class SelectStructuresPanel : SelectPanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Structures;
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
