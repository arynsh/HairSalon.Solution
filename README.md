# Hair Salon Database

#### A website to keep track of a salon database.

#### By **Sharon Lee**
## 🎉 Contents

- [Description](#-description)
- [Specifications](#-specifications)
- [Instructions](#-instructions)
- [Contact](#-contact)
- [License](#-license)

## Description
A program for a salon owner that enables them to keep track of hair stylists and clients associated with each stylist.

### Specifications
| Spec | Input | Output |
| :-------------     | :------------ | :------------- |
| **Homepage** | User accesses:http://localhost:5000/| User view:Landing Homepage |
| **User enters in a stylist|  Stylist12 | Stylist List: Stylist12 |
| **User adds a new client to a stylist | Client12 |  Stylist12: Client12 |
| **User clicks button to view list of clients | (click button) | Client12 : Stylist12 |

### Instructions

1. Clone this repository: https://github.com/arynsh/HairSalon.Solution
2. Open the command line--and navigate into the repository, then navigate into the HairSalon folder.
3. In your MySQLWorkbench, create a new schema 'sharon_lee'. Paste sql commands to generate two tables:

CREATE TABLE `clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `StylistId` int(11) DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


4. In the command line, type in "dotnet restore" then "dotnet run".
5. On your browser, open http://localhost:5000

## Known Bugs
* No known bugs at this time.

## 📋 Technologies Requirements
 You may use Windows, macOS, or Linux as your development operating system, though building and running apps may be limited.
 Tools used:  
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.Net](https://dotnet.microsoft.com/apps/aspnet)
* [MySQLWorkbench](https://www.mysql.com/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/#pivot=entityfmwk)
* Microsoft.NET.Sdk.Web
* [Visual Studio](https://www.visualstudiocommunity.com)
* [GitHub](https://www.github.com)
* HTML
 
### Support and Contact details
| Author | GitHub | Email |
|--------|:------:|:-----:|
Sharon Lee| [arynsh](https://github.com/arynsh) |  [sharonlee714@gmail.com](mailto:sharonlee714@gmail.com) 

_Please contact with questions and/or comments._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **Sharon Lee**
