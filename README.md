# **Unity MiniMap and Camera Project with Shooter Mechanics 🚀**


![image](https://github.com/user-attachments/assets/305030b1-543f-46fb-9b57-6c7516ed4ac2)


## **🌐 Play the Game on itch.io**
Explore and play our game on itch.io:

➡️ [TwoBitCode itch.io Games](https://twobitcode.itch.io)


## **📖 Overview**
This project showcases a 2D game setup with:
- 🎯 **Dynamic MiniMap**: Maintains consistent dot size and view across screen orientations.
- 🎮 **Shooter Mechanics**: Move the player using arrow keys or WASD, and fire bullets by clicking the mouse.
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
- **🔫 Shooter Mechanics**:
  - Move the player using **WASD** or **Arrow Keys**.
  - Aim using the **mouse**.
  - Shoot bullets by **left-clicking**.

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
1. **Player Movement and Shooting**:
   - Move with arrow keys or WASD.
   - Aim with the mouse.
   - Shoot bullets with the left mouse button.
2. `CameraAdjusterConstantArea`:
   - Dynamically adjusts the orthographic size of the Main Camera to maintain a consistent visible area.
   - Ensures the player's size remains consistent.
3. `MiniMapCameraAdjuster`:
   - Fixes the orthographic size of the MiniMap Camera for a stable top-down view.
   - Keeps the MiniMap unaffected by screen orientation changes.

---

## **🎨 Customization**
- Adjust the `speed` and `lifeTime` for bullets in the **Player** and **Bullet** scripts to fine-tune gameplay.
- Modify the `desiredSceneArea` in each script:
  - **Main Camera**: Set it for the main gameplay area.
  - **MiniMap Camera**: Control the zoom level of the MiniMap.

---

## **🌟 Contributors**
- Vivian Umansky
- Miriam Nagar
