SELECT p.PRES_NAME, YRS_SERV, ELECTION_YEAR, VOTES, SPOUSE_NAME FROM PRESIDENT p
JOIN ELECTION e ON p.PRES_NAME = e.CANDIDATE
JOIN PRES_MARRIAGE pm ON p.PRES_NAME = pm.PRES_NAME
WHERE STATE_BORN = 'TEXAS';