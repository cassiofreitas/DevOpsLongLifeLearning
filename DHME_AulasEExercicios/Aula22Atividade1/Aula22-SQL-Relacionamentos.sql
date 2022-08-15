CREATE TABLE INSTITUICAO (
	id int identity(1,1) primary key,
	nome varchar(60) not null,
	endereco varchar(250) not null,
	cnpj int not null
);

CREATE TABLE ALUNO (
	id int identity(1,1) primary key,
	id_instituicao int not null,
	nome varchar(60) not null,
	sobrenome varchar(60) not null,
	matricula int not null,

	CONSTRAINT FK_ID_INSTITUICAO FOREIGN KEY (id_instituicao) REFERENCES INSTITUICAO (id)
);

--INSERT INTO INSTITUICAO(nome,endereco,cnpj) VALUES ('ESCOLA DO CASSIO','RUA LUGAR NENHUM',123456789);
--INSERT INTO ALUNO (id_instituicao, nome, sobrenome, matricula) VALUES (17,'CASSIO','FREITAS',123456789);

-- SELECT * FROM ALUNO;
-- SELECT * FROM INSTITUICAO;

-- DELETE FROM ALUNO;
-- DELETE FROM INSTITUICAO;



