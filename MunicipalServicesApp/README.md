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

### Engagement Feature

The Report Issues form includes a progress indicator and encouraging messages to guide users while completing the report.

### User Feedback

Message boxes are used to provide feedback when:

- Required information is missing
- An issue is successfully submitted
- An action requires user attention

---

## 4. Data Structure

The application uses a List data structure to store reported issues.

A generic class called `IssueManager<T>` is used to manage the collection of issues. When the application uses `IssueManager<Issue>`, the generic type `T` represents the `Issue` class.

The list allows multiple issues to be stored dynamically as citizens submit reports.

The data structure supports operations such as:

- Adding issues
- Retrieving issues
- Counting issues
- Removing issues
- Clearing issues

Each issue is represented by an `Issue` object containing information such as the reference number, location, category, description, priority, attachment path, status and submission date.

---

## 5. Project Structure

The application is organised into several folders:

### Forms

Contains the Windows Forms used by the application.

- `ReportIssuesForm.cs`
- `ManageIssuesForm.cs`

### Models

Contains the data model used to represent an issue.

- `Issue.cs`

### Services

Contains the service responsible for managing issue-related operations.

- `IssueService.cs`

### Generic

Contains the generic class used to manage the collection of issues.

- `IssueManager.cs`

### Main Form

- `MainForm.cs`

The Main Form provides access to the different municipal service functions.

---

## 6. How to Compile and Run

### Requirements

The following software is required:

- Windows operating system
- Visual Studio
- .NET Framework compatible with the project

### Steps

1. Open Visual Studio.
2. Open the Municipal Services Application solution.
3. Allow Visual Studio to load the project and restore any required components.
4. Build the solution by selecting:

   `Build → Build Solution`

5. If the build completes successfully, run the application by selecting:

   `Debug → Start Without Debugging`

   or press:

   `Ctrl + F5`

---

## 7. How to Use the Application

### Step 1: Open the Application

When the application starts, the Main Menu is displayed.

The menu contains:

- Report Issues
- Local Events and Announcements
- Service Request Status

The Report Issues option is currently enabled, while the other two options are disabled because they are planned for future implementation.

### Step 2: Report an Issue

Select **Report Issues**.

Enter the required information:

1. Enter the location.
2. Select an issue category.
3. Select the priority.
4. Enter a description.
5. Optionally attach a file.
6. Click **Submit**.

### Step 3: Confirmation

After a successful submission, the application displays a confirmation message containing the generated issue reference number.

### Step 4: View Submitted Issues

Select **View Submitted Issues** to display the issues that have been submitted during the current application session.

The search function can be used to find specific issues.

---

## 8. Validation

The application validates important fields before an issue can be submitted.

The following information is required:

- Location
- Category
- Priority
- Description

If required information is missing, the application displays a warning message and asks the user to complete the missing information.

---

## 9. User Interface Design

The application follows a consistent user interface design.

The design focuses on:

- Clear labels
- Easy-to-understand buttons
- Consistent colours and layouts
- User feedback messages
- Simple navigation
- A progress indicator to encourage users to complete their reports

---

## 10. Current Scope

The current implementation focuses on the Report Issues functionality required for the first stage of the Municipal Services Application.

The following features are currently implemented:

- Main Menu
- Report Issues
- Issue validation
- Issue categories
- Issue priorities
- File attachments
- Issue submission
- Reference number generation
- Issue storage using a List
- Issue searching
- Viewing submitted issues
- Progress and engagement feedback

The following features are reserved for future implementation:

- Local Events and Announcements
- Service Request Status

---

## 11. Important Note

Issues are currently stored in memory using a List data structure. This means that submitted issues are available while the application is running, but they are not permanently saved after the application is closed.
