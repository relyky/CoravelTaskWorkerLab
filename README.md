# CoravelTaskWorkerLab
 
### 建立服務
sc.exe create AAWorkerLab DisplayName= 測試服務 binpath= C:\GitHubRepos\CoravelTaskWorkerLab\CoravelTaskWorkerLab\bin\Release\net6.0\CoravelTaskWorkerLab.exe   
sc.exe create <ServiceName> DisplayName= <顯示名稱> binpath= <EXE完整路徑>   

### 刪除服務
sc.exe delete AAWorkerLab
