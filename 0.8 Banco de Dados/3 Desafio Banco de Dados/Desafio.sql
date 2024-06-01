-- 1
SELECT Nome, Ano FROM Filmes

-- 2
SELECT Nome, Ano 
From Filmes  
ORDER BY Ano ASC

-- 3
SELECT Nome, Ano, Duracao FROM Filmes 
WHERE Nome = 'De volta para o futuro'

-- 4
SELECT * FROM Filmes WHERE Ano = 1997

-- 5
SELECT * FROM Filmes WHERE Ano > 2000

-- 6
SELECT * FROM Filmes WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao ASC

-- 7
SELECT Ano,
	COUNT(*) Quantidade
FROM Filmes
GROUP BY Ano	
ORDER BY Quantidade DESC

-- 8 
SELECT PrimeiroNome, UltimoNome FROM Atores WHERE Genero = 'M'

--9
SELECT PrimeiroNome, UltimoNome FROM Atores WHERE Genero = 'F'
ORDER BY PrimeiroNome

-- 10
SELECT f.Nome, g.Genero
FROM Filmes f
JOIN Generos g ON f.ID = g.ID

-- 11
SELECT
    F.Nome,
    G.Genero
FROM
    Filmes F
JOIN FilmesGenero FG ON F.Id = FG.IdFilme
JOIN Generos G ON FG.IdGenero = G.Id
WHERE G.Genero = 'Mistério';

-- 12
SELECT
    F.Nome AS NomeFilme,
    A.PrimeiroNome,
    A.UltimoNome,
    E.Papel
FROM
    Filmes F
JOIN ElencoFilme E ON F.Id = E.IdFilme
JOIN Atores A ON E.IdAtor = A.Id;