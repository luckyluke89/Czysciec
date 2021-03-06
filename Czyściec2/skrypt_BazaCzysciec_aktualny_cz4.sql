CREATE VIEW [dbo].[WkNotatka]
AS
SELECT        n.IdNotatki, n.Tresc, n.DataCzasNotki, n.PriorytetNotatki,
                             (SELECT        Element
                               FROM            dbo.Slowniki AS sA
                               WHERE        (IdElementu = n.Oddzwonic) AND (NazwaSlownika LIKE 'Oddzwonic')) AS Oddzwonic, k.Nazwa AS Klient, n.Wpis, n.Oddzwonic AS id_Oddzwonic, a.Imie + ' ' + a.Nazwisko AS Osoba
FROM            dbo.Notatka AS n INNER JOIN
                         dbo.Autor AS a ON n.Autor = a.IdAutora INNER JOIN
                         dbo.Klient AS k ON n.Klient = k.IdKlienta