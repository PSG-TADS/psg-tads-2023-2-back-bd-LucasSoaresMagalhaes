SELECT Placa, Marca
FROM Automovel
WHERE Ano = (SELECT MAX(Ano) FROM Automovel);
