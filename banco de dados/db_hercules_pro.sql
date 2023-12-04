show databases;
drop database if exists db_herculespro;

create database db_herculespro;
use db_herculespro;

create table tb_cargos
(
	codigo smallint(1) primary key not null auto_increment,
    descricao varchar(11) not null
);

insert into tb_cargos (descricao) values ('GERENTE');
insert into tb_cargos (descricao) values ('PROFESSOR');

create table tb_gerentes
(
	codigo smallint(2) primary key not null auto_increment,
    cpf varchar(14) not null unique,
    nome varchar(60) not null,
    telefone varchar(15) not null,
    cep varchar(9) not null,
    cargo smallint(1) not null,
	senha binary(128) not null,
    
    
    foreign key (cargo) references tb_cargos(codigo)
);

create table tb_situacoes
(
	codigo smallint(1) primary key not null auto_increment,
    nome varchar(12) not null,
    
    constraint chkSituacoes check (nome in ('REGULAR', 'INADIMPLENTE','ATIVO','DESLIGADO'))
);
insert into tb_situacoes(nome) values ('REGULAR'); 
insert into tb_situacoes(nome) values ('INADIMPLENTE');
insert into tb_situacoes(nome) values('ATIVO');
insert into tb_situacoes(nome) values('DESLIGADO');

create table tb_professores
(
	codigo smallint(2) primary key not null auto_increment,
    cpf varchar(14) not null unique,
    cref varchar(11) not null unique,
    nome varchar(60) not null,
    telefone varchar(15) not null,
    cep varchar(9) not null,
    sexo char(1) not null,
    cargo smallint(1) not null,
    situacao smallint(1) not null,
    salario decimal(8,2) not null,
    senha binary(128) not null,
    
    foreign key (cargo) references tb_cargos(codigo),
    foreign key (situacao) references tb_situacoes(codigo),
    constraint chkSexo check (sexo in ('F', 'M'))
);

create table tb_pagamentos
(
	codigo mediumint(6) primary key not null auto_increment,
    professor smallint(2),
    datapgto date,
    
    foreign key (professor) references tb_professores(codigo)
);

create table tb_planos
(
	codigo smallint(3) primary key not null,
    nome varchar(20),
    valor decimal(9,2),
    meses smallint(2)
);
create table tb_clientes
(
	codigo smallint(4) primary key not null auto_increment,
    cpf varchar(14) not null unique,
    nome varchar(60) not null,
    telefone varchar(15) not null,
    sexo char(1) not null,
    idade smallint(3) not null,
    patologia varchar(180),
    restricoes varchar(180),
    examevalidade date not null,
    frequencia smallint(1) not null,
    plano smallint(3) not null,
    situacao smallint(1) not null,
    professor smallint(2) not null,
    cpf_responsavel varchar(14),
    
    foreign key (professor) references tb_professores(codigo),
    foreign key (plano) references tb_planos(codigo),
    foreign key (situacao) references tb_situacoes(codigo),
    constraint chkSexo_02 check (sexo in ('F','M'))
);

create table tb_pag_assinaturas
(
	codigo mediumint(6) primary key not null auto_increment,
    cliente smallint(2),
    datapgto date,
    
    foreign key (cliente) references tb_clientes(codigo)
);

create table tb_treino(
	id INT AUTO_INCREMENT PRIMARY KEY,
	tipo_treino varchar(20),
	cpf_aluno varchar(14),
	professor varchar(45)
);

CREATE TABLE financeiro (
    id INT AUTO_INCREMENT PRIMARY KEY,
    descricao VARCHAR(255),
    valor DECIMAL(10, 2),
    tipo_pagamento VARCHAR(20),
    data DATE,
    tipo VARCHAR(20),
    data_pagamento DATE,
    responsavel VARCHAR(40),
    categoria VARCHAR(40)
);

-- TRIGGER: REGISTRAR PAGAMENTO NO MOMENTO DA ASSINATURA PELO CLIENTE
delimiter $$
create trigger apos_cadastro_cliente
after insert 
on tb_clientes for each row
begin
	insert into tb_pag_assinaturas (cliente, datapgto) values (new.codigo, current_date);
end$$
delimiter ;

-- TRIGGER: registrar receita após pagamento de cliente
delimiter $$
create trigger apos_pagamento_assinatura
after insert
on tb_pag_assinaturas for each row
begin
    insert into financeiro(descricao, valor, tipo_pagamento, data, tipo, data_pagamento, responsavel, categoria)
    values(
    'pagamento', 
    (select tb_planos.valor from tb_planos inner join tb_clientes on tb_clientes.plano =  tb_planos.codigo where tb_clientes.codigo = new.cliente),
    'À vista',
    current_date(),
    'Entrada',
    new.datapgto,
    'Funcionário',
    'Mensalidades'
    );
end$$
delimiter ;


-- TRIGGER: registrar despesa ao pagar professor
delimiter $$
create trigger apos_pagamento_professores
after insert
on tb_pagamentos for each row
begin
    insert into financeiro(descricao, valor, tipo_pagamento, data, tipo, data_pagamento, responsavel, categoria)
    values(
    'salário', 
    (select tb_professores.salario from tb_professores where tb_professores.codigo = new.professor),
    'À vista',
    current_date(),
    'Saída',
    new.datapgto,
    'Gerente',
    'Gastos com Instrutores e Funcionários'
    );
end$$
delimiter ;

update tb_pag_assinaturas set datapgto = '1996-11-11' where cliente = 1; 