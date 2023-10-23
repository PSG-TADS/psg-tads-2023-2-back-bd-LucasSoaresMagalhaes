--Junção (projeção) de 3 ou mais tabelas, com ORDER BY e filtros na cláusula WHERE:
--Objetivo: Recuperar dados de tickets de estacionamento com detalhes de automóveis e informações de estacionamento. Os resultados são filtrados para mostrar apenas os registros com um valor total superior a 20, e são classificados por hora de saída em ordem decrescente.

SELECT Ticket.*, Automovel.Marca, Automovel.Cor, Estacionamento.Vagas
FROM Ticket
INNER JOIN Automovel ON Ticket.AutomovelCobrado = Automovel.Placa
INNER JOIN Estacionamento ON Estacionamento.NumAutomoveis = Ticket.ID
WHERE Ticket.ValorTotal > 20
ORDER BY Ticket.HoraSaida DESC;
