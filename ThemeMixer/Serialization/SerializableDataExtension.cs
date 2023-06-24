using ICities;
using ThemeMixer3.Themes;

namespace ThemeMixer3.Serialization
{
    public class SerializableDataExtension : SerializableDataExtensionBase
    {
        public override void OnSaveData()
        {
            base.OnSaveData();
            ThemeManager.Instance.OnSaveData(serializableDataManager);
        }

        public override void OnLoadData()
        {
            base.OnLoadData();
            ThemeManager.Instance.OnLoadData(serializableDataManager);
        }
    }
}
