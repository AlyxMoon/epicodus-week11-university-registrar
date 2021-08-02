# Epocodus Weekly Project | University Registrar Website

## Description

Create an app for a University registrar to keep track of students and courses. Here are some user stories for you - build one at a time before moving on to the next one.

- As a registrar, I want to enter a student, so I can keep track of all students enrolled at this University. I should be able to provide a name and date of enrollment.
- As a registrar, I want to enter a course, so I can keep track of all of the courses the University offers. I should be able to provide a course name and a course number (ex. HIST100).
- As a registrar, I want to be able to assign students to a course, so that teachers know which students are in their course. A course can have many students and a student can take many courses at the same time.

If you make it this far, great job! If you have time, work on these other user stories.

- As a registrar, I want to be able to create departments. A student can be assigned to a department when they declare their major and a course can be assigned to a department when it is created.
- As a registrar, I want to be able to list out all of the courses or all of the students in a particular department, so that I can inform the counselors which departments need more students and which need more courses.
- As a registrar, I want to change a student's file to show that they have completed a course, so that I can see if they need to take the course again.
- As a registrar, I want to list out all of the courses a student has taken, so that I can see if they have met their degree requirements.
- As a registrar, I want to see how many students have not completed courses in any particular departments, so that I can tell the administration which departments need help.
- As a registrar, I want to …

If you make it this far before the end of the day, think up and write some other user stories that a University registrar might have.

## Setting Up The Project
You are expected to have the following installed on your computer:

- A working bash terminal
- An instance of MySQL 8 or Docker
- .Net 5.0 or greater (https://dotnet.microsoft.com/download)

Before you can begin either set of setup instructions, you must do the following:
1. Download the files or clone the repository to your computer.

### Setting Up The Database
This assumes either an instance of MySQL 8 is installed, or you have Docker available on your computer

#### Using Docker
If you have Docker, then the set up will be quick and easy!

1. Ensure the Docker daemon is currently running on your computer
2. Close any instances of MySQL running
  - Or, change the ports used when running docker for this project. However, you'll be responsible for updating the DB configuration in that case.
3. Open a terminal instance in the root of this project