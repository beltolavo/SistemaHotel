CREATE DATABASE SistemaHotel;
GO

USE SistemaHotel;
GO

CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL,
    CPF VARCHAR(14) NOT NULL UNIQUE,
    DataNascimento DATE NOT NULL,
    Telefone VARCHAR(20),
    Email VARCHAR(150),
    Endereco VARCHAR(200),
    Cidade VARCHAR(100)
);

CREATE TABLE Quartos (
    IdQuarto INT IDENTITY(1,1) PRIMARY KEY,
    NumeroQuarto INT NOT NULL UNIQUE,
    Tipo VARCHAR(50) NOT NULL,
    Capacidade INT NOT NULL,
    ValorDiaria DECIMAL(10,2) NOT NULL,
    StatusQuarto VARCHAR(20) NOT NULL DEFAULT 'Disponivel',
    Andar INT,
    Descricao VARCHAR(200)
);

CREATE TABLE Funcionarios (
    IdFuncionario INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL,
    CPF VARCHAR(14) NOT NULL UNIQUE,
    Telefone VARCHAR(20),
    Email VARCHAR(150),
    Cargo VARCHAR(80) NOT NULL,
    DataAdmissao DATE NOT NULL,
    Salario DECIMAL(10,2) NOT NULL,
    StatusFuncionario VARCHAR(20) NOT NULL DEFAULT 'Ativo'
);

CREATE TABLE Reservas (
    IdReserva INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NOT NULL,
    IdQuarto INT NOT NULL,
    DataEntrada DATE NOT NULL,
    DataSaida DATE NOT NULL,
    QuantidadeHospedes INT NOT NULL,
    ValorTotal DECIMAL(10,2) NOT NULL,
    StatusReserva VARCHAR(30) NOT NULL DEFAULT 'Agendada',
    CONSTRAINT FK_Reservas_Clientes
        FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    CONSTRAINT FK_Reservas_Quartos
        FOREIGN KEY (IdQuarto) REFERENCES Quartos(IdQuarto)
);
GO
