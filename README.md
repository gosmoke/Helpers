# Introduction 
Welcome to the UTS Nuget Repository!

# Software Versioning Scheme
**major.minor.maintenance.build**  (example:  *1.1.5.12*)

# Version Log
## UTS.Integration
| Versions | Notes | Date |
| --- | --- | --- |
| 1.0.0.1 | Initial creation of IntegrationService | 12/5/2018 |
| 1.0.0.2 | Updated NewtonSoft from 6.0.4 to 11.0.1 | 12/7/2018 |
| 1.0.0.3 | Added Interface for IntegrationService class.  Added Bearer Token Authetication and supporting methods. | 12/7/2018 |
| 1.0.0.4 | Added a public property to set Token. | 12/10/2018 |
| 1.0.0.5 | Added missing async methods to Interface. | 12/10/2018 |
| 1.0.0.6 | Added method to set Token. | 12/10/2018 |
| 1.0.0.7 | Added a new Post method that does not return a response value.  Updated methods to throw exceptions only if the status code returned is 500 or greater. | 12/13/2018 |
| 1.0.0.9 | Added a new Post method that does not take an argument or return a response value. | 1/7/2019 |
| 1.0.0.10 | Added methods for DeleteAsync to accept a content body.  Added CancellationToken methods for Verb methods. | 2/20/2019 |
| 1.0.0.11 | Added Invalid Status for Service Message Severity. | 3/19/2019 |
| 1.0.0.12 | Added a new PostAsync method that does not take an argument, but returns a response value. | 4/2/2019 |
| 1.0.0.13 | Added a new DeleteAsync method that does not take an argument, but returns a response value. | 4/15/2019 |
| 1.0.0.14 | Added additional PutAsync methods and cleaned up IntegrationService a bit. Added StatusCode to IResponse | 4/16/2019 |
| 1.0.0.15 | Added ability to decompress response if compressed with GZip. | 4/23/2019 |
| 1.0.0.266 | Removed decompress of response.  Never used and failed at times.  |  01/03/2022 |

## UTS.Common
| Versions | Notes | Date |
| --- | --- | --- |
| 1.0.0.1 | Initial creation of Common project.  Contains constants, extensions and helper utilities. | 7/1/2019 |

## UTS.Constants
| Versions | Notes | Date |
| --- | --- | --- |
| 1.0.0.1 | Initial creation of Constants project.  Contains constants for database tables and columns. | 7/1/2019 |


# Getting Started
To make changes to the Nuget code repository, you'll need to do a few things first.
1.  Make sure you have Git installed on your machine. 
    - Open command window.  Type:  `git --version`
    - If it is not installed, go here:  [Download Git for Windows](https://git-scm.com/download/win)
    - { *If you need help navigating through the setup wizard, talk to a Senior Developer.* }
2.  Once you have Git installed, create a folder on your local computer where the solution will live.  
    - *C:/Projects/Nuget*
3.  Open your favorite command window { *vim, bash, etc.* } and navigate to your solution path you created.
4.  Type:  `git clone https://UTSDevTeam@dev.azure.com/UTSDevTeam/UTSNuget/_git/UTSNuget` and press enter.
5.  It will ask you to authenticate using your UTS credentials.  
6.  Once authenticated, all the files will download and you'll be defaulted to the **Dev** branch.
7.  Open the solution in Visual Studio and make your updates.

# Accessing UTS Nuget Packages
If you compile the solution with the new WebAPI changes for the first time, chances are you will get a compilation error for UTS.Integration.  You'll need to configure Visual Studio to point to our UTS Nuget folder.  Follow the steps below.
1.  To configure this Nuget source, right click on the References folder for the project you need to add this to and click Manage Nuget Packages…
2.  Click the gear next to the package source dropdown.
3.  Click the green plus sign in the upper right corner of the popup window.
4.  Two new sources will be added. Update the Name and Source for each source as follows:

    ### Production
    - Name: **UTSNuget** 
    - Source: **https://pkgs.dev.azure.com/UTSDevTeam/_packaging/UTSNuget/nuget/v3/index.json**

    ### Test
    - Name: **UTSNuget TEST** 
    - Source: **https://pkgs.dev.azure.com/UTSDevTeam/_packaging/UTSNuget.TEST/nuget/v3/index.json**
5.  Click Update button. Click OK.
    
    *Test should be used when you are testing new features that you don't want available for download by other developers (ie: in production).*

You can now rebuild your project, add nuget packages to your project and update versions.  

# Contributing
1.  Do **NOT** modify files while on any of the major 3 branches { **Dev, Test, master** }.
2.  Always check out a new branch before beginning work.  
3.  Follow our branching guildlines { *coming soon* }
4.  All work can be committed and pushed to your own remote feature branch.  All merges to Dev, Test and master **MUST** be initiated using a Pull Request.
    - Ask for assistance.
5.  Only **Dev** can be merged into **Test**.
    - Only to be done by an authorized user.
    - *Manager review may be necessary*.
6.  Only **Test** can be merged into **master**.
    - Only to be done by an authorized user.
    - *Manager review may be necessary*.

# Learning
If you want to learn more about working with Git, check out these links below:
- [Sourcetree](https://www.sourcetreeapp.com/)
- [Visual Studio and Git](https://docs.microsoft.com/en-us/azure/devops/repos/git/gitquickstart?view=vsts&tabs=visual-studio)
- [Git on the Command Line](https://docs.gitlab.com/ee/gitlab-basics/start-using-git.html)