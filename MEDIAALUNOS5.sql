USE MediaAlunos

SELECT IdAluno, AVG(Português) AS MediaPortugues, AVG(Matemática) AS MediaMatematica, AVG(Geografia) AS MediaGeografia, AVG(História) AS MediaHistoria, AVG(Inglês) AS MediaIngles, AVG(Ciência) AS MediaCiencia, AVG(Educação_Física) AS MediaEducacaoFisica, AVG(Artes) AS MediaArtes, AVG((Português + Matemática + Geografia + História + Inglês + Ciência + Educação_Física + Artes) / 8.0) AS MediaGeral
FROM NotaAlunos
GROUP BY IdAluno

USE MediaAlunos

SELECT IdAluno, AVG(Português) AS MediaPortugues, AVG(Matemática) AS MediaMatematica, AVG(Geografia) AS MediaGeografia, AVG(História) AS MediaHistoria, AVG(Inglês) AS MediaIngles, AVG(Ciência) AS MediaCiencia, AVG(Educação_Física) AS MediaEducacaoFisica, AVG(Artes) AS MediaArtes, AVG((Português + Matemática + Geografia + História + Inglês + Ciência + Educação_Física + Artes) / 8.0) AS MediaGeral
FROM NotaAlunos
GROUP BY IdAluno
