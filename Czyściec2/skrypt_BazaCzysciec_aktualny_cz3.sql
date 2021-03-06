CREATE VIEW [dbo].[WkWpis]
AS
SELECT        w.IdWpisu, w.DataCzasWpisu, w.Tresc, w.PriorytetWpisu, w.KiedyPrzekazaneWyzej, f.Nazwa AS NazwaFunkcji, p.Nazwa AS NazwaProgramu, a.Imie + ' ' + a.Nazwisko AS Autor,
                             (SELECT        Element
                               FROM            dbo.Slowniki AS sA
                               WHERE        (IdElementu = f.TypFunkcji) AND (NazwaSlownika LIKE 'TypFunkcji')) AS TypFunkcji,
                             (SELECT        Element
                               FROM            dbo.Slowniki AS sB
                               WHERE        (IdElementu = w.Stan) AND (NazwaSlownika LIKE 'Stan')) AS Stan,
                             (SELECT        Element
                               FROM            dbo.Slowniki AS sC
                               WHERE        (IdElementu = w.TypZgloszenia) AND (NazwaSlownika LIKE 'TypZgloszenia')) AS TypZgloszenia, f.Id AS id_Funkcjonalnosc, p.IdProgramu, w.Stan AS id_Stan, f.TypFunkcji AS id_TypFunkcji, 
                         w.TypZgloszenia AS id_TypZgloszenia
FROM            dbo.Wpis AS w INNER JOIN
                         dbo.Funkcjonalnosc AS f ON w.Funkcjonalnosc = f.Id INNER JOIN
                         dbo.Autor AS a ON w.Autor = a.IdAutora INNER JOIN
                         dbo.Program AS p ON f.Program = p.IdProgramu