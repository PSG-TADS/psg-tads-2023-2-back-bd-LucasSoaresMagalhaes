SELECT Ticket.*, Automovel.Marca, Automovel.Cor, Estacionamento.Vagas
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
LEFT JOIN Estacionamento ON Estacionamento.NumAutomoveis = Ticket.ID
WHERE Estacionamento.NumAutomoveis IS NULL;
