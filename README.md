
# Windows Application Slidely AI task


## Features

 * Create new submissions

 * View and navigate through existing submissions

 * Search submissions by email or index

 * Responsive UI with keyboard shortcuts

## Installation

 * .NET Framework 4.7.2 or higher

 * Visual Studio (for development)

 * Backend server running with the required endpoints












## Steps

To get a local copy of the project up and running, follow these steps:


1. Clone the Repository:

```bash
  git clone https://github.com/PRITISH-TOMAR/Task_Slidely_Application
```
2. Open the solution file in Visual Studio.
3. Build the project to restore dependencies.

4. Run the application.


![App Screenshot](https://i.ibb.co/3YT6rY2/Screenshot-2024-06-21-193104.png)


## Submit Details

1. Create Submission
2. Click on the "Create Submission" button.
3. Fill in the required fields: Name, Email, Phone, GitHub Link, and Stopwatch Time.
4. Click on the "Submit" button to save the submission.


![App Screenshot](https://i.ibb.co/SmTtz6V/Screenshot-2024-06-21-193346.png)


## View Submissions

1. Click on the "View Submissions" button.
2. Use the "Next" and "Previous" buttons to navigate through the submissions.
3. You can also search for submissions by entering an email or index in the search box and pressing "Enter".1.


![App Screenshot](https://i.ibb.co/CwfS9p3/Screenshot-2024-06-21-193202.png)


![App Screenshot](https://i.ibb.co/sV5cz8Q/Screenshot-2024-06-21-195207.png)##Keyboard Shortcuts
* Ctrl + V: View Submissions
* Ctrl + N: Create New Submission
* Ctrl + P: Previous Submission
* Ctrl + N: Next Submission
* Ctrl + N: Save a Submission
* Enter: Search Submission




#### Server runs on localhost 
* You can deploy it from the given repository:
* [https://github.com/PRITISH-TOMAR/Task_Slidely_Backend](https://github.com/PRITISH-TOMAR/Task_Slidely_Backend).

## Server Endpoints
The application interacts with the following server endpoints:

* Ping Server: http://localhost:3000/ping
* Submit Data: http://localhost:3000/submit
* Read Data by Index: [http://localhost:3000/read?index=10](http://localhost:3000/read?index=10)
* Read Data by Email: [http://localhost:3000/read?email=pzalpha1@gmail.com](http://localhost:3000/read?email=pzalpha1@gmail.com)


# Purpose
* The project is designed for development and testing purposes only. It aims to provide a functional demonstration of a Windows application that interacts with a backend server. 

* This project showcases the following capabilities: 

  Creating, reading, and managing submission data via a user-friendly graphical interface.

 

