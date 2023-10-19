--Subselect com EXISTS:
--Objetivo: Identificar os automóveis que têm pelo menos um ticket associado a eles. Isso é feito usando EXISTS com um subselect que verifica se existe pelo menos um registro na tabela Ticket para o automóvel.

SELECT Placa, Marca
FROM Automovel A
WHERE EXISTS (SELECT 1 FROM Ticket WHERE AutomovelCobrado = A.Placa);
