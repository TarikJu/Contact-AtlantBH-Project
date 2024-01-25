Prerequisite:
- dotnet 8.0.0
- Selenium NUnit with required NUnit packages WebDriver, ChromeDriver, NUnit3TestAdapter etc.

How to run tests:
- 1st way: use IDE like Visual Studio and open Test Explorer by clicking Test tab > Test Explorer - build the project then select which test to run
- 2nd way: open the terminal in the IDE and run a test with the command: 
  dotnet test --filter "Category=smoketest" .\Nunitproj.sln (with or without Category, in this case we want to run one of the smoke tests)

  Env variables will be found in
  - appsettings.json
 
    

  

  






