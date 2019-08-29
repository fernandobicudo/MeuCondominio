/*--------------------------------------
--TIPOS_USUARIOS
--------------------------------------*/
DROP TABLE tipo_usuario;
CREATE TABLE tipo_usuario(
`id` smallint NOT NULL PRIMARY KEY,
`descr` varchar2);

INSERT INTO tipo_usuario (`id`, `descr`) VALUES (1, 'Condômino');
INSERT INTO tipo_usuario (`id`, `descr`) VALUES (2, 'Síndico');
INSERT INTO tipo_usuario (`id`, `descr`) VALUES (3, 'Zelador');
INSERT INTO tipo_usuario (`id`, `descr`) VALUES (4, 'Administradora');



/*--------------------------------------
--USUARIO
--------------------------------------*/
DROP TABLE usuario;
CREATE TABLE usuario (
`id_usuario` INTEGER NOT NULL PRIMARY KEY,
`nome` VARCHAR NOT NULL,
`telefone` VARCHAR,
`email` VARCHAR,
`senha` VARCHAR,
`endereco` VARCHAR,
`numero_endereco` VARCHAR,
`complementoEndereco` VARCHAR,
`bairro` VARCHAR,
`cidade` VARCHAR,
`UF` VARCHAR(32),
`CEP` VARCHAR,
`tipo_usuario` SMALLINT,
`documento` VARCHAR,
FOREIGN KEY(tipo_usuario) REFERENCES tipo_usuario(`id`));



INSERT INTO `usuario` (`nome`,`telefone`,`email`,`senha`,`endereco`,`numero_endereco`,`complementoEndereco`,`bairro`,`cidade`,`UF`,`CEP`,`tipo_usuario`,`documento`) VALUES('Luís Fernando Bicudo','99236-3488','fernandobicudo@gmail.com','teste123','Rua Braga','266','ap. 123','Vila Lustiânia','São Bernardo do Campo','SP','09725-160',1,'15530748821');
INSERT INTO `usuario` (`nome`,`telefone`,`email`,`senha`,`endereco`,`numero_endereco`,`complementoEndereco`,`bairro`,`cidade`,`UF`,`CEP`,`tipo_usuario`,`documento`) VALUES('Antônio Guardado','68465-3513','guardado.fatecipiranga@gmail.com','fatecipiranga','Rua Frei João','123','','Ipiranga','São Paulo','SP','06852-322',1,'11111111111');
INSERT INTO `usuario` (`nome`,`telefone`,`email`,`senha`,`endereco`,`numero_endereco`,`complementoEndereco`,`bairro`,`cidade`,`UF`,`CEP`,`tipo_usuario`,`documento`) VALUES('Norton Glaser','99878-4565','norton@fatec.sp.gov.br','fatecipiranga','Rua Frei João','123','','Ipiranga','São Paulo','SP','06852-322',1,'22222222222');




update usuario set senha = "teste123" where id_usuario =1;


select * from usuario;


DELETE FROM USUARIO WHERE ID_USUARIO = 3;


/*--------------------------------------
--CONDOMINIO
--------------------------------------*/
DROP TABLE `condominio`;
CREATE TABLE `condominio` (
`id` INTEGER PRIMARY KEY,
`cnpj` VARCHAR,
`nome` VARCHAR, 
`qtdVagasporUnidade` INTEGER);

INSERT INTO `condominio` (`cnpj`,`nome`, `qtdVagasporUnidade`) VALUES ('59962175000122', 'Condominio Edificio Santarém', 2);
INSERT INTO `condominio` (`cnpj`,`nome`, `qtdVagasporUnidade`) VALUES ('55036859000142', 'Edifício Monte Alegre', 1);

  
SELECT * FROM `condominio`;

/*--------------------------------------
--UNIDADE
--------------------------------------*/
DROP TABLE `unidade`;
CREATE TABLE `unidade` (
`id` INTEGER PRIMARY KEY,
`qtdVagas` SMALLINT,
`identificacao` VARCHAR, 
`statusInadimplencia` VARCHAR, 
`statusOcupacao` BOOLEAN,
`idCondominio` INTEGER,
`idCondomino` INTEGER, 
FOREIGN KEY (`idCondominio`) REFERENCES Condominio (`id`),
FOREIGN KEY (`idCondomino`) REFERENCES Usuario (`id_usuario`));



INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '11', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '12', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '13', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '14', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '21', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '22', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '23', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '24', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '31', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '32', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '33', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '34', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '41', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '42', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '43', 'EM DIA', TRUE, 1, 1);
INSERT INTO `unidade` (`qtdVagas`, `identificacao`, `statusInadimplencia`, `statusOcupacao`, `idCondominio`, `idCondomino`) VALUES (2, '44', 'EM DIA', TRUE, 1, 1);

SELECT * FROM UNIDADE;

delete from unidade;

/*--------------------------------------
--VAGAGARAGEM
--------------------------------------*/
DROP TABLE `VagaGaragem`;
CREATE TABLE `VagaGaragem` (
`id` INTEGER PRIMARY KEY,
`numeracao` VARCHAR,
`vagaSequencial` BOOLEAN,
`idUnidade` INTEGER,
FOREIGN KEY (`idUnidade`) REFERENCES Unidade (`id`));



INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('1', TRUE, 1);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('2', TRUE, 2);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('3', TRUE, 3);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('4', TRUE, 4);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('5', TRUE, 5);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('6', TRUE, 6);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('7', TRUE, 7);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('8', TRUE, 8);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('9', TRUE, 9);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('10', TRUE, 10);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('11', TRUE, 11);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('12', TRUE, 12);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('13', TRUE, 13);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('14', TRUE, 14);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('15', TRUE, 15);
INSERT INTO `vagaGaragem` (`numeracao`, `vagaSequencial`, `idUnidade`) VALUES ('16', TRUE, 16);


select * from vagaGaragem;


/*--------------------------------------
--SORTEIOVAGAS
--------------------------------------*/
DROP TABLE `SorteioVagas`;
CREATE TABLE `SorteioVagas` (
`id` INTEGER PRIMARY KEY,
`tipoSorteio` VARCHAR,
`dataSorteio` Date,
`dataValidadeSorteioInicio` Date,
`dataValidadeSorteioFim` Date,
`associarVagasSequenciais` BOOLEAN,
`idUnidade` INTEGER,
`idVagaGaragem` INTEGER,
`idCondominio` INTEGER,
FOREIGN KEY (`idUnidade`) REFERENCES Unidade (`id`),
FOREIGN KEY (`idVagaGaragem`) REFERENCES VagaGaragem (`id`),
FOREIGN KEY (`idCondominio`) REFERENCES Unidade (`idCondominio`));



select * from usuario us
JOIN unidade un on un.idCondomino = us.id_usuario
JOIN condominio co ON co.id = un.idCondominio
JOIN vagaGaragem va ON un.id = va.idUnidade; 


/*PARA DESABILITAR CHAVES ESTRANGEIRAS E DELETAR REGISTROS COM ESTA CHAVE*/
PRAGMA foreign_keys = OFF;

delete from unidade;
 
DROP TABLE unidade;
 
PRAGMA foreign_keys = ON;


SELECT * FROM usuario;