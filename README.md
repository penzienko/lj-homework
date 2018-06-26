## **How to run tests**

### **Windows Platform**
---

### In Visual Studio 2017

**Install**:
* [.Net Framework 4.7.1](https://www.microsoft.com/en-us/download/details.aspx?id=56116)
* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/)
* [Git](https://git-scm.com/downloads)
* [Google Chrome](https://www.google.com/chrome/) browser (install to the default path)

**Run tests**:
1. Clone the repository: `git clone https://github.com/penzienko/lj-homework.git`
2. Open the project\solution (`lj-homework.sln` file) in the Visual Studio
3. Restore NuGet via Package Manager Console: `PM> Update-Package`
4. Buid the project: _Build >> Build Solution_
5. Run tests in Test Explorer: _Test >> Windows >> Test Explorer_
---


### In CLI

**Install**:
* [.Net Framework 4.7.1](https://www.microsoft.com/en-us/download/details.aspx?id=56116)
* [Git](https://git-scm.com/downloads)
* [Google Chrome](https://www.google.com/chrome/) browser (install to the default path)
* [NuGet](https://www.nuget.org/downloads)
* [NUnit Console](http://nunit.org/download/)
* [Build Tools for Visual Studio 2017](https://visualstudio.microsoft.com/downloads/)

**Run tests**:
1. Clone the repository: `git clone https://github.com/penzienko/lj-homework.git`
2. Restore NuGet packages: `nuget restore <project path>\lj-homework.sln`
3. Build the project: `MSBuild <project path>\lj-homework.sln` 
4. Run tests from the CLI:
    * Run all tests: `nunit3-console.exe C:\Projects\Homework\lj-homework\lj-tests\bin\Debug\lj-tests.dll --result=<output folder>\TestResult.xml;format=nunit3`. (Please note the **NUnit** may not have rights to create a folder. Please create _output folder_ in advance).
    * To run a subcategory of the tests please add a parameter to the end of the command: `--where "cat =<category name>"`. _Category name_ means any tag defined in the feature files. E.g. to run all tests with **high** prioority please use the parameter `--where "cat = high"`. You can also combine different categories `--where "cat = high || medium"` or run only tests which contain all required tags `--where "cat = high && smoke"`

---

### **MasOS X Platform**
### TBD

