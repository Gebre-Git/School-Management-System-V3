# School Management System

This project is a **C#** desktop application designed to simplify the management of school operations. This system enables **Admin**, **Teachers**, and **Students** to interact with the application through tailored interfaces for efficient record-keeping, attendance management, and result tracking.

## Note:

- The full project, including all dependencies and resources, is not uploaded due to its large size. Instead, this repository contains:
 - **Source Code:** The main application code. 
 - **Screenshots:** A folder with images showcasing the application's interface and functionality. [Screenshots](https://github.com/Gebre-Git/School-Management-System/blob/main/App%20Demo%20Image)
 - **Demo Video:** A video demonstrating the application in action. [Watch it on YouTube.](https://youtu.be/Yds1RuJ_J70?t=92)  

### Admin
- **Registration**: Add new students and teachers to the system.
- **Search**: Search for students and teachers by multiple criteria.
- **Attendance Management**: Track student attendance.
- **Roster Creation**: Create and manage class rosters.
- **Delete Records**: Remove student or teacher records from the system.

### Teachers
- **Set Attendance**: Log attendance for students in each class.
- **Input Results**: Record academic results for students.

### Students
- **View Results**: Students can log in to view their academic results.

## Business Logic

### Admin Role:
- The **Admin** can register students and teachers by entering necessary details into the system, which are stored in an **SQLite** database.
- The Admin can search for users using various criteria (e.g., by name or ID) and view their details.
- Admin can manage attendance by marking or updating the records for each student.
- Rosters can be created and updated, allowing the Admin to assign students to classes.
- Admin has the ability to delete student or teacher records, which also removes their associated data from the system.

### Teacher Role:
- **Teachers** can log in to their interface to mark student attendance. This updates the attendance record in the system.
- Teachers can input results for students, which are then saved in the database and made available to students for viewing.

### Student Role:
- **Students** can log in to view their results. This is a read-only interface where students can only see their academic performance.

The system's data is stored and retrieved from an **SQLite** database, ensuring smooth and efficient record management.

## Technologies Used
- **Programming Language**: C#
- **Database**: SQLite

## Screenshots
- **Login Page (Admin, Teacher, Student)**  
  ![Login Page](App%20Demo%20Image/2.%20home%20page.PNG)

- **Admin Dashboard**  
  ![Admin Dashboard](App%20Demo%20Image/6.%20Admin%20Home.PNG)

- **Teacher Login**  
   ![Admin Dashboard](App%20Demo%20Image/18.%20Techer's%20Log%20in.PNG)

- **Student Login**  
  ![Student View](App%20Demo%20Image/23.%20Student's%20Login.PNG)
  
- **Admin Registration**  
  ![Student View](App%20Demo%20Image/7.%20Registration.PNG)


### Application Demo Image (Detailed)**

  Check out the [App Demo Image folder](https://github.com/Gebre-Git/School-Management-System/blob/main/App%20Demo%20Image) for all project demo images.
  
### Demo Video

  Check out the [YouTube demo video](https://youtu.be/Yds1RuJ_J70?t=92) for a walkthrough of the application in action.

### License

  This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
  
### Acknowledgments

- Developed by **Gebremariam Birhanu (main developer)** with backend contributions on the SQL database by **Abrham Ayana**.
  The project idea and most of the development work, including the Windows Forms interface and the subsequent console version,
  were initiated and implemented by Gebremariam Birhanu.
- Inspired by the need to digitize manual record-keeping processes in schools.

### System Version:
- Version 1 (Python tkinter) : [School-Management-System-V1](https://github.com/Gebre-Git/School-Management-System-V1)
- Version 2 (Csharp Console) : [School-Management-System-V2](https://github.com/Gebre-Git/School-Management-System-V2)
- Version 3 (Advanced version of windowforms) : [School-Management-System-V3](https://github.com/Gebre-Git/School-Management-System-V3)  

