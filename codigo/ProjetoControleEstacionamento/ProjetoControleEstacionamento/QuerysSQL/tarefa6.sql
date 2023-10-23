--Junção (projeção) de 2 ou mais tabelas com GROUP BY e HAVING:
--Objetivo: Semelhante à consulta anterior, mas com a adição de uma cláusula HAVING. Neste caso, estamos filtrando as marcas que têm mais de 5 tickets.

SELECT Automovel.Marca, COUNT(Ticket.ID) AS TotalTickets
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
GROUP BY Automovel.Marca
HAVING COUNT(Ticket.ID) > 5;
