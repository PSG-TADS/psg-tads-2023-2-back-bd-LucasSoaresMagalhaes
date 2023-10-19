--Junção (projeção) de 3 ou mais tabelas, usando os operadores LIKE e/ou BETWEEN:
--Objetivo: Selecionar dados de tickets de estacionamento com detalhes de automóveis e informações de estacionamento, onde a hora de entrada está entre dois horários específicos.

SELECT Ticket.*, Automovel.Marca, Automovel.Cor, Estacionamento.Vagas
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
INNER JOIN Estacionamento ON Estacionamento.NumAutomoveis = Ticket.ID
WHERE Ticket.HoraEntrada BETWEEN '2023-10-19 08:00:00' AND '2023-10-19 12:00:00';
