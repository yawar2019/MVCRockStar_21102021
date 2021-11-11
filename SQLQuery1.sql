CREATE PROCEDURE sp_InsertEmployee
@EmpName varchar(50),
@EmpSalary int
As
BEGIN
INSERT INTO EmployeeDetails(EmpName,EmpSalary)Values(@EmpName,@EmpSalary)
END