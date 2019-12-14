<!--
 * @Description: CSharpFrameworksForU3D
 * @Version: 2.0
 * @Author: Luther
 * @Date: 2019-12-13 12:32:13
 * @LastEditors: Luther
 * @LastEditTime: 2019-12-14 23:19:21
 -->
# CSharpFrameworksForU3D
<div align="center"><font face="黑体" size=5>Unity3D比较常用的C#框架（导入即可使用）</font></div>

### 一、单例基类
#### &emsp;[1.MonoSingleton](./01_单例基类/MonoSingleton.cs)
><font color=#BDB76B size=2 face="宋体">*注：本单例可在OnEnable、Awake等方法中调用。</font>

### 二、解耦合
#### &emsp;[1.EventReg](./02_解耦合/CentralSystem/EventReg.cs)
#### &emsp;[2.EventCallback](./02_解耦合/CentralSystem/EventCallback.cs)
#### &emsp;[3.EventCenter](./02_解耦合/CentralSystem/EventCenter.cs)
><font color=#BDB76B size=2 face="宋体">*注：略。</font>
### 三、Sphere延时自转
#### &emsp;[1.SphereRotateDelay](./03_Sphere延时自转/SphereRotateDelay.cs)
><font color=#BDB76B size=2 face="宋体">*注：1.本框架基于WaveSDK-3.0.2。
<br>&emsp;&emsp;
2.进入WaveVR_DevicePoseTracker.cs脚本，将updatePose方法下的transform.localEulerAngles赋值给公有静态属性Vector3 HeadRotationValue。</font>

### 四、VRUI框架
#### &emsp;[1.UIManager](./04_VRUI框架/UIManager/UIManager.cs)
#### &emsp;[2.UIBaseWindow](./04_VRUI框架/UIManager/UIBaseWindow.cs)
#### &emsp;[3.UIMainWindow](./04_VRUI框架/UIWindowCanvasManager/UIMainWindow.cs)
#### &emsp;[4.GameController](./04_VRUI框架/GameController/GameController.cs)
><font color=#BDB76B size=2 face="宋体">*注：脚本1与2为UI框架创建之法，3和4为使用之法。</font>

### 五、异步加载场景
#### &emsp;[1.ChangeSceneAsync](./05_异步加载场景/SceneManager/ChangeSceneAsync.cs)
><font color=#BDB76B size=2 face="宋体">*注：略。</font>

---
- [返回顶部](#csharpframeworksforu3d)