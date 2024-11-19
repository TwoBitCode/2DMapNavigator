# **Unity MiniMap and Camera Project 🚀**

## **📖 Overview**
This project showcases a 2D game setup with:
- 🎯 **Dynamic MiniMap**: Maintains consistent dot size and view across screen orientations.
- 🎥 **Main Camera**: Ensures consistent player size and visible area, regardless of aspect ratio.

---

## **✨ Features**
- **🗺️ MiniMap**:
  - Uses a `RenderTexture` for a top-down view.
  - Keeps dot size consistent during screen rotation.
  - Adjustable visible scene area for flexibility.
- **🎮 Main Camera**:
  - Dynamically adjusts for aspect ratio changes.
  - Maintains player size consistency in portrait and landscape modes.

---

## **⚙️ Setup**
1. Clone the repository:
   ```bash
   git clone https://github.com/TwoBitCode/2DMapNavigator.git
   ```
2. Open the project in **Unity (2023.3 or later)**.
3. Open the `SampleScene` to test the setup.

---

## **🛠️ Included Scripts**
1. `CameraAdjusterConstantArea`:
   - Dynamically adjusts the orthographic size of the Main Camera to maintain a consistent visible area.
   - Ensures the player's size remains consistent.
2. `MiniMapCameraAdjuster`:
   - Fixes the orthographic size of the MiniMap Camera for a stable top-down view.
   - Keeps the MiniMap unaffected by screen orientation changes.

---

## **🎨 Customization**
- Adjust the `desiredSceneArea` in each script:
  - **Main Camera**: Set it for the main gameplay area.
  - **MiniMap Camera**: Control the zoom level of the MiniMap.

---

## **🌟 Contributors**
- Vivian Umansky, Miriam Nagar
