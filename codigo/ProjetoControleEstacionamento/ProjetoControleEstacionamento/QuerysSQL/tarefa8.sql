SELECT Placa, Marca
FROM Automovel A
WHERE Ano = (SELECT MAX(Ano) FROM Automovel WHERE Marca = A.Marca);
