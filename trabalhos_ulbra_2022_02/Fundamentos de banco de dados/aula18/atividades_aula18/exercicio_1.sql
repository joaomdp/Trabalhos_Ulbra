--Criar todas as tabelas do esquema.
create table cidades(
    cod_cidade int auto_increment primary key,
    nome varchar(100) not null,
    uf char(2) not null 
);

create table medicos(
    cod_medico int auto_increment primary key,
    nome varchar(100) not null,
    endereco varchar(250) not null,
    telefone char(14) not null,
    crm char(12) not null,
    cpf char(14) unique not null,
    cod_cidade int not null,
    constraint medicos_fk_cidades
        foreign key(cod_cidade) references cidades(cod_cidade) 

    on delete cascade
    on update cascade
);

create table pacientes(
    cod_paciente int auto_increment primary key,
    nome varchar(100) not null,
    endereco varchar(250) not null,
    telefone char(14) not null,
    cod_cidade int not null,
    constraint pacientes_fk_cidades
        foreign key(cod_cidade) references cidades(cod_cidade)

    on delete cascade
    on update cascade
);

create table consultas(
    cod_consulta int auto_increment primary key,
    cod_medico int not null,
    cod_paciente int not null,
    data_consulta date not null,
    horas time not null,

    constraint consultas_fk_pacientes
        foreign key(cod_paciente) references pacientes(cod_paciente),
    constraint consultas_fk_medicos
        foreign key(cod_medico) references medicos(cod_medico)
     
    on delete cascade
    on update cascade
);

create table medicamentos(
    cod_medicamento int auto_increment primary key,
    nome varchar(100) not null,
    composicao varchar(100) not null,
    preco decimal(12,2) not null
);

create table pescricao(
    cod_consulta int not null,
    cod_medicamento int not null,
    posologia varchar(100) not null,

    constraint pescricao_fk_consultas
        foreign key(cod_consulta) references consultas(cod_consulta),
    constraint pescricao_fk_medicamentos
        foreign key(cod_medicamento) references medicamentos(cod_medicamento)

    on delete cascade
    on update cascade
);

--Inserir 3 registros em cada tabela.
/*
    INSERT into cidades(nome, uf)
    values 	('Rondonia', 'RS'),
		    ('Mexico', 'SC'),
		    ('Torres', 'RS');

    SELECT * 
    from cidades;

    INSERT into medicos(nome, endereco, telefone, crm, cpf, cod_cidade)
    values 	
            ('Joao', 'Rua Aquela, 123', '(51)9998-3366', 'CRM/SP123456', '111.222.333-44', 3),
            ('Vagner', 'Rua Aquela outra, 321', '(54)8899-6633', 'CRM/SC654321', '222.888.666-77', 2),
            ('Estela', 'Rua Qualquer, 445', '(56)7894-3211', 'CRM/RS789456', '654.789.321-45', 1);
    SELECT * 
    from medicos;    

    INSERT into pacientes(nome, endereco, telefone, cod_cidade)
    values 	('Fulano', 'Rua Aquela, 123', '(51)7894-3366', 3),
            ('Pedro no bit', 'Rua Aquelaoutra, 123', '(51)6532-1452', 1),
            ('Gerson', 'Rua Tantofaz, 123', '(51)7954-5522', 2);
            
    SELECT * 
    from pacientes;

    INSERT into consultas(cod_medico, cod_paciente, data_consulta, horas)
    values 	(3, 1, '2022-11-11', '10:18:25'),
            (1, 2, '2022-12-15', '14:35:32'),
            (2, 3, '2022-07-09', '08:21:00');
            
    SELECT * 
    from consultas; 

    INSERT into medicamentos(nome, composicao, preco)
    values 	('PAtosse', 'Aquilo', 67),
		    ('PAgripe', 'Aquele', 100),
		    ('PAdor', 'Aquela', 124);
        
    SELECT * 
    from medicamentos; 

    INSERT into pescricao(cod_consulta, cod_medicamento, posologia)
    values 	(2, 3, 'toma agora'),
            (3, 1, 'toma depois'),
            (1, 2, 'toma sei lá');
            
    SELECT * 
    from pescricao; 
*/

--Atualizar o preço do medicamento de código 1 em 20%.
/*
    UPDATE medicamentos
    SET	preco = preco*1.20
    where cod_medicamento = 1;
            
    SELECT * 
    from medicamentos; 
*/

--Excluir a cidade cujo código é 3.
/*

*/

-- Listar os nomes das cidades do estado RS. 
/*
    SELECT cod_cidade, nome, uf
    FROM cidades
    WHERE uf = 'RS';
*/

--Listar todos os nomes de medicamentos e preço.
/*
    SELECT nome, preco
    FROM medicamentos
*/

-- Listar o nome e telefone dos médicos da cidade de ‘Torres’.
/*
    SELECT nome, telefone
    FROM medicos
    where cod_cidade = 3
*/

--Listar todas os nomes dos medicamentos, juntamente com a posologia, prescritos na consulta de código 1.
