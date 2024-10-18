CREATE DATABASE QlTuyenSinh 
USE QlTuyenSinh
GO
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100),
	AnhDaiDien NVARCHAR(50),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    Role NVARCHAR(10) CHECK (Role IN ('admin', 'student')) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);
CREATE TABLE Profiles (
    ProfileID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    FullName NVARCHAR(100),
    DOB DATE,
	AnhDaiDien NVARCHAR(50),
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female')),
    Address NVARCHAR(255),
    HighSchool NVARCHAR(255),
    GPA DECIMAL(3, 2),
    Status NVARCHAR(20) CHECK (Status IN ('Pending', 'Paid', 'Reviewed')) DEFAULT 'Pending',
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);
CREATE TABLE Universities (
    UniversityID INT PRIMARY KEY IDENTITY(1,1),
    UniversityName NVARCHAR(255) NOT NULL,
    Location NVARCHAR(255),
    ContactInfo NVARCHAR(255),
	AnhTruong NVARCHAR(50),
    Website NVARCHAR(255)
);
CREATE TABLE Majors (
    MajorID INT PRIMARY KEY IDENTITY(1,1),
    MajorName NVARCHAR(255) NOT NULL,
    UniversityID INT NOT NULL,
    FOREIGN KEY (UniversityID) REFERENCES Universities(UniversityID) ON DELETE CASCADE
);
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    ProfileID INT NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(),
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentStatus NVARCHAR(20) CHECK (PaymentStatus IN ('Pending', 'Completed')) NOT NULL,
    FOREIGN KEY (ProfileID) REFERENCES Profiles(ProfileID) ON DELETE CASCADE
);
CREATE TABLE Exams (
    ExamID INT PRIMARY KEY IDENTITY(1,1),
    ExamName NVARCHAR(255) NOT NULL,
    ExamDate DATE,
    ExamLocation NVARCHAR(255),
    ContactInfo NVARCHAR(255)
);
CREATE TABLE ContactInfo (
    ContactID INT PRIMARY KEY IDENTITY(1,1),
    SupportType NVARCHAR(50) CHECK (SupportType IN ('General', 'Payment', 'Exam', 'University')) NOT NULL,
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100)
);
