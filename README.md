# Contract Monthly Claim System (CMCS)

## Overview
The Contract Monthly Claim System (CMCS) is a .NET MVC web-based application designed to streamline the submission, review, and approval of monthly claims for independent contractor lecturers. 
The system provides role-based dashboards for **Lecturers**, **Programme Coordinators**, and **Academic Managers**, ensuring efficiency, accountability, and transparency.

## Features
- **Login**
  - Email and password input
  - Login and "Continue without login" buttons
  
- **Lecturer Dashboard**
  - Welcome message with user’s name
  - Quick access to:
    - Submit New Claim
    - Upload Documents
    - Download Claim Form
    - Help & Support
  - Claim Summary (Total, Pending, Approved, Rejected)
  - Recent Activity (latest claims with status badges)

  - **Lecture Claim Page**
  - Filters section (Month selector, Status dropdown, Apply/Reset buttons)
  - Claims Table (Claim ID, Date, Hours Worked, Hourly Rate, Total, Status)

- **Lecturer Submit Claim Page**
  - Claim submission form 
  - File upload component
  - Reset and submit buttons

- **Programme Coordinator Dashboard**
  - Welcome message with user's name
  - Quick access to:
    - Review Pending Claims
    - Manage Lectures
    - Generate Reports
    - Help & Support
  - Claim Summary (Total, Pending, Approved, Rejected)

  - **Program Coordinator Claim Verification Page**
  - Claims table
  - Filters section (lecturer, claim status, apply/reset button)
  - Approve/Reject and claim detail buttons

- **Programme Coordinator Review Claim Page**
  - Claim details and documents uploaded display
  - Feedback text area
  - Approve/Reject and "back to claims" button


- **Academic Manager Dashboards**
  - Welcome message with user's name
  - Quick access to:
    - Finalise Pending Claims
    - Generate Reports
    - Audit Trail
    - Help & Support

- **Academic Manager Claim Page**
  - Claims table
  - Filters section (Lecturer/Claim ID, Month, Apply/Reset buttons)
  - Approve/Reject and claim detail buttons

- **Academic Review Claim Page**
  - Same as coordinator review page, plus coordinator status
  - Feedback text area
  - Approve/Reject and "back to pending claims" buttons

- **Common Features**
  - Navbar with navigation (Dashboard, Claims, Documents, My Profile)
  - User dropdown for switching roles (Lecturer, Coordinator, Manager)
  - Logout functionality
  - Responsive Bootstrap design for desktop and mobile devices

## Tech Stack
- **Frontend:** HTML5, CSS3, Bootstrap 5
- **Backend:** ASP.NET Core MVC
- **Database:**
  - User (Lecturers, Coordinators, Managers)
  - Claim (hours, rates, status)
  - Documents (supporting files linked to claims)
  - Review (Review Date, Review Status, Comment)
- **Version Control:** Git

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/IIEVCPMB/prog6212-poe-part-1-5wazi.git
   ```
2. Open the project in **Visual Studio**.
3. Restore NuGet packages.
4. Run the application using IIS Express or Kestrel.

## Usage
- **Lecturers:** Submit and track claims, upload supporting documents.
- **Coordinators/Managers:** Review, approve, or reject claims.


