-- create table nome_da_tabela(
--     nome_do_atributo | dominio | vazios | chaves,
--     nome_do_atributo | dominio | vazios | chaves,
-- );

create table clientes(
    id int not null primary key,
    nome varchar(100) not null,
    CPF varchar(14) not null unique
);

create table enderecos(
    id int not null primary key,
    logradouro varchar(100) not null,
    numero char(10),
    bairro varchar(100),
    cidade varchar(100),
    estado varchar(2),
    id_cliente int not null,
        constraint fk_clientes_enderecos
            foreign key(id_cliente) references clientes(id)
);

create table engenheiro(
    id int not null primary key,
    nome varchar(100) not null
);

create table projeto(
    id int not null primary key,
    nome varchar(100) not null
);

create table atuacoes(
    id int not null primary key,
    funcao varchar(100) not null,
    id_engenheiro int not null,
    id_projeto int not null,
    constraint fk_engenheiros_atuacoes
        foreign key(id_engenheiro) references engenheiro(id),
    constraint fk_projetos_atuacoes
        foreign key(id_projeto) references projeto(id),
);

create table alunos(
    id int auto_increment primary key,
    nome varchar(100) not null
);

create table departamentos(
    id int not null primary key,
    nome varchar(100) not null 
); 

create table cursos(
    id int auto_increment primary key,
    nome varchar(100) not null,
    id_depto int not null,
    constraint fk_departamentos_cursos
        foreign key(id_depto) references departamentos(id)
);

create table professores(
    id int auto_increment primary key,
    nome varchar(100) not null
);

create table disciplinas(
    id int auto_increment primary key,
    nome varchar(100) not null,
    id_profe int not null,
    constraint fk_disciplinas_professores
        foreign key(id_profe) references professores(id)
);

create table matriculas(
    id int auto_increment primary key, 
    id_disciplinas int not null,
    constraint fk_matriculas_disciplinas
        foreign key(id_disciplinas) references disciplinas(id),
    id_aluno int not null,
    constraint fk_matriculas_alunos
        foreign key(id_aluno) references alunos(id),
    data_matricula date not null  
);

