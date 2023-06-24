using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI.Parts.ValuePanels
{
    public class MaxTemperatureNightPanel : ValuePanel
    {
        public override void Awake()
        {
            Category = ThemeCategory.Weather;
            ValueID = ValueID.MaxTemperatureNight;
            base.Awake();
        }
    }
}
