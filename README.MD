# Test for Microsoft.Extensions.Logging.Log4Net.AspNetCore 

### Note
- I have directly included the project from DEV branch to check if the latest changes have solved this issue.
- I have removed the support of NET462 of Microsoft.Extensions.Logging.Log4Net.AspNetCore  because my computer does not have NET462. (Sorry) However, as we are targetting a netcoreapp2.0 application, so this shouldn't be an issue.

### How to Reproduce the issue
1. Open `NetCoreWebApplication.sln` with `visual studio 2017`
2. Run the `NetCoreWebApplication` as a `Windows Service` (Not `IIS`).
3. Navigate to `http://localhost:51286/api/Home`, you should see `["Hello","World"]`.
4. Now go to `.\NetCoreWebApplication\bin\Debug\netcoreapp2.0` and open `log.txt`.
5. Notice that I have added some log messages in the Project. Firstly, `HELLO` at `.\NetCoreWebApplication\Startup.cs`. Secondly,`Home controller is constructed` and `Hi` at `.\NetCoreWebApplication\Controllers\HomeController.cs`. They did not appear at the `log.txt`.
6. The `log.txt` that I have generated is `.\log.txt`