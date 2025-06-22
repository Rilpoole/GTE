SELECT
    c."Name",
    e."Name" AS "EmployeeName",
    c."EstStartDate"
FROM public."Card" c
LEFT JOIN public."Employee" e ON c."Employee" = e."EmployeeId"
LEFT JOIN public."Item" i ON c."Item" = i."ItemId"
WHERE c."CardType" = 'Production'
ORDER BY c."CardId" ASC;
