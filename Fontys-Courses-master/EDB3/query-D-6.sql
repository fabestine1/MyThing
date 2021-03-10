SELECT PRES_NAME, BIRTH_YR, STATE_BORN, YRS_SERV, PARTY, DEATH_AGE, WINNER_LOSER_INDIC, ELECTION_YEAR FROM PRESIDENT p
JOIN ELECTION e ON p.PRES_NAME = e.CANDIDATE
WHERE ELECTION_YEAR > 1900;