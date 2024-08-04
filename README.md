## Movie Application

A basic MovieDatabase application using ASP.Net Core MVC.  ~~ I said "database" but for now program only holds data while it is running. ~~ I'll learn more about databases and then ~~ I'll update project. ~~

So I added 2 new things : 

* Adding movies to database
* Movie degree has a range between 1-10

## Features

* Add a new movie with a name and degree.
* List all movies.
* Display a message when there are no movies.

## Requirements

* .NET 6.0 SDK or later
* Visual Studio 2022 or later / Visual Studio Code

## Getting Started

* Clone the Repository

``git clone https://github.com/yourusername/movie-application.git``
``cd movie-application``

## Run the Application

* Open the project in Visual Studio or Visual Studio Code.
* Build the project.
* Run the application.
* The application will be available at ``https://localhost:7203``.

## Project Structure

* Controllers: Contains the MovieController which handles the logic for adding and listing movies.
* Models: Contains the MovieViewModel which represents the movie data.
* Views: Contains the Razor views for adding and listing movies.

## Usage
* First you need to change something in the appsettings.json
``` DefaultConnection": "Server=localhost;Database=FilmVerileri;User Id=YOUR_SERVER_USERNAME;Password=YOUR_SERVER_PASSWORD;TrustServerCertificate=true;" ``` Now you're good to go.
* Add a Movie
* Navigate to ``https://localhost:7203/Movie/Add ``.
* Fill in the movie name and degree.
* Click "Add" to submit the form.
* List Movies
* Navigate to `` https://localhost:7203/Movie`` .
* The list of movies will be displayed.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

### Note

I get help from ChatGPT for Views, I don't know anything about designing, I'll learn, I promise
