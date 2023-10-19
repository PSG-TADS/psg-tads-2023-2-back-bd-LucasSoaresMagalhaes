SELECT Automovel.Marca, COUNT(Ticket.ID) AS TotalTickets
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
GROUP BY Automovel.Marca;
