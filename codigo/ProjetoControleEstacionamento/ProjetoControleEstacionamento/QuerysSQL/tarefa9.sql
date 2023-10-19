SELECT Placa, Marca
FROM Automovel A
WHERE EXISTS (SELECT 1 FROM Ticket WHERE AutomovelCobrado = A.Placa);
