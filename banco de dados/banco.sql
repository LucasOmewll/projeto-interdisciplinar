create database banco;

use banco;

-- ====================================================================
-- Criando tabela dos cargos: Gerente e Professor
create table tb_cargos
(
	cod tinyint(1) primary key not null auto_increment,
    descricao varchar(11) not null
);

insert into tb_cargos (descricao) values ('GERENTE');
insert into tb_cargos (descricao) values ('PROFESSOR');

select * from tb_cargos;
-- ====================================================================

-- ====================================================================
-- Criando tabela dos funcionários 
create table tb_funcionarios
(
	cpf varchar(14) not null primary key,
    nome varchar(70) not null,
    telefone varchar(15) not null,
    cep varchar(9) not null,
    cargo tinyint(1) not null,
    situacao varchar(9) not null default 'ATIVO',
    
    foreign key (cargo) references tb_cargos(cod),
    constraint chkSituacao check (situacao in ('ATIVO', 'DESLIGADO'))
);
desc tb_funcionarios;

-- ====================================================================
create table tb_professores
(
	cref varchar(20) primary key not null,
    cpf varchar(14) not null,
    sexo char(1) not null,
    tipo varchar(9) not null,
    
    foreign key (cpf) references tb_funcionarios(cpf),
    constraint chkSexo check (sexo in ('F', 'M')),
    constraint chkTipo check (tipo in ('FUNCIONÁRIO', 'PERSONAL'))
);
-- ====================================================================

-- ====================================================================
create table tb_clientes
(
	cpf varchar(14) primary key not null,
    nome varchar(70) not null, 
    telefone varchar(15) ,
    sexo char(1) not null,
    patologia varchar(100),
    restrições varchar(180),
    examevalidade date not null,
    frequencia tinyint(2) not null,
    plano varchar(13) not null,
    situacao varchar(9) not null, 
    professor varchar(20),
    datamatricula date not null,
    
    foreign key (professor) references tb_professores(cref),
    constraint chkInadimplente check (situacao in ('REGULAR','INADIMPLENTE')),
    constraint chkPlano check (plano in ('MENSAL', 'BIMESTRAL', 'TRIMESTRAL', 'SEMESTRAL', 'ANUAL', 'PERSONALIZADO')),
    constraint chkSexoCliente check (sexo in ('F', 'M'))
);
desc tb_clientes;
-- ====================================================================

-- ====================================================================
create table tb_musculos
(
	codigo int(2) primary key not null,
    nome varchar(20) not null
);

insert into tb_musculos values (0, 'COSTAS');
insert into tb_musculos values (1, 'PEITORAL');
insert into tb_musculos values (2, 'TRÍCEPS');
insert into tb_musculos values (3, 'BÍCEPS');
insert into tb_musculos values (4, 'ANTEBRAÇO');
insert into tb_musculos values (5, 'PERNAS');

select * from tb_musculos;
-- ====================================================================

-- ====================================================================
create table tb_exercicios
(
	codigo int(4) primary key not null auto_increment,
    nome varchar(50) not null,
    grupomuscular int(2) not null,
    tipo varchar(13) not null,
    
    foreign key (grupomuscular) references tb_musculos(codigo),
    constraint chkTipo check (tipo in ('INICIANTE', 'INTERMEDIÁRIO','AVANÇADO'))
);
-- ====================================================================

-- ====================================================================
create table tb_treinos 
(
	codigo int(5) primary key not null auto_increment,
    aluno varchar(14) not null,
    numero char(1),
    series tinyint(2) not null,
    repeticoes tinyint(3) not null,
    
    foreign key (aluno) references tb_clientes(cpf)
);
-- ====================================================================

show tables;