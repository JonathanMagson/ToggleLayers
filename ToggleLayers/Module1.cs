using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Mapping;
using System.Linq;

namespace ToggleLayers
{
    internal class Module1 : Module
    {
        private static Module1 _this = null;

        public static Module1 Current => _this ??= (Module1)FrameworkApplication.FindModule("ToggleLayers_Module");

        /// <summary>
        /// Retrieves a layer by its name from the active map.
        /// </summary>
        /// <param name="layerName">The name of the layer.</param>
        /// <returns>The layer if found; otherwise, null.</returns>
        public Layer GetLayerByName(string layerName)
        {
            return MapView.Active?.Map?.Layers.FirstOrDefault(layer => layer.Name.Equals(layerName, System.StringComparison.OrdinalIgnoreCase));
        }

        protected override bool CanUnload()
        {
            return true;
        }
    }
}
