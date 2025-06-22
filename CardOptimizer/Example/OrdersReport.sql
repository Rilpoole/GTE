SELECT "Name","DueDate","Priority","EstEndDate" FROM public."Card"
where "CardType" = 'Order'
ORDER BY "EstStartDate" ASC 