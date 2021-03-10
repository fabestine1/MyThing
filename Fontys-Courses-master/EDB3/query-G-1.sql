SELECT p.PRES_NAME, PARTY, COUNT(HOBBY) FROM PRESIDENT p
JOIN PRES_HOBBY ph ON p.PRES_NAME = ph.PRES_NAME
GROUP BY p.PRES_NAME, PARTY HAVING COUNT(HOBBY) = (SELECT MAX(COUNT(HOBBY)) FROM PRES_HOBBY ph2 WHERE PRES_NAME IN (SELECT PRES_NAME FROM PRESIDENT WHERE PARTY = p.PARTY) GROUP BY ph2.PRES_NAME);