-- Crie um novo banco de dados
CREATE DATABASE EstacionamentoDBSQL;

-- Use o banco
USE EstacionamentoDBSQL;

-- Crie a tabela Automóvel
CREATE TABLE Automovel (
    Placa VARCHAR(10) PRIMARY KEY,
    Marca VARCHAR(50),
    Ano INT,
    Cor VARCHAR(20),
    PrecoHora DECIMAL(10, 2)
);

INSERT INTO Automovel (Placa, Marca, Ano, Cor, PrecoHora)
VALUES
    ('ABC1234', 'Toyota', 2020, 'Prata', 12.50),
    ('XYZ5678', 'Honda', 2019, 'Azul', 11.75),
    ('DEF4321', 'Ford', 2018, 'Preto', 10.00);

-- Crie a tabela Ticket
CREATE TABLE Ticket (
    ID INT IDENTITY(1,1) PRIMARY KEY, -- Para SQL Server use IDENTITY
    AutomovelCobrado VARCHAR(10),
    ValorTotal DECIMAL(10, 2),
    HoraEntrada DATETIME,
    HoraSaida DATETIME
);

INSERT INTO Ticket (AutomovelCobrado, ValorTotal, HoraEntrada, HoraSaida)
VALUES
    ('ABC1234', 25.00, '2023-10-19 08:00:00', '2023-10-19 12:30:00'),
    ('XYZ5678', 15.75, '2023-10-19 09:30:00', '2023-10-19 13:45:00'),
    ('DEF4321', 20.00, '2023-10-19 10:15:00', '2023-10-19 14:00:00');

-- Crie a tabela Estacionamento
CREATE TABLE Estacionamento (
    Vagas INT,
    NumAutomoveis INT
);

INSERT INTO Estacionamento (Vagas, NumAutomoveis)
VALUES
    (100, 3);
