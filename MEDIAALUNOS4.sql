USE MediaAlunos

SELECT IdAluno, AVG(Português) AS MediaPortugues, AVG(Matemática) AS MediaMatematica, AVG(Geografia) AS MediaGeografia, AVG(História) AS MediaHistoria, AVG(Inglês) AS MediaIngles, AVG(Ciência) AS MediaCiencia, AVG(Educação_Física) AS MediaEducacaoFisica, AVG(Artes) AS MediaArtes
FROM NotaAlunos
GROUP BY IdAluno
