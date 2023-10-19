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

-- Inserir dados fictícios na tabela Automovel
INSERT INTO Automovel (Placa, Marca, Ano, Cor, PrecoHora)
VALUES
    ('AAA111', 'Toyota', 2022, 'Azul', 10.00),
    ('BBB222', 'Honda', 2021, 'Prata', 11.50),
    ('CCC333', 'Ford', 2023, 'Vermelho', 12.75),
    ('DDD444', 'Chevrolet', 2022, 'Preto', 10.25),
    ('EEE555', 'Nissan', 2021, 'Verde', 11.75);

-- Inserir dados fictícios na tabela Ticket
INSERT INTO Ticket (AutomovelCobrado, ValorTotal, HoraEntrada, HoraSaida)
VALUES
    ('AAA111', 15.00, '2023-10-19 08:00:00', '2023-10-19 12:30:00'),
    ('BBB222', 30.25, '2023-10-19 09:30:00', '2023-10-19 13:45:00'),
    ('CCC333', 18.00, '2023-10-19 10:15:00', '2023-10-19 14:00:00'),
    ('DDD444', 22.50, '2023-10-19 11:45:00', '2023-10-19 15:30:00'),
    ('EEE555', 40.00, '2023-10-19 08:30:00', '2023-10-19 13:00:00');

-- Inserir dados fictícios na tabela Estacionamento
INSERT INTO Estacionamento (Vagas, NumAutomoveis)
VALUES
    (100, 5);

INSERT INTO Estacionamento (Vagas, NumAutomoveis)
VALUES
    (100, 3);
