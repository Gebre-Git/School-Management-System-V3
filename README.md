**School Management System**

A C# desktop application designed to simplify the management of school operations. This system enables Admin, Teachers, and Students to interact with the application through tailored interfaces for efficient record-keeping, attendance management, and result tracking.


***Features***

*Admin*
Registration: Add new students and teachers to the system.
Search: Search for students and teachers by multiple criteria.
Attendance Management: Track student attendance.
Roster Creation: Create and manage class rosters.
Delete Records: Remove student or teacher records from the system.

*Teachers*
Set Attendance: Log attendance for students in each class.
Input Results: Record academic results for students.

*Students*
View Results: Students can log in to view their academic results.


**Business Logic**

*Admin Role:*
The Admin can register students and teachers by entering necessary details into the system, which are stored in an SQLite database.
The Admin can search for users using various criteria (e.g., by name or ID) and view their details.
Admin can manage attendance by marking or updating the records for each student.
Rosters can be created and updated, allowing the Admin to assign students to classes.
Admin has the ability to delete student or teacher records, which also removes their associated data from the system.

*Teacher Role:*
Teachers can log in to their interface to mark student attendance. This updates the attendance record in the system.
Teachers can input results for students, which are then saved in the database and made available to students for viewing.

*Student Role:*
Students can log in to view their results. This is a read-only interface where students can only see their academic performance.
The system's data is stored and retrieved from an SQLite database, ensuring smooth and efficient record management.


**Technologies Used**

Programming Language: C#
Database: SQLite


**Screenshots**

Login Page (Admin, Teacher, Student)
Admin Dashboard
Teacher Dashboard
Student View


**Demo Video**

Check out the Youtube demo video for a walkthrough of the application in action.

**License**

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.



School Management System
A C# desktop application designed to simplify the management of school operations. This system enables Admin, Teachers, and Students to interact with the application through tailored interfaces for efficient record-keeping, attendance management, and result tracking.

Features
Admin
Registration: Add new students and teachers to the system.
Search: Search for students and teachers by multiple criteria.
Attendance Management: Track student attendance.
Roster Creation: Create and manage class rosters.
Delete Records: Remove student or teacher records from the system.
Teachers
Set Attendance: Log attendance for students in each class.
Input Results: Record academic results for students.
Students
View Results: Students can log in to view their academic results.
Business Logic
Admin Role:
The Admin can register students and teachers by entering necessary details into the system, which are stored in an SQLite database.
The Admin can search for users using various criteria (e.g., by name or ID) and view their details.
Admin can manage attendance by marking or updating the records for each student.
Rosters can be created and updated, allowing the Admin to assign students to classes.
Admin has the ability to delete student or teacher records, which also removes their associated data from the system.
Teacher Role:
Teachers can log in to their interface to mark student attendance. This updates the attendance record in the system.
Teachers can input results for students, which are then saved in the database and made available to students for viewing.
Student Role:
Students can log in to view their results. This is a read-only interface where students can only see their academic performance.
The system's data is stored and retrieved from an SQLite database, ensuring smooth and efficient record management.

Technologies Used
Programming Language: C#
Database: SQLite
Screenshots
Login Page (Admin, Teacher, Student)

Admin Dashboard

Teacher Dashboard

Student View

Demo Video
Check out the YouTube demo video for a walkthrough of the application in action.

License
This project is licensed under the MIT License - see the LICENSE file for details.
