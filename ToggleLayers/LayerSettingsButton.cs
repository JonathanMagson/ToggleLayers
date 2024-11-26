using ArcGIS.Desktop.Framework.Contracts;

namespace ToggleLayers
{
    internal class LayerSettingsButton : Button
    {
        protected override void OnClick()
        {
            LayerSettingsDockpane.Show();
        }
    }
}
