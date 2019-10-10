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
INSERT INTO tipo_usuario (`id`, `descr`) VALUES (5, 'Morador');




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
--SINDICO
--------------------------------------*/
DROP TABLE `Sindico`;
CREATE TABLE `Sindico` (
`idSindico` INTEGER NOT NULL PRIMARY KEY,
`CPF` VARCHAR,
`idCondominio` INTEGER NOT NULL,
FOREIGN KEY(`idSindico`) REFERENCES `Usuario`(`id_usuario`),
FOREIGN KEY(`idCondominio`) REFERENCES `Condominio`(`id`));

INSERT INTO `Sindico` (`idSindico`, `CPF`, `idCondominio`) VALUES (4, '111111111-11', 2);

DELETE  FROM SINDICO;

SELECT * FROM USUARIO;
 
SELECT * FROM `Usuario` us
JOIN `Sindico` si ON si.idSindico = us.id_usuario;


INSERT INTO `Sindico` (`idCondomino`, `CPF`, `idCondominio`) VALUES (2, '98765432109', 2);



/*--------------------------------------
--CONDOMINO
--------------------------------------*/
DROP TABLE `Condomino`;
CREATE TABLE `Condomino` (
`idCondomino` INTEGER NOT NULL PRIMARY KEY,
`CPF` VARCHAR,
FOREIGN KEY(`idCondomino`) REFERENCES `Usuario`(`id_usuario`));


INSERT INTO `Condomino` (`idCondomino`, `CPF`) VALUES (2, '12345678901');
INSERT INTO `Condomino` (`idCondomino`, `CPF`) VALUES (4, '15530748821');

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
`dataSorteio` VARCHAR,
`dataValidadeSorteioInicio` VARCHAR,
`dataValidadeSorteioFim` VARCHAR,
`associarVagasSequenciais` BOOLEAN,
`idCondominio` INTEGER,
FOREIGN KEY (`idCondominio`) REFERENCES Condominio (`id`));

select * from condominio;


id = un.idCondominio
JOIN vagaGaragem va ON un.id = va.idUnidade; 

INSERT INTO SorteioVagas (`tipoSorteio`, `dataSorteio`, `dataValidadeSorteioInicio`, `dataValidadeSorteioFim`, `associarVagasSequenciais`, `idCondominio`)
VALUES ('Fila', 2019-12-12 10:00:00, 2020-01-01 10:00:00, 2020-31-12 10:00:00, true, 2);

select * from sorteiovagas;


/*PARA DESABILITAR CHAVES ESTRANGEIRAS E DELETAR REGISTROS COM ESTA CHAVE*/
PRAGMA foreign_keys = OFF;

delete from unidade;
 
DROP TABLE unidade;
 
PRAGMA foreign_keys = ON;


SELECT * FROM usuario;

/*PARA VERIFICAR ESTRUTURA DA TABELA*/

PRAGMA table_info(`Unidade`);

/*--------------------------------------
--RESULTADOSORTEIO
--------------------------------------*/
DROP TABLE `ResultadoSorteio`;
CREATE TABLE `ResultadoSorteio`(
`id` INTEGER PRIMARY KEY,
`idUnidade` INTEGER,
`idVagaGaragem` INTEGER,
`idSorteioVaga` INTEGER,
FOREIGN KEY (`idUnidade`) REFERENCES `Unidade` (`id`),
FOREIGN KEY (`idVagaGaragem`) REFERENCES `VagaGaragem` (`id`),
FOREIGN KEY (`idSorteioVaga`) REFERENCES `SorteioVagas` (`id`));



*--------------------------------------
--ELEICAO
--------------------------------------*/
DROP TABLE `Eleicao`;
CREATE TABLE `Eleicao`(
`idEleicao` INTEGER PRIMARY KEY,
`nomeEleicao` VARCHAR,
`tipoEleicao` VARCHAR,
`descricaoEleicao` VARCHAR,
`statusEleicao` BOOLEAN,
`dataInicioEleicao` VARCHAR,
`dataFimEleicao` VARCHAR,
`idCondominio` INTEGER,
FOREIGN KEY (`idCondominio`) REFERENCES `Condominio` (`id`));--TODO: talvez haja outro tipo de eleição, de assuntos gerais.

/*--------------------------------------
--TIPOELEICAO
--------------------------------------*/
DROP TABLE `TipoEleicao`;
CREATE TABLE `TipoEleicao`(
`idTipoEleicao` INTEGER PRIMARY KEY,
`nomeTipoEleicao` VARCHAR,
`idEleicao` INTEGER,
FOREIGN KEY (`idEleicao`) REFERENCES `Eleicao` (`idEleicao`));




/*--------------------------------------
--VOTO
--------------------------------------*/
DROP TABLE `Voto`;
CREATE TABLE `Voto`(
`idVoto` INTEGER PRIMARY KEY,
`idOpcaoVotada` INTEGER,--corrigir nos diagramas: é preciso apontar o ID da opção votada
`idEleicao` INTEGER,
`idUnidade` INTEGER,
FOREIGN KEY (`idOpcaoVotada`) REFERENCES `OpcaoDeVoto` (`idOpcaoVotada`) --atualizar nomes da classe Candidato e classes herdeiras. 
FOREIGN KEY (`idEleicao`) REFERENCES `Eleicao` (`idEleicao`),
FOREIGN KEY (`idUnidade`) REFERENCES `Unidade` (`id`));


	
/*--------------------------------------
--OPCAODEVOTO
--------------------------------------*/
DROP TABLE `OpcaoDeVoto`;
CREATE TABLE `OpcaoDeVoto`(
`idOpcaoVotada` INTEGER PRIMARY KEY,
`nomeOpcaoVotada` VARCHAR,--corrigir nos diagramas: é preciso apontar o ID da opção votada
`descricaoOpcaoVotada` VARCHAR, --CORRIGIR TIPO NO DIAGRAMA DE CLASSE
`idEleicao` INTEGER,
`URLfotoOpcaoVotada` VARCHAR, --incluir no diagrama de classe de negócio
FOREIGN KEY (`idEleicao`) REFERENCES `Eleicao` (`idEleicao`));


INSERT INTO `OpcaoDeVoto`(`nomeOpcaoVotada`, `descricaoOpcaoVotada`, `URLfotoOpcaoVotada`, `idEleicao`)
VALUES ('Pintura da Fachada', 'Vamos pintar de amarelo.', 'c:\caminho da foto', 1);

INSERT INTO `OpcaoDeVoto`(`nomeOpcaoVotada`, `descricaoOpcaoVotada`, `URLfotoOpcaoVotada`, `idEleicao`)
VALUES ('Pintura da Fachada', 'Vamos pintar de roxo', 'c:\caminho da foto', 1);


INSERT INTO `Eleicao` (`nomeEleicao`, `tipoEleicao`, `descricaoEleicao`,`statusEleicao`, `dataInicioEleicao`, 
`dataFimEleicao`, `idCondominio`)
VALUES ('Escolha da cor de pintura da fachada', 'Plebiscito', 'Vamos escolher a cor da fachada', 'Agendada',
'12/12/2019 00:00:00', '20/12/2019 00:00:00', 2);

/*--------------------------------------
--OPCAODEVOTOPLEBISCITO
--------------------------------------*/
DROP TABLE `OpcaoDeVotoProjetoPlebiscito`;
CREATE TABLE `OpcaoDeVotoPlebiscito`(
`idOpcaoVotadaPlebiscito` INTEGER PRIMARY KEY,
`valorProjeto` NUMBER,
`prazoExecucaoEmMeses` INTEGER,
`prazoPagamentoEmMeses` INTEGER,
FOREIGN KEY (`idOpcaoVotadaProjeto`) REFERENCES `OpcaoDeVoto` (`idOpcaoVotada`)); --atualizar nomes da classe Candidato e classes herdeiras. 




/*--------------------------------------
--OPCAODEVOTOPLEBISCITO ---valendo para protótipo
--------------------------------------*/
DROP TABLE `OpcaoDeVotoPlebiscito`;
CREATE TABLE `OpcaoDeVotoPlebiscito`(
`idOpcaoVotadaPlebiscito` INTEGER PRIMARY KEY,
`nomeOpcaoVotada` VARCHAR,
`idEleicao` INTEGER,
FOREIGN KEY (`idEleicao`) REFERENCES `Eleicao` (`idEleicao`)); --atualizar nomes da classe Candidato e classes herdeiras. 




/*--------------------------------------
--OPCAODEVOTOPROJETO
--------------------------------------*/
DROP TABLE `OpcaoDeVotoProjeto`;
CREATE TABLE `OpcaoDeVotoProjeto`(
`idOpcaoVotadaProjeto` INTEGER PRIMARY KEY,
`valorProjeto` NUMBER,
`prazoExecucaoEmMeses` INTEGER,
`prazoPagamentoEmMeses` INTEGER,
FOREIGN KEY (`idOpcaoVotadaProjeto`) REFERENCES `OpcaoDeVoto` (`idOpcaoVotada`)); --atualizar nomes da classe Candidato e classes herdeiras. 






/*--------------------------------------
--OPCAODEVOTOSINDICORESIDENTE
--------------------------------------*/
DROP TABLE `OpcaoDeVotoSindicoResidente`;
CREATE TABLE `OpcaoDeVotoSindicoResidente`(
`idOpcaoVotadaSindicoResidente` INTEGER PRIMARY KEY,
`idSindicoComoCondomino` INTEGER,
FOREIGN KEY (`idOpcaoVotadaSindicoResidente`) REFERENCES `OpcaoDeVoto` (`idOpcaoVotada`),
FOREIGN KEY (`idSindicoComoCondomino`) REFERENCES `Condomino` (`id`)); --atualizar classe e relacionamento de classe para síndico que é condômino 



/*--------------------------------------
--OPCAODEVOTOSINDICOPROFISSIONAL
--------------------------------------*/
DROP TABLE `OpcaoDeVotoSindicoProfissional`;
CREATE TABLE `OpcaoDeVotoSindicoProfissional`(
`idOpcaoVotadaSindicoResidente` INTEGER PRIMARY KEY,
`CNPJ` VARCHAR,
`enderecoLogradouro` VARCHAR,
`enderecoNumero` VARCHAR,
`enderecoComplemento` VARCHAR, --atualilzar no diagrama de classe
`enderecoCidade` VARCHAR,
`enderecoCEP` VARCHAR,
`enderecoEstado` VARCHAR,
`telefone` VARCHAR,
`valorServico` NUMBER,
FOREIGN KEY (`idOpcaoVotadaSindicoResidente`) REFERENCES `OpcaoDeVoto` (`idOpcaoVotada`)); 




/*---------------------------------------------------
EXEMPLO DE SELECT PARA IDENTIFICAR SORTEIO POR CONDÔMINO
---------------------------------------------------*/
SELECT * FROM `ResultadoSorteio` rs
JOIN `SorteioVagas` sv ON sv.id = rs.idSorteioVaga
JOIN `Unidade` un ON un.id = rs.idUnidade
JOIN `VagaGaragem` vg ON vg.id = rs.idVagaGaragem
WHERE sv.idCondominio = 2
AND un.idCondomino = 2
AND sv.id = (select MAX(id) from `SorteioVagas`);




/*---------------------------------------------------
EXEMPLO DE SELECT PARA IDENTIFICAR CONDOMINIO POR CONDÔMINO
---------------------------------------------------*/
SELECT * FROM `Condominio` co
JOIN `Unidade` un ON un.idCondominio = co.id
JOIN `Usuario` us ON us.id_usuario = un.idCondomino
WHERE us.id_usuario = 2;


/*---------------------------------------------------
EXEMPLO DE SELECT PARA IDENTIFICAR CONDOMINIO POR síndico
---------------------------------------------------*/
SELECT * FROM `Condominio` co
JOIN `Unidade` un ON un.idCondominio = co.id
JOIN `Usuario` us ON us.id_usuario = un.idCondomino
WHERE us.id_usuario = 2;




/*---------------------------------------------------
EXEMPLO DE SELECT PARA BUSCAR SÍNDICOS E TRAZER ID DO  CONDOMÍNIO DO SÍNDICO
---------------------------------------------------*/
SELECT * FROM `Usuario` us
JOIN `Sindico` si ON si.idSindico = us.id_usuario;

/*---------------------------------------------------
EXEMPLO DE SELECT PARA IDENTIFICAR CONDOMINO E TRAZER ID DO CONDOMINIO POR MEIO DA TABELA UNIDADE
---------------------------------------------------*/

SELECT * FROM `Usuario` us
JOIN unidade un ON un.idCondomino = us.id_usuario;


/*---------------------------------------------------
EXEMPLO DE SELECT PARA BUSCAR UNIDADE DO CONDOMINO NO CONDOMINIO 
---------------------------------------------------*/
SELECT * FROM `Unidade` un 
                JOIN  `Condomino` cno ON cno.idCondomino = un.idCondomino 
                JOIN  `Condominio` cio ON cio.id = un.idCondominio 
					WHERE cno.idCondomino=2 AND cio.id=2;





/*---------------------------------------------------
EXEMPLO DE SELECT PARA BUSCAR NÚMERO DE VOTOS PARA UMA OPÇÃO DE UMA ELEIÇÃO (PLEBISCITO) 
---------------------------------------------------*/
SELECT vp.nomeOpcaoVotada, count(*) As QtdVotos FROM `Voto` vo
JOIN `Eleicao` el ON el.idEleicao = vo.idEleicao
JOIN opcaoDeVotoPlebiscito vp ON vp.idOpcaoVotadaPlebiscito = vo.idOpcaoVotada
WHERE VP.idOpcaoVotadaPlebiscito = 2;



