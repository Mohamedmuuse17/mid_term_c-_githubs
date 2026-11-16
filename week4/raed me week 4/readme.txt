

### Project Title: Patient Information Management System

### 1. Introduction
This project is a C# Windows Forms application developed as part of Week 4, Chapter 4. The main purpose of this application is to manage patient information using file handling techniques in C#.

The application allows users to enter patient details, save information into a text file, read saved information, delete selected records, and count the total patient records.

### 2. Project Objectives
The main objectives of this project are:

- To understand file handling in C#.
- To use StreamWriter to write data into files.
- To use StreamReader to read data from files.
- To use SaveFileDialog to save patient information.
- To use OpenFileDialog to open and read files.
- To delete selected information from a file.
- To count the total patient records.

### 3. Main Features

**1. Add Patient Information**

Users can enter:
- Patient ID
- Patient Name
- Patient Age
- Patient Gender

**2. Save Patient Information**

The application uses StreamWriter and File.AppendText() to save patient information into a text file.

**3. Read Patient Information**

The application uses StreamReader and File.OpenText() to read information from a selected file and display it in a ListBox.

**4. Delete Patient Information**

Users can select an item from the ListBox and delete the selected record from the text file.

**5. Count Patient Records**

The application counts and displays the total number of patient records.

**6. Clear Information**

The Clear button removes all entered information from the textboxes, radio buttons, and ListBox.

**7. Exit Application**

The Exit button closes the application.

### 4. C# Concepts Used

The following C# concepts were applied in this project:

- Variables and Data Types
- If and Else Statements
- Loops (While and Foreach)
- Windows Forms Controls
- StreamWriter
- StreamReader
- File.AppendText()
- File.ReadAllLines()
- File.WriteAllLines()
- SaveFileDialog
- OpenFileDialog
- MessageBox

### 5. Validation
The application includes basic validation to ensure that:

- Patient ID is not negative.
- Patient age is a positive number.
- Patient name is not empty.
- Patient gender must be selected.

### 6. Technologies Used

- Programming Language: C#
- Framework: .NET Windows Forms
- Development Environment: Visual Studio
- File Type: Text File (.txt)

