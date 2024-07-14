# C# Backend Project with CRUD Operations

This project is a C# backend application that performs CRUD operations on a SQLite database containing a list of games with information such as genre, price, and release date.

## Tech Stack Used

- C#
- SQLite

## Functionality

The application provides the following CRUD operations for managing games in the database:

- Add a new game with genre, price, and release date
- Edit an existing game's information
- Delete a game from the database
- Get a list of all games in the database

## Setup

1. Clone the repository
2. Open the solution in Visual Studio
3. Build and run the application

## Usage

- Use appropriate API endpoints to perform CRUD operations on the games in the database

## API Endpoints

- POST /api/games - Add a new game
- PUT /api/games/{id} - Edit an existing game
- DELETE /api/games/{id} - Delete a game
- GET /api/games - Get a list of all games
