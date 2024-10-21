## About The Project
An Augmented Reality (AR) app developed in Unity that enhances art museum goers exploration of art museums through a museum visitor heatmap, artwork deconstruction and artwork sharing with companions. This proof of concept version allows you to scan an image of the Mona Lisa and view its visual composition overlaid and colour scheme. The sharing features creates a ball with the artwork that can be dragged around. The map functionality shows a static heatmap. 

## Features
- Scan Mona Lisa for visual composition and colour scheme
- Static heatmap
- Drag share ball

## Requirements
- Unity 2022.3.45 or later
- AR Foundation package
- ARKit XR Plugin (for iOS)

## Getting Started
### Prerequisites
1. Install Unity Hub: Download and install Unity Hub.
2. Install Unity: Through Unity Hub, install the Unity Editor (version 2022.3.45 or later).
3. Setup AR Foundation: Open your project in Unity, go to Window -> Package Manager, and install the AR Foundation package along with ARKit XR Plugin.

### Project Setup
1. Clone/ download the repository
2. Open the project: Open Unity Hub, click on Add, and select the project folder.

3. Build settings:
- Go to File/ Build Settings.
- Select iOS as your platform.
- Click Switch Platform.
- Make sure SampleScene is in Scenes in Build, if not drag it in from the Assets/Scenes folder. 

4. Player settings:
- In the Build Settings window, click on Player Settings.
- Under Other Settings, set the Bundle Identifier (for iOS).
- Enable ARKit in the XR Settings.
- Make sure RequiresARKit support is ticked.

5. Project settings:
- Under XR Plug-in Management, select iOS and make sure Apple ARKit is ticked.

## Running the App
1. Connect your device via USB and ensure it is registered in your Apple Developer account.
2. Make sure your phone is in Developer Mode - under Privacy & Security.

4. Build and Run:
- Go to File/ Build and Run.
- Select yes, when ask about the Project ID.
- Unity will build the project and deploy it to your connected device.
- If there are issues with the bundle identifier, edit the bundle identifier
- Make sure your account is selected under Team in Signing & Capabilities
- On your phone allow the app under General/ VPN & Device Management

## Usage
- Launch the app on your device.
- Grant permissions for camera and AR functionality.
- Scan image of [Mona Lisa](https://drive.google.com/file/d/1CgLZPE-Db8RuFAbgdLhvo8hUU0qOfNp6/view?usp=sharing)

## References
Gupta, H. (2024, July 2). Himankgupta1/Unity-AR-Application: Discover the possibilities of Augmented Reality (AR) with Unity-AR-App. This demo application demonstrates basic AR capabilities through interactive 3D models in a virtual environment. Deployed on Android, with visuals provided for a preview. Unity-AR-Application. https://github.com/himankgupta1/Unity-AR-Application/tree/main
samyam (Director). (2022, December 13). How to Build & Run Unity to iOS for Testing [Video recording]. https://www.youtube.com/watch?v=-Hr4-XNCf8Y
![image](https://github.com/user-attachments/assets/338035da-cfa2-4781-9229-17d20280617d)

