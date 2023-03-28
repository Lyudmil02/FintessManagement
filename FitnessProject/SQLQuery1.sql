SELECT * FROM Users

INSERT INTO Users(FirstName, LastName, Username, [Password], UserType)
VALUES('Lyudmil', 'Keremidchiev', 'lyudmil02', 'luskatalusi1', 'admin')


CREATE TABLE WorkoutType(
Id INT PRIMARY KEY IDENTITY,
WorkoutType NVARCHAR(50),
Exercises NVARCHAR(10),
Descripton NVARCHAR(100)
)

SELECT * FROM WorkoutType

INSERT INTO WorkoutType(WorkoutType, NumberOfExercises, Descripton)
VALUES('WorkoutType', 7, 'Descripton')

UPDATE [WorkoutType] SET [WorkoutType] = @WrT WHERE [Id] = @Id

DELETE FROM [WorkoutType] WHERE [Id] = @Id

DROP TABLE WorkoutType