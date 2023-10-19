--Junção (projeção) de 3 ou mais tabelas:
--Objetivo: Obter informações de tickets de estacionamento juntamente com detalhes dos automóveis e informações sobre o estacionamento.

SELECT Ticket.*, Automovel.Marca, Automovel.Cor, Estacionamento.Vagas
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
INNER JOIN Estacionamento ON Estacionamento.NumAutomoveis = Ticket.ID;
