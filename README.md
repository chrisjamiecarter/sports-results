<div align="center">

<img src="./_resources/logo.png" alt="sports results logo" width="100px" />
<h1>Sports Results</h1>

</div>

Welcome to the Sports Results App!

This is a .NET project designed to demonstrate harvesting data from non-api sources and sending emails. 

## Requirements

- [x] Application must be able to read sports data from a website once a day and send it to a specific e-mail address.
- [x] The application must be a service that runs automatically.
- [x] The application must harvest data from the Basketball Reference Website.
- [x] The Agility Pack library must be used for scraping.


## Features

- **Basketball Scores**

    Service scraps the Basketball Reference Website once a day and emails the results.

- **Application Configuration**

    There are a multitude of options in the appsettings.json to play around with.

## Getting Started

### Prerequisites

- .NET 8 SDK installed on your system.
- A code editor like Visual Studio or Visual Studio Code
- SQL Server
- SQL Server Management Studio (SSMS)

### Installation

1. Clone the repository:
    - `git clone https://github.com/cjc-sweatbox/sports-results.git`

2. Configure the application:
    - Navigate to the `.\src\SportsResults.WorkerService\` directory.
    - Update the `appsettings.json` file with your email settings.

3. Build the application:
    - Navigate to the `.\src\` directory.
    - `dotnet build`

### Running the Application

1. Run the console application using the .NET CLI:
    - Navigate to the `.\src\SportsResults.WorkerService\` directory.
    - `dotnet run`

### Usage

- **Background Worker Service**:
Fire and forget. Service will run in the background until told to stop.
- **Scraper Service Options**:
Set the `DateOverride` to `true` and set the day, month, year values to test specific dates.
- **WorkerServiceOptions**:
Set the initial hour, minute that the service runs. And also the inteval that scores will be retrieved and emailed.
- **Mail Options**:
Set the required settings for your email account.

## How It Works

- **Web Scraping**:
The [HtmlAgilityPack](https://html-agility-pack.net/) library is used to scrape data from the web.
- **Data**:
The data is scraped from the [Basketball Reference](https://www.basketball-reference.com/boxscores/) website.
- **Email**:
System.Net.Mail is used to configur and send emails.
- **Email Validation**:
The [FluentValidation](https://fluentvalidation.net/) library is used to validate email addresses.

## Contributing

Contributions are welcome!
Please fork the repository and create a pull request with your changes.
For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License.
See the [LICENSE](./LICENSE) file for details.

## Contact

For any questions or feedback, please open an issue.

---
***Happy Sports Resulting!***
