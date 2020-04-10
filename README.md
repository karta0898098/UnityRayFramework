# UnityRayFramework

說明：
UnityRayFramework 是將自己在開發Unity上常常用到的功能給抽取出來。設計上參考了Github上的[EllanJiang/GameFramework](https://github.com/EllanJiang/GameFramework)
但將這些Component簡化設計成自己習慣的方式

Audio:可控制全局的音量大小以及播放暫停等
Base:控制遊戲暫停，關閉整個Framework
Blackboard:記錄全局的共用參數
Event:事件系統方便解類別之間的耦合程度
Timer:計時器系統，可以放便快速產生一個計時器任務
ObjectPool:提供物件池，減少物件頻繁銷毀造成的記憶體破碎
Procedure:整個遊戲流程的控制。
UI:控制UI的生命週期，開啟讀取等。
Resource:暫時採用的舊版的Resource.Load來讀取物件
Setting:簡單封裝了Unity的PlayerPrefs
Scene:場景切換管理
