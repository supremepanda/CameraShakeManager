# Camera Shake Manager

[![Unity 2019.1+](https://img.shields.io/badge/unity-2019.1%2B-blue.svg)](https://unity3d.com/get-unity/download)
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/supremepanda/CameraShakeManager/blob/master/LICENSE)
[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/furkanbaldir)

In game development, "camera shake" refers to a visual effect where the in-game camera rapidly moves or jitters in response to certain events or actions, such as explosions, impacts, or other dynamic occurrences. This effect is used to simulate the sensation of intense motion or vibration, adding realism and immersion to the game experience.

### Why should you use this Camera Shake Manager?

Because it is easy to use manager. It allows you add only one component under Cinemachine Virtual Camera and manage it. You can use this manager for multiple cameras. System is available to control multiple Camera Shake Manager.

### Installation

First of all, this asset dependent with DoTween.

https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676

Also you need Cinemachine package of Unity. It is already added as dependency, so you do not need to install.

then;

1. You can add git url via **Package Manager => Add package from git url**
```
https://github.com/supremepanda/CameraShakeManager.git#upm
```

2. You can also install via git url by adding this entry in your **manifest.json**
```
"com.supremepanda.camera_shake_manager": "https://github.com/supremepanda/CameraShakeManager.git#upm"
```

### How to use?

1- First of all, you need to create a Virtual Camera.

2- Then you should need to set Noise to Basic Multi Channel Perlin. And Noise profile is 6D Shake. Amplitude gain and frequency gain values should be 0.

3- After all, you need to add CameraShakeComponent. If you want to start with this camera, you can set ActivateOnStart. Every CameraShakeComponent has ```Activate(bool flag)``` method to control. When you change a camera, you should deactivate previous one and activate the new one. 

4- Create new CameraShakeSource scriptable object from Create menu. 

5- Configure your camera shake values from CameraShakeSource scriptable object.

6- Then you should add your source to CameraShakeComponent if you want to shake for this camera.
