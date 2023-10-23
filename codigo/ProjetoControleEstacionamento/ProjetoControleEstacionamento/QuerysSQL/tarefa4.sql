--Junção (projeção) de 3 ou mais tabelas, usando os operadores IN/NOT IN e/ou IS NULL/IS NOT NULL:
--Objetivo: Recuperar dados de tickets de estacionamento com detalhes de automóveis e informações de estacionamento. Neste caso, estamos procurando registros onde não há informações de estacionamento associadas aos tickets.

SELECT Ticket.*, Automovel.Marca, Automovel.Cor, Estacionamento.Vagas
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
LEFT JOIN Estacionamento ON Estacionamento.NumAutomoveis = Ticket.ID
WHERE Estacionamento.NumAutomoveis IS NULL;
