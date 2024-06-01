SELECT * FROM clientes
SELECT * FROM produtos

INSERT INTO clientes VALUES ('Renato', 'Ramon', 'renato@gmail.com', 1, GETDATE())
INSERT INTO clientes (Sobrenome, Nome, Email, AceitaComunicados, DataCadastro) VALUES ('Renato', 'Ramon', 'renato@gmail.com', 1, GETDATE())

SELECT * FROM Clientes WHERE Nome = 'renato'
UPDATE Clientes SET Email = 'renatophoenix@gmail.com' WHERE nome = 'renato'
SELECT * FROM Clientes WHERE Nome = 'renato'


BEGIN TRAN
ROLLBACK

UPDATE Clientes SET  sobrenome = 'LARETZ'  WHERE nome = 'renato'