CREATE SCHEMA login;
CREATE TABLE login.userLogin
(
	user_ID				NUMERIC(10) not null,
	user_name			VARCHAR(250) not null,
	user_pwd			VARCHAR(250) not null,
	CONSTRAINT user_ID_pk PRIMARY KEY (user_ID)
);

CREATE SEQUENCE login.user_ID_seq START WITH 1 INCREMENT BY 1;

INSERT INTO login.userLogin values(NEXTVAL('login.user_ID_seq'), 'Test', 'xxx');

CREATE USER login PASSWORD 'test';

GRANT SELECT, UPDATE, INSERT on login.userLogin TO login;
GRANT USAGE on SCHEMA login TO Login;
GRANT USAGE on SEQUENCE login.user_ID_seq TO login;