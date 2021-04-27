--------DQL-------------------



USE SENAI_HROADS_TARDE;

SELECT * FROM Classes;
SELECT * FROM Personagens;
SELECT * FROM Habilidades;
SELECT * FROM TiposHabilidades;

----------------------------------------------------------------
--SELECIONAR SOMENTE OS PERSONAGENS
-----------------------------------
SELECT Personagens.Nome FROM Personagens;



---SELECIONAR SOMENTE O NOME DAS CLASSES;
----------------------------------------
SELECT Classes.Nome FROM Classes;




--SELECIONAR TODAS AS HABILIDADES;
-----------------------------------------
SELECT * FROM Habilidades;




--SELECIONAR SOMENTE OD ID´S DAS HABILIDADES CLASSIFICANDO-OS POR ORDEM CRESCCENTE;
-----------------------------------------------------------------------------------
SELECT Habilidades.IdHabilidade FROM Habilidades ;



--SELECIONAR TODOS OS TIPOS DE HABILIDADE
------------------------------------------
SELECT * FROM TiposHabilidades;



--SELECIONAR TODAS AS HABILIDADES E A QUAIS TIPOS DE HABILIDADES ELAS PERTENCEM
-----------------------------------------------------------------------------------
SELECT *FROM Habilidades
INNER JOIN TiposHabilidades
ON Habilidades.IdHabilidade = TiposHabilidades.IdTipo;



--SELECIONAR TODOS OS PERSONAGENS E SUAS RESPECTIVAS CLASSES
------------------------------------------------------------
SELECT Personagens.IdPersonagens, Personagens.Nome, Classes.IdClasse, Classes.Nome FROM Personagens
INNER JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse;

--Selecionar todas as classes e suas respectivas habilidades;
--------------------------------------------------------------

SELECT Classes.Nome, Habilidades.Nome FROM Classes
INNER JOIN Habilidades
ON Classes.IdClasse = Habilidades.IdHabilidade;

--Selecionar todas as HABILIDADES e suas respectivas CLASSES;
--------------------------------------------------------------
SELECT Habilidades.Nome, Classes.Nome FROM Habilidades
INNER JOIN Classes
ON Habilidades.IdHabilidade = Classes.IdClasse;

--REALIZAR A CONTAGEM DE QUANTAS HABILIDADES ESTÃO CADASTRADAS
--------------------------------------------------------------
SELECT COUNT(Habilidades.Nome)  
FROM Habilidades;  
GO