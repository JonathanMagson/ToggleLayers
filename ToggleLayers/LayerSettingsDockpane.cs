using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using System;
using System.IO;
using System.Text.Json;

namespace ToggleLayers
{
    internal class LayerSettingsDockpane : DockPane
    {
        private const string _dockPaneID = "ToggleLayers_LayerSettingsDockpane";
        private const string _settingsFileName = "ToggleLayersSettings.json";

        protected LayerSettingsDockpane()
        {
            // Load settings when the dockpane is initialized
            LoadLayerSettings();
        }

        internal static void Show()
        {
            FrameworkApplication.DockPaneManager.Find(_dockPaneID).Activate();
        }

        // Properties for layer names
        private string _layer1;
        private string _layer2;
        private string _layer3;
        private string _layer4;
        private string _layer5;

        public string Layer1
        {
            get => _layer1;
            set
            {
                SetProperty(ref _layer1, value, nameof(Layer1));
                SaveLayerSettings(); // Save settings when property changes
            }
        }

        public string Layer2
        {
            get => _layer2;
            set
            {
                SetProperty(ref _layer2, value, nameof(Layer2));
                SaveLayerSettings();
            }
        }

        public string Layer3
        {
            get => _layer3;
            set
            {
                SetProperty(ref _layer3, value, nameof(Layer3));
                SaveLayerSettings();
            }
        }

        public string Layer4
        {
            get => _layer4;
            set
            {
                SetProperty(ref _layer4, value, nameof(Layer4));
                SaveLayerSettings();
            }
        }

        public string Layer5
        {
            get => _layer5;
            set
            {
                SetProperty(ref _layer5, value, nameof(Layer5));
                SaveLayerSettings();
            }
        }

        /// <summary>
        /// Save the current layer settings to a JSON file.
        /// </summary>
        public void SaveLayerSettings()
        {
            var settings = new LayerSettings
            {
                Layer1 = _layer1,
                Layer2 = _layer2,
                Layer3 = _layer3,
                Layer4 = _layer4,
                Layer5 = _layer5
            };

            string settingsFilePath = GetSettingsFilePath();
            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(settingsFilePath, json);
        }

        /// <summary>
        /// Load saved layer settings from a JSON file.
        /// </summary>
        public void LoadLayerSettings()
        {
            string settingsFilePath = GetSettingsFilePath();

            if (File.Exists(settingsFilePath))
            {
                try
                {
                    // Read the JSON file
                    string json = File.ReadAllText(settingsFilePath);

                    // Deserialize into a strongly-typed object
                    var settings = JsonSerializer.Deserialize<LayerSettings>(json);

                    // Assign the settings to the properties
                    Layer1 = settings?.Layer1 ?? string.Empty;
                    Layer2 = settings?.Layer2 ?? string.Empty;
                    Layer3 = settings?.Layer3 ?? string.Empty;
                    Layer4 = settings?.Layer4 ?? string.Empty;
                    Layer5 = settings?.Layer5 ?? string.Empty;
                }
                catch (Exception ex)
                {
                    // Log or handle errors
                    System.Diagnostics.Debug.WriteLine($"Error loading settings: {ex.Message}");

                    // Assign default values if deserialization fails
                    Layer1 = string.Empty;
                    Layer2 = string.Empty;
                    Layer3 = string.Empty;
                    Layer4 = string.Empty;
                    Layer5 = string.Empty;
                }
            }
            else
            {
                // Assign default values if the file does not exist
                Layer1 = string.Empty;
                Layer2 = string.Empty;
                Layer3 = string.Empty;
                Layer4 = string.Empty;
                Layer5 = string.Empty;
            }
        }

        /// <summary>
        /// Get the full file path for the settings file.
        /// </summary>
        /// <returns>The file path for the settings file.</returns>
        private string GetSettingsFilePath()
        {
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folderPath = Path.Combine(userProfilePath, "ToggleLayers");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            return Path.Combine(folderPath, _settingsFileName);
        }

        /// <summary>
        /// Save settings when the dockpane is closed.
        /// </summary>
        protected override void OnHidden()
        {
            base.OnHidden();
            SaveLayerSettings();
        }
    }

    /// <summary>
    /// Class representing the structure of layer settings.
    /// </summary>
    public class LayerSettings
    {
        public string Layer1 { get; set; }
        public string Layer2 { get; set; }
        public string Layer3 { get; set; }
        public string Layer4 { get; set; }
        public string Layer5 { get; set; }
    }
}
