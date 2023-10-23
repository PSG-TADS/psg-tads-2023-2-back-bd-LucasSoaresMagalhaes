--Subselect com correlação:
--Objetivo: Obter automóveis com o ano mais recente, mas com a adição de correlação para garantir que a marca do automóvel seja a mesma que a marca no subselect.

SELECT Placa, Marca
FROM Automovel A
WHERE Ano = (SELECT MAX(Ano) FROM Automovel WHERE Marca = A.Marca);
