# ToggleLayers ArcGIS Pro Add-in

## Overview
The **ToggleLayers** add-in for ArcGIS Pro allows users to quickly toggle the visibility of up to five layers using dedicated buttons or customizable keyboard shortcuts. Users can configure which layers to control via a settings menu, and these settings persist between sessions.

## Installation

### 1. Download the Add-in (`.esriAddInX`)

### 2. Install the Add-in
- Double-click the `.esriAddInX` file to install it.
- Follow the prompts in the **ArcGIS Pro Add-in Manager**.

### 3. Launch ArcGIS Pro
- The **Toggle Layers** tab should appear in the ribbon.

## Usage

### 1. Open the Layer Settings Dockpane
- In the **Toggle Layers** tab of the **Add-in ribbon**, click **Layer Settings**.
- This opens the **Layer Settings Dockpane**, where you can enter the names of up to five layers.
- Close the settings window; the names will be saved automatically.

### 2. Toggle Layers On/Off
- Click one of the **Toggle Layer** buttons (**1–5**) to show or hide the corresponding layer.

### 3. Assign Keyboard Shortcuts
To quickly toggle layers using hotkeys, configure keyboard shortcuts in **ArcGIS Pro**:

1. **Go to**  
   `Project > Options > Customize the Ribbon > Keyboard Shortcuts`
2. **Click "Add New Shortcut"**
3. **Search for the Toggle Button IDs**:
   - Search for **"1"** and assign a desired shortcut (e.g., `Ctrl+1`).
   - Repeat for **"2"**, **"3"**, **"4"**, and **"5"** to assign hotkeys for each toggle button.
4. **Click OK** to save your shortcuts.

Now, pressing the assigned hotkeys will **toggle the corresponding layer visibility** without using the ribbon.


![image](https://github.com/user-attachments/assets/a9de840b-a8a2-426c-8bf0-0e08e147a9b2)
