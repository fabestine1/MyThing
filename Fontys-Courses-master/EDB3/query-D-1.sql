SELECT SPOUSE_NAME FROM PRES_MARRIAGE pm JOIN PRESIDENT p ON pm.PRES_NAME = p.PRES_NAME JOIN STATE s ON p.STATE_BORN = s.STATE_NAME WHERE s.YEAR_ENTERED > 1800;