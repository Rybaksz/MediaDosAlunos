USE MediaAlunos

SELECT IdAluno, AVG(Portugu�s) AS MediaPortugues, AVG(Matem�tica) AS MediaMatematica, AVG(Geografia) AS MediaGeografia, AVG(Hist�ria) AS MediaHistoria, AVG(Ingl�s) AS MediaIngles, AVG(Ci�ncia) AS MediaCiencia, AVG(Educa��o_F�sica) AS MediaEducacaoFisica, AVG(Artes) AS MediaArtes
FROM NotaAlunos
GROUP BY IdAluno
