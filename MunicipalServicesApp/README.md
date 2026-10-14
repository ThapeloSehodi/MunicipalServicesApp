# Municipal Services Application

## 1. Project Overview

The Municipal Services Application is a C# Windows Forms application developed to allow citizens to report municipal service-related issues.

The application provides a simple interface where users can enter information about an issue, select a category and priority, provide a description, and attach a related file.

The current version focuses on the Report Issues functionality. The Local Events and Announcements and Service Request Status options are displayed on the main menu but are disabled for future implementation.

---

## 2. Technologies Used

- C#
- .NET Framework
- Windows Forms
- Visual Studio
- Object-Oriented Programming
- Generic Classes
- List Data Structure

---

## 3. Main Features

### Report Issues

Citizens can report municipal issues by providing:

- Location of the issue
- Issue category
- Priority
- Description
- Optional file attachment

After submitting an issue, the application generates a unique reference number and displays a confirmation message.

### View Submitted Issues

The application includes a View Submitted Issues feature that allows submitted issues to be displayed in a DataGridView.

Users can search submitted issues using information such as:

- Reference number
- Location
- Category
- Priority
- Status

 Local Events and Announcements

The Local Events and Announcements page extends the application by displaying upcoming community events and municipal announcements.

Example event categories include:

Environment
Community
Roads
Utilities

Each event contains information such as its title, category, location, date, description and type.

The page provides search and filtering functionality to help users find relevant events. Users can search by text, select a category and specify a date range. 

### Engagement Feature

The Report Issues form includes a progress indicator and encouraging messages to guide users while completing the report.

### User Feedback

Message boxes are used to provide feedback when:

- Required information is missing
- An issue is successfully submitted
- An action requires user attention

---

4. Data Structures and Algorithms

Part 2 introduces advanced data structures to organise and retrieve event information efficiently.

4.1 List

A List stores the collection of local events. It allows multiple event objects to be maintained and supports iteration, filtering and displaying event information.

4.2 Stack

A Stack stores recent event search terms. It follows the Last In, First Out (LIFO) principle, meaning the most recent search is retrieved first.

4.3 Queue

A Queue manages events in a first-in, first-out (FIFO) order. It can be used to process upcoming events sequentially.

4.4 Priority Queue

A priority queue organises elements according to priority rather than insertion order. In this application, it can be used to prioritise events by their dates so that earlier events are handled first.

Because the application targets .NET Framework, a compatible custom priority queue may be required instead of the built-in PriorityQueue available in newer .NET versions.

4.5 Dictionary

A Dictionary stores event information using unique event IDs as keys. It also records how often event categories are searched. This allows event details to be retrieved by ID and search preferences to be tracked by category.

4.6 SortedDictionary

A SortedDictionary organises event information using event dates as keys. This supports chronological organisation and helps the application display events in date order.

4.7 HashSet

A HashSet stores unique event categories. It prevents duplicate categories from being added to the collection and supports efficient membership checks.

4.8 Searching and Recommendation Algorithm

The application uses filtering and ordering operations to identify events matching the user's search text, selected category and chosen date range.

The recommendation algorithm uses recorded category search frequencies to prioritise events from categories that users have searched for most frequently. Upcoming events are then ordered by date and a limited number of recommendations are displayed.


Issues are currently stored in memory using a List data structure. This means that submitted issues are available while the application is running, but they are not permanently saved after the application is closed.
5. Project Structure

The project is organised into folders to separate the user interface, data models and application logic.

Forms

Contains the Windows Forms used to interact with the application.

ReportIssuesForm.cs
ManageIssuesForm.cs
LocalEventsForm.cs
Models

Contains classes representing the application's data.

Issue.cs
LocalEvent.cs
Services

Contains classes responsible for application operations and data management.

IssueService.cs
EventService.cs
Generic

Contains reusable generic collection-management functionality.

IssueManager.cs
Main Form
MainForm.cs

The Main Form provides access to the application's main features.

6. How to Compile and Run the Application
Requirements
A Windows computer
Visual Studio with support for the project's target framework
The .NET Framework version required by the project
The project source code and solution file
Steps to Compile
Open Visual Studio.
Open the MunicipalServicesApp solution.
Allow Visual Studio to load the project.
Check that the required framework is installed.
Select Build → Build Solution.
Confirm that the build completes without errors.
Steps to Run
Set MunicipalServicesApp as the startup project if necessary.
Select Debug → Start Without Debugging, or press Ctrl + F5.
The Main Menu will appear.
Select the feature you want to use.
7. How to Use the Application
7.1 Reporting a Municipal Issue
Open the application.
Select Report Issues.
Enter the issue location.
Select the category and priority.
Enter a description of the problem.
Attach a relevant file if available.
Click Submit.
Read the confirmation message and keep the generated reference number.
7.2 Viewing Submitted Issues
Open the Report Issues page.
Select View Submitted Issues.
View the available reports.
Enter a search term to find specific issues.
Use the Show All option to display the complete collection again.
7.3 Finding Local Events and Announcements
Open the Main Menu.
Select Local Events and Announcements.
Enter a search term if required.
Select a category or choose all categories.
Select the starting and ending dates.
Click Search.
Review the matching events in the event list or DataGridView.
Review the recommended events displayed on the page.
Use Clear Filters to reset the search criteria.
8. Validation and User Feedback

The application uses input validation to reduce incomplete submissions. Required issue-reporting fields are checked before an issue is saved to the collection.

The interface also uses feedback messages to notify users about missing information and successful submissions.

Search and filtering controls help users narrow down the event information displayed by the application.

9. User Interface Design

The application follows a consistent design approach across its forms.

The design focuses on:

Clear headings and labels
Consistent colours and layouts
Simple navigation
Readable event information
Search and date-filter controls
User feedback messages
An organised display of recommended events
10. Data Storage and Limitations

The current implementation stores issue and event information in application memory using collections. Sample events are loaded when the event service is created.

Unless persistent storage is added, information held only in memory will not remain available after the application is closed. Search history and category preferences are also session-based unless explicitly saved elsewhere.

The sample events are demonstration data and should not be interpreted as verified live municipal announcements.

11. Future Enhancements

Possible future improvements include:

Implementing Service Request Status
Connecting the application to a database for persistent storage
Integrating verified municipal event feeds
Saving user preferences between sessions
Adding more advanced event recommendations
Allowing authorised staff to manage event information
12. Conclusion

The Municipal Services Application provides a foundation for improving access to municipal services and local information. Part 1 introduced issue reporting, while Part 2 extends the application with event searching, date filtering, advanced data structures and personalised event recommendations.

The project demonstrates the use of C#, Windows Forms, object-oriented programming, collections and searching algorithms to address a practical municipal information-management scenario.
