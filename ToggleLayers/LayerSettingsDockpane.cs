using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace ToggleLayers
{
    internal class LayerSettingsDockpane : DockPane
    {
        private const string _dockPaneID = "ToggleLayers_LayerSettingsDockpane";

        protected LayerSettingsDockpane() { }

        internal static void Show()
        {
            FrameworkApplication.DockPaneManager.Find(_dockPaneID).Activate();
        }

        public string Layer1 { get; set; }
        public string Layer2 { get; set; }
        public string Layer3 { get; set; }
        public string Layer4 { get; set; }
        public string Layer5 { get; set; }
    }
}
