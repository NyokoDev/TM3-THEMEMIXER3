using System;
using ThemeMixer3.Themes;
using ThemeMixer3.Themes.Enums;
using ThemeMixer3.UI.Abstraction.ColorPanel;

namespace ThemeMixer3.UI
{
    public class ThemeDirtyEventArgs : EventArgs
    {
        public ThemeCategory Category;
        public ThemePart Part;
        public IMixable Loadable;

        public ThemeDirtyEventArgs(ThemeCategory category, ThemePart part, IMixable loadable = null)
        {
            Loadable = loadable;
            Category = category;
            Part = part;
        }
    }

    public class UIDirtyEventArgs : EventArgs
    {
        public ThemeMix Mix;

        public UIDirtyEventArgs(ThemeMix mix)
        {
            Mix = mix;
        }
    }

    public class ThemeSelectedEventArgs : EventArgs
    {
        public string ThemeID;
        public ThemeCategory Category;
        public ThemePart Part;

        public ThemeSelectedEventArgs(string themeID, ThemeCategory category, ThemePart part)
        {
            ThemeID = themeID;
            Category = category;
            Part = part;
        }
    }

    public class ThemesPanelClosingEventArgs : EventArgs
    {
        public ThemeCategory Category;
        public ThemePart Part;
        public ThemesPanelClosingEventArgs(ThemeCategory category, ThemePart part)
        {
            Category = category;
            Part = part;
        }
    }

    public class ColorPanelVisibilityChangedEventArgs : EventArgs
    {
        public bool Visible;
        public ColorPanel Panel;

        public ColorPanelVisibilityChangedEventArgs(ColorPanel panel, bool visible)
        {
            Visible = visible;
            Panel = panel;
        }
    }
}
