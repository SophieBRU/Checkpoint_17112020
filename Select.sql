SELECT 
	CONCAT (StudentLastName, ' ', StudentFirstName) AS 'NOM Prénom',
	AVG(ExamNote) AS 'Moyenne'
FROM Exam
INNER JOIN Student ON  StudentId = FK_StudentId
GROUP BY StudentId, StudentLastName, StudentFirstName;