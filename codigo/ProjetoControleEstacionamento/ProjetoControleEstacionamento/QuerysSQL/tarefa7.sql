--Subselect sem correlação:
--Objetivo: Selecionar os automóveis com o ano mais recente. Isso é feito através de um subselect que busca o ano máximo na tabela Automovel.

SELECT Placa, Marca
FROM Automovel
WHERE Ano = (SELECT MAX(Ano) FROM Automovel);
