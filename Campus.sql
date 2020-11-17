CREATE DATABASE Campus
GO

USE Campus
CREATE TABLE Promotion (
	PromotionId INT PRIMARY KEY IDENTITY(1, 1),
	PromotionFramework VARCHAR(100) NOT NULL,);
GO

CREATE TABLE Student (
    StudentId INT PRIMARY KEY IDENTITY(1, 1),
	StudentLastName VARCHAR(100) NOT NULL,
    StudentFirstName VARCHAR(100) NOT NULL,
    FK_PromotionId INT FOREIGN KEY REFERENCES Promotion(PromotionId) NOT NULL);
GO

CREATE TABLE Exam (
    ExamId INT PRIMARY KEY IDENTITY(1, 1),
	ExamNote DECIMAL NOT NULL,
    FK_StudentId INT FOREIGN KEY REFERENCES Student(StudentId) NOT NULL);
GO

INSERT  INTO Promotion (PromotionFramework)
VALUES ('JavaScript'), ('CSharp');
GO

INSERT INTO Student (StudentLastName, StudentFirstName, FK_PromotionId)
VALUES
('BOND', 'James', 1),
('BALBOA', 'Rocky', 1),
('INGALLS', 'Laura', 1),
('CONNOR', 'Sarah', 1), 
('PAN', 'Peter', 1),
('KENT', 'Clark', 2),
('PARKER', 'Peter', 2),
('WIDOW', 'Black', 2),
('CROFT', 'Lara', 2),
('HOLMES', 'Sherlock', 2);
GO

INSERT INTO Exam (ExamNote, FK_StudentId)
VALUES
(12, 1),
(15, 1),
(7, 2),
(12, 2),
(19, 3),
(20, 3),
(2, 4),
(6, 4),
(13, 5),
(14, 5),
(18, 6),
(16, 6),
(14, 7),
(16, 7),
(12, 8),
(11, 8),
(3, 9),
(5, 9),
(7, 10),
(8, 10);
GO

