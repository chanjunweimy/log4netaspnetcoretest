# Test for Microsoft.Extensions.Logging.Log4Net.AspNetCore 

### How to Reproduce the issue
1. Open `NetCoreWebApplication.sln` with `visual studio 2017`
2. Run the `NetCoreWebApplication` as a `Windows Service` (Not `IIS`).
3. Navigate to `http://localhost:51286/api/Home`, you should see `["Hello","World"]`.
4. Now go to `.\NetCoreWebApplication\bin\Debug\netcoreapp2.0`.
5. You can see `log.txt` but not `overrided.log`.