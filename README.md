# Library Management System in C#

This is a Library Management System implemented in C# as a project for a database course. The system comprises two main modules, the Librarian Module and the User Module, facilitating efficient book management and user interactions within a library environment.

## Project Overview

The system operates through the following key entities:

1. Books: Contains information about the books available in the library.
2. Librarian: Manages book-related operations and system administration.
3. Users: Interact with the system to access, search, and order books from the library.

## Features

### Librarian Module

- Log in to the system using the designated admin ID.
- Update book information including details such as title, author, and availability.
- Add new books to the library database.
- Delete books from the library database.

### User Module

- Register as a new user with a unique Roll Number.
- Log in to the system as a registered user.
- View the entire collection of books available in the library.
- Search for a specific book using relevant keywords.
- Place an order for a book.
- Check the availability of books within the library.
- Return books after borrowing.

## Database Structure

The system's functionality heavily relies on a database structure that includes the following tables:

1. Books: Stores information about all the books available in the library.
2. Orders: Tracks the orders placed by users and their corresponding statuses.

## Usage

To utilize the Library Management System:

1. Clone the repository to your local machine using the following command:
   ```
   git clone git@github.com:iem-wahab/Library-Management-System.git
   ```
2. Open the project solution file in your C# IDE.
3. Build the project and resolve any dependencies if required.
4. Run the application and follow the on-screen instructions to navigate through the system and utilize its various features.

## Contribution

Contributions are always welcome! If you have any ideas for improvements or find any issues, please feel free to open an issue or create a pull request.
