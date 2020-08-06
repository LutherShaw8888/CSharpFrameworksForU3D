<!--
 * @Description: CSharpFrameworksForU3D
 * @Version: 2.0
 * @Author: Luther
 * @Date: 2019-12-13 12:32:13
 * @LastEditors: Luther
 * @LastEditTime: 2019-12-15 23:15:30
 -->
# CSharpFrameworksForU3D
<div align="center"><font face="黑体" size=5>Unity3D常用C#框架（导入即可使用）</font></div>

### 一、单例基类
#### &emsp;[1.MonoSingleton](./01_单例基类/MonoSingleton/MonoSingleton.cs)
###### `*注：本单例可在OnEnable、Awake等方法中调用。`

### 二、解耦合
#### &emsp;[1.EventReg](./02_解耦合/CentralSystem/EventReg.cs)
#### &emsp;[2.EventCallback](./02_解耦合/CentralSystem/EventCallback.cs)
#### &emsp;[3.EventCenter](./02_解耦合/CentralSystem/EventCenter.cs)
###### `*注：略。`

### 三、Sphere延时自转
#### &emsp;[1.SphereRotateDelay](./03_Sphere延时自转/SphereRotateDelay.cs)
###### `*注：①本框架基于WaveSDK-3.0.2；②进入WaveVR_DevicePoseTracker.cs脚本，将updatePose方法下的transform.localEulerAngles赋值给公有静态属性Vector3 HeadRotationValue。`

### 四、VRUI框架
#### &emsp;[1.UIManager](./04_VRUI框架/UIManager/UIManager.cs)
#### &emsp;[2.UIBaseWindow](./04_VRUI框架/UIManager/UIBaseWindow.cs)
#### &emsp;[3.UIMainWindow](./04_VRUI框架/UIWindowCanvasManager/UIMainWindow.cs)
#### &emsp;[4.GameController](./04_VRUI框架/GameController/GameController.cs)
###### `*注：脚本1与2为UI框架创建之法，3和4为使用之法。`

### 五、异步加载场景
#### &emsp;[1.ChangeSceneAsync](./05_异步加载场景/SceneManager/ChangeSceneAsync.cs)
###### `*注：略。`

### 六、转场留物
#### &emsp;[1.DontDestroyOnSceneChange](./06_转场留物/DontDestroyOnSceneChange/DontDestroyOnSceneChange.cs)
###### `*注：想保留哪个物体（及其子物体），就把脚本拖拽到那个物体上。`

### 七、精灵帧动画
#### &emsp;[1.SpriteInvokeRepeating](./07_精灵帧动画/SpriteInvokeRepeating.cs)
###### `*注：实现gif动画。`

### 八、动态人物烘焙成静态
#### &emsp;[1.BakePerson](./08_动态人物烘焙静态/BakePerson.cs)
###### `*注：效果图展示。`![烘焙动态人物效果展示](https://github.com/LutherShaw8888/CSharpFrameworksForU3D/blob/master/08_%E5%8A%A8%E6%80%81%E4%BA%BA%E7%89%A9%E7%83%98%E7%84%99%E9%9D%99%E6%80%81/%E7%83%98%E7%84%99%E5%8A%A8%E6%80%81%E4%BA%BA%E7%89%A9%E7%A4%BA%E4%BE%8B%E5%9B%BE.JPG)
---
- [返回顶部](#csharpframeworksforu3d)
