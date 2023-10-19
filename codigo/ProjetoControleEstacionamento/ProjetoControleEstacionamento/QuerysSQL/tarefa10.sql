--Criação de uma visão, com base em uma das consultas anteriores:
--Objetivo: Criar uma visão chamada "TotalTicketsPorMarca" que fornece o total de tickets por marca de automóvel, com base na consulta número 5. Isso permite que os usuários acessem facilmente essa informação sem escrever a consulta repetidamente.

CREATE VIEW TotalTicketsPorMarca AS
SELECT Automovel.Marca, COUNT(Ticket.ID) AS TotalTickets
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
GROUP BY Automovel.Marca;
