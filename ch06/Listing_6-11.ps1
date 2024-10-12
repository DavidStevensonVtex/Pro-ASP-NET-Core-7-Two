# Listing 6.11 Running unit tests

dotnet test

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing> ..\Listing_6-11.ps1
#   Determining projects to restore...
#   All projects are up-to-date for restore.
#   SimpleApp -> D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing\SimpleApp\bin\Debug\net8.0\SimpleApp.dll
#   SimpleApp.Tests -> D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing\SimpleApp.Tests\bin\Debug\net8.0\SimpleApp.Tests.dll
# Test run for D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing\SimpleApp.Tests\bin\Debug\net8.0\SimpleApp.Tests.dll (.NETCoreApp,Version=v8.0)
# VSTest version 17.11.0 (x64)

# Starting test execution, please wait...
# A total of 1 test files matched the specified pattern.
# [xUnit.net 00:00:00.21]     SimpleApp.Tests.ProductTests.CanChangeProductPrice [FAIL]
#   Failed SimpleApp.Tests.ProductTests.CanChangeProductPrice [8 ms]
#   Error Message:
#    Assert.Equal() Failure: Values differ
# Expected: 100
# Actual:   200
#   Stack Trace:
#      at SimpleApp.Tests.ProductTests.CanChangeProductPrice() in D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing\SimpleApp.Tests\ProductTests.cs:line 32 
#    at System.RuntimeMethodHandle.InvokeMethod(Object target, Void** arguments, Signature sig, Boolean isConstructor)
#    at System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(Object obj, BindingFlags invokeAttr)

# Failed!  - Failed:     1, Passed:     1, Skipped:     0, Total:     2, Duration: 26 ms - SimpleApp.Tests.dll (net8.0)

# Workload updates are available. Run `dotnet workload list` for more information.