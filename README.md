# CoravelTaskWorkerLab
WorkerService + Serilog + WindowsService + Coravel   
 
## Windows Service 工具指令紀錄
#### 建立服務
```
sc.exe create YourServiceName DisplayName= 測試服務 binpath= C:\CoravelTaskWorkerLab.exe   
sc.exe create <ServiceName> DisplayName= <顯示名稱> binpath= <EXE完整路徑>
```
#### 刪除服務
```
 sc.exe delete YourServiceName
```

## 參考文章
* [利用 .NET Core Worker Service 來建置背景服務吧！](https://www.gss.com.tw/blog/net-core-worker-service)
* [sc.exe 建立:在登錄和服務控制管理員資料庫中建立服務的子機碼和專案。](https://docs.microsoft.com/zh-tw/windows-server/administration/windows-commands/sc-create)
