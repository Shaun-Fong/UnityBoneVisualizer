# UnityBoneVisualizer

 Visualize your character's bone.
 
 骨骼可视化！
 
**This is part of Animation Rigging which you can be found in Package manager->Animation Rigging**

**该插件是AnimationRigging里的一部分，我只是做了剥离。你可以直接在PackageManager里的AnimationRigging找到对应源码**

## Visualize bones in scene view.Scene视图窗口中的可视化骨骼

![Image1](https://i.ibb.co/TqKymS5/image.png)

## Select the bones and check the bones direction.选中骨骼和检查骨骼方向

![Image2](https://i.ibb.co/jJBkq24/image2.png)

## Install 安装

### 1.Via Unitypackage 通过unitypackage安装

Go [this](https://github.com/Shaun-Fong/UnityBoneVisualizer/releases) link download "**.unitypackage" and import to unity.

到该[链接](https://github.com/Shaun-Fong/UnityBoneVisualizer/releases)下载“**.unitypackage”并导入unity即可。

### 2.Via Unity Package Manager 通过Unity Package Manager安装（推荐）

Requires a version of unity that supports path query parameter for git packages（Unity >= 2019.3.4f1）

需要Unity版本大于2019.3.4f1

![images](https://user-images.githubusercontent.com/46207/79450714-3aadd100-8020-11ea-8aae-b8d87fc4d7be.png)

Click 'Add package from git URL' and add `https://github.com/Shaun-Fong/UnityBoneVisualizer.git?path=UnityBoneVisualizer` then Click 'Add' button.

点击“Add package from git URL” 并填入`https://github.com/Shaun-Fong/UnityBoneVisualizer.git?path=UnityBoneVisualizer`，然后等待编译完成即可使用。



## Usage 使用

Make sure to use the unity toolbar to add renderer component.(Bone Renderer->Setup)

确保使用Unity中的工具栏来添加对应的渲染组件（工具栏Bone Renderer->Setup），这样会直接自动添加所有子对象并进行渲染。

