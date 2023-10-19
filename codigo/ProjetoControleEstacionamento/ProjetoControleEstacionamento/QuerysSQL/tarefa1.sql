SELECT Ticket.*, Automovel.Marca, Automovel.Cor, Estacionamento.Vagas
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
INNER JOIN Estacionamento ON Estacionamento.NumAutomoveis = Ticket.ID;
