SELECT * FROM Produtos

SELECT COUNT(*) FROM Produtos
SELECT COUNT (*) QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT SUM(Preco) PrecoTotal FROM Produtos 
SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho = 'M'
SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos
SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos WHERE Tamanho = 'M'
SELECT AVG(Preco) ProdutosMedia FROM Produtos

SELECT
	Nome + ' Cor: ' + Cor + ' - ' + Genero NovosNomes,
	UPPER(Nome) Nome,
	LOWER(Cor)  cor

FROM Produtos

ALTER TABLE Produtos
ADD DataCadastro DATETIME2 

SELECT 
	Tamanho,
	COUNT(*) Quantidade
FROM produtos
WHERE Tamanho <> ''
GROUP BY tamanho
ORDER BY Quantidade DESC

CREATE TABLE Enderecos(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	IDCliente int NULL,
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,	
	Estado char(2) NULL,

	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente)
	REFERENCES Clientes(id)
)

SELECT * FROM Enderecos
SELECT * FROM Clientes

INSERT INTO Enderecos VALUES (4, 'RUA MINHA', 'OTA RUA', 'CIDADADE TESTE', 'RN')

SELECT * FROM Clientes where Id = 4
SELECT * FROM Enderecos WHERE IdCliente = 4

SELECT 
	Clientes.Nome,
	Clientes.Sobrenome,
	Clientes.Email,
	Enderecos.Rua,
	Enderecos.Cidade,
	Enderecos.Estado
FROM
	Clientes
INNER JOIN Enderecos ON Clientes.id = Enderecos.IdCliente
WHERE Clientes.Id = 4