--Junção (projeção) de 2 ou mais tabelas com GROUP BY, sem HAVING, usando uma função agregada à sua escolha:
--Objetivo: Contar o número total de tickets por marca de automóvel. Isso é alcançado usando a função COUNT com GROUP BY para agrupar os resultados por marca.

SELECT Automovel.Marca, COUNT(Ticket.ID) AS TotalTickets
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
GROUP BY Automovel.Marca;
