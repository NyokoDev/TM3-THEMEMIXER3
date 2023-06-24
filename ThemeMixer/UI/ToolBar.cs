using ColossalFramework.UI;
using ThemeMixer3.UI.Abstraction;

namespace ThemeMixer3.UI
{
    public class ToolBar : PanelBase
    {
        public event DragHandle.DragEndEventHandler EventDragEnd;
        public event ButtonBar.ButtonClickedEventHandler EventButtonClicked;

        private DragHandle _dragBar;
        private ButtonBar _buttonBar;

        public override void Awake()
        {
            base.Awake();
            Setup("Tool Bar", 0.0f, 50.0f, 0, true, LayoutDirection.Horizontal, LayoutStart.TopLeft, "GenericPanel");
            

            _dragBar = AddUIComponent<DragHandle>();
            _dragBar.EventDragEnd += OnDragBarDragEnd;

            _buttonBar = AddUIComponent<ButtonBar>();
            _buttonBar.EventButtonClicked += OnButtonClicked;
        }

        public override void OnDestroy()
        {
            _dragBar.EventDragEnd -= OnDragBarDragEnd;
            _buttonBar.EventButtonClicked -= OnButtonClicked;
            base.OnDestroy();
        }

        private void OnButtonClicked(ToolbarButton button, ToolbarButton[] buttons) => EventButtonClicked?.Invoke(button, buttons);

        private void OnDragBarDragEnd() => EventDragEnd?.Invoke();
    }
}
