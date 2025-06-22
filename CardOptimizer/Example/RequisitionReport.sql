SELECT "Name", "EstEndDate"
FROM public."Card"
WHERE "CardType" = 'Requisition'
ORDER BY "CardId" ASC;
