# debermuda app

Sample app to test Azure deployments.

## Purpose and Functionality

The De Bermuda app allows users to vote on whether they can work in shorts. The app collects votes and displays the results in a chart.

## Architecture and Technologies Used

The application consists of a front-end and a back-end. The front-end is a simple HTML page with JavaScript for interactivity. The back-end is an ASP.NET Core Web API that handles the voting logic and stores the votes in a SQL Server database.

Technologies used:
- ASP.NET Core
- Entity Framework Core
- SQL Server
- JavaScript
- Bootstrap
- Chart.js

## Setup and Running the Application

### Prerequisites

- .NET Core SDK 3.0 or later
- Node.js and npm

### Back-end Setup

1. Navigate to the `debermuda-api` directory.
2. Restore the .NET dependencies by running:
   ```
   dotnet restore
   ```
3. Update the database connection string in `Data/VoteContext.cs` to match your SQL Server configuration.
4. Run the application:
   ```
   dotnet run
   ```

### Front-end Setup

1. Navigate to the `debermuda-app` directory.
2. Install the npm dependencies by running:
   ```
   npm install
   ```
3. Open `index.html` in a web browser to view the application.

## API Endpoints

### Get Votes

- **URL:** `/vote`
- **Method:** `GET`
- **Description:** Retrieves the list of votes.
- **Response:**
  ```json
  [
    {
      "id": 1,
      "voteValue": true,
      "createdAt": "2021-01-01T00:00:00"
    },
    ...
  ]
  ```

### Create Vote

- **URL:** `/vote`
- **Method:** `POST`
- **Description:** Creates a new vote.
- **Request Body:**
  ```json
  {
    "value": true
  }
  ```

## Front-end Application

The front-end application is a simple HTML page with JavaScript for interactivity. It uses Bootstrap for styling and Chart.js for displaying the results in a chart.

### Dependencies

- Bootstrap
- Chart.js

### Building and Running

1. Navigate to the `debermuda-app` directory.
2. Install the npm dependencies by running:
   ```
   npm install
   ```
3. Open `index.html` in a web browser to view the application.

## Database Configuration and Connection Details

The application uses Entity Framework Core to interact with a SQL Server database. The connection string is configured in the `Data/VoteContext.cs` file. Update the connection string to match your SQL Server configuration.

## Deployment Process and Environment Settings

### Deployment

1. Build the back-end application:
   ```
   dotnet publish -c Release
   ```
2. Deploy the published files to your server or cloud provider.

### Environment Settings

The application uses the following environment settings:

- `ASPNETCORE_ENVIRONMENT`: Specifies the environment (e.g., Development, Production).
- `ApplicationInsights:InstrumentationKey`: The instrumentation key for Application Insights.

Update these settings in the `appsettings.json` and `appsettings.Development.json` files as needed.
