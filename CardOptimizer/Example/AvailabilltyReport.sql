SELECT
	C."Name",
	E."Name" AS "EmployeeName",
	C."EstStartDate"
FROM
	PUBLIC."Card" C
	LEFT JOIN PUBLIC."Employee" E ON C."Employee" = E."EmployeeId"
	LEFT JOIN PUBLIC."Item" I ON C."Item" = I."ItemId"
WHERE
	C."CardType" = 'Production'
ORDER BY
	C."EstStartDate" ASC;
