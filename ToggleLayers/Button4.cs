using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Mapping;
using System.Linq;

namespace ToggleLayers
{
    internal class Button4 : Button
    {
        protected override void OnClick()
        {
            // Access the dockpane to get the layer name
            var dockpane = FrameworkApplication.DockPaneManager.Find("ToggleLayers_LayerSettingsDockpane") as LayerSettingsDockpane;
            if (dockpane == null) return;

            var layerName = dockpane.Layer4; // Get the layer name from the dockpane
            if (string.IsNullOrEmpty(layerName)) return; // Ensure the layer name is not null or empty

            QueuedTask.Run(() =>
            {
                // Get the layer from the map by name
                var layer = MapView.Active?.Map?.GetLayersAsFlattenedList()?.FirstOrDefault(l => l.Name == layerName);
                if (layer != null)
                {
                    // Toggle the visibility
                    layer.SetVisibility(!layer.IsVisible);
                }
            });
        }
    }
}
