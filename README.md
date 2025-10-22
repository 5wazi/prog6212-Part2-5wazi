# Contract Monthly Claim System (CMCS)
## Overview
The Contract Monthly Claim System (CMCS) is a .NET MVC web-based application designed to streamline the submission, review, and approval of monthly claims for independent contractor lecturers.The system provides role-based dashboards for **Lecturers**, **Programme Coordinators**, and **Academic Managers**, ensuring efficiency, accountability, and transparency.

## Features
**Login**
-	Email and password input
-	Login and "Continue without login" buttons
-	Role-based access control using User and UserRole tables
-	
**Lecturer Dashboard**
-	Welcome message 
-	Quick access to:
  - Submit New Claim
  - Upload Documents
  - Download Claim Form
  - Help & Support
-	Claim Summary (Total, Pending, Approved, Rejected)
-	Recent Activity (latest claims with status badges)

**Lecturer Claim Page**
-	Filters section (Month selector, Status dropdown, Apply/Reset buttons)
-	Claims Table (Claim ID, Date, Hours Worked, Hourly Rate, Total, Status)

**Lecturer Submit Claim Page**
-	Claim Submission Form
  - Full Name, Module/Claim Title, Hours Worked, Hourly Rate, Total (auto-calculated)
  - Description / Notes
  - Submission Date (auto-filled)
-	File Upload Component
  - Supports multiple files
  - Accepted formats: .pdf, .docx, .xlsx
  - Max file size: 20MB
  - Client-side and server-side validation
  - Displays errors if files exceed size or unsupported type
-	Reset and Submit buttons

**Programme Coordinator Dashboard**
-	Welcome message 
-	Quick access to:
  - Review Pending Claims
  - Manage Lectures
  - Generate Reports
  - Help & Support
-	Claim Summary (Total, Pending, Approved, Rejected)

**Program Coordinator Claim Verification Page**
-	Claims table
-	Filters section (lecturer, claim status, apply/reset button)
-	Approve/Reject and claim detail buttons

**Programme Coordinator Review Claim Page**
-	Claim details and uploaded documents display
-	Feedback text area
-	Approve/Reject and "Back to claims" button

**Academic Manager Dashboard**
-	Welcome message 
-	Quick access to:
  - Finalise Pending Claims
  - Generate Reports
  - Audit Trail
  - Help & Support

**Academic Manager Claim Page**
-	Claims table
-	Filters section (Lecturer/Claim ID, Month, Apply/Reset buttons)
-	Approve/Reject and claim detail buttons

**Academic Review Claim Page**
-	Displays coordinator verification status
-	Claim details and uploaded documents display
-	Feedback text area
-	Approve/Reject and "Back to pending claims" button

**Common Features**
-	Navbar with navigation (Dashboard, Claims, Documents, My Profile)
-	User dropdown for switching roles (Lecturer, Coordinator, Manager)
-	Logout functionality
-	Responsive design with Bootstrap 5
-	Dashboard shows real-time claim status tracking:
  - Submitted → Verified → Approved / Rejected
-	Role-based access control ensures each user can only perform actions allowed for their role

**Tech Stack**
-	Frontend: HTML5, CSS3, Bootstrap 5, JavaScript (for auto-calculating totals and client-side validation)
-	Backend: ASP.NET Core MVC
  - Form submission handling
  - Claim workflow logic (submission → verification → approval)
  - File upload processing with validation
-	Database: Relational database supporting role-based access and claim tracking
  -	User Table: Stores all users (Lecturers, Coordinators, Managers)
  - UserRole Table: Assigns roles to users for role-based access
  - Claim Table: Stores claim details, hours, rates, status
  - Document Table: Stores file metadata and links to claims
  - Review Table: Tracks verification and approval with timestamps and feedback
-	Version Control: Git

**Installation**
1.	Clone the repository:
2.	git clone https://github.com/IIEVCPMB/prog6212-poe-part-1-5wazi.git
3.	Open the project in Visual Studio
4.	Restore NuGet packages
5.	Run the application using IIS Express or Kestrel

**Usage**
-	Lecturers:
  - Submit claims, upload supporting documents
  - Track claim status in real-time
-	Programme Coordinators:
  - Verify claims, leave feedback
  - Approve or reject claims
-	Academic Managers:
  - Review verified claims from coordinators
  - Approve or reject final claims
  - Maintain audit trail for accountability

