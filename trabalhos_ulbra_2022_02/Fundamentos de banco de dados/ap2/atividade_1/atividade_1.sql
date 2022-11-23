create table clientes(
    id int auto_increment primary key,
    cpf char(14) unique not null,
    nome varchar(250) not null,
    telefone char(14) unique not null,
    endereco varchar(250) not null
);

create table carros(
    id int auto_increment primary key,
    placa char(7) unique not null,
    modelo varchar(100) not null,
    codigo_marca int not null,
    marca varchar(100) not null,
    ano int not null
);

create table alugueis(
    id int auto_increment primary key,
    numero_registro int unique not null,
    data_aluguel date not null,
    data_devolucao date not null,
    valor_aluguel decimal(12,2) not null,
    id_cliente int not null,
    id_carro int not null,
    constraint clientes_fk_alugueis
        foreign key(id_cliente) references clientes(id)
        on delete restrict
        on update cascade,

    constraint carros_fk_alugueis
        foreign key(id_carro) references carros(id)
        on delete restrict
        on update cascade 
);

create table aluguel_carros(
    id_aluguel int,
    id_carro int,
    constraint alugueis_fk_aluguel_carros
        foreign key(id_aluguel) references alugueis(id)
        on delete CASCADE
        on update CASCADE,

    constraint carros_fk_aluguel_carros
        foreign key(id_carro) references carros(id)
        on delete RESTRICT
        on update RESTRICT
);

/*
Adicionando clientes{
    insert into clientes (cpf, nome, telefone, endereco)
    values
    ('041.711.930-52', 'João Manoel Dias Pereira', '(51)99590-6640',  'Rua Alegrete, 448 Arroio do Sal')
    ('875.598.823-85', 'Lucas da Silva Sauro', '(54)99987-6642', 'Rua Vila das Flores, 68 Arroio do Sal');
}

Adicionando carros{
    INSERT INTO carros(placa, modelo, codigo_marca, marca, ano)
	VALUES
    	('GDFW543', 'Cronos', 1,'Fiat', 2021),
        ('HGFE978', 'Palio', 2, 'Fiat', 2005);
}

Adicionando registro de alugueis{
    insert into alugueis(numero_registro, data_aluguel, data_devolucao, valor_aluguel, id_cliente, id_carro)
	values
    	(8432459, '2021-09-08', '2021-09-20', 1450, 1, 1),
        (0568387, '2022-02-07', '2022-03-10', 1025, 2, 2);
}

Adicionando alugueis_carros{
    insert into aluguel_carros(id_aluguel, id_carro)
	VALUES
    	(1, 1),
        (1, 2),
        (2, 1);
}

Quais carros foram locados no mês de setembro {
    select * from alugueis where MONTH(data_aluguel) = 09;
}

Quais clientes que tem silva no nome {
    select nome from clientes 
	where nome like '%silva%'
    or nome like '%Silva%';
}

Adicionando 20% em todos os valores de alugueis {
    UPDATE alugueis
    set valor_aluguel = ((valor_aluguel * 20) / 100) + valor_aluguel 
}
*/

