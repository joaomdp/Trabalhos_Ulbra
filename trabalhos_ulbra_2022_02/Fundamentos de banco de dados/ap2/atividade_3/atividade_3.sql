create table socios(
    id int auto_increment primary key,
    nome varchar(250) not null,
    endereco varchar(300) not null,
    codigo_socio int unique not null,
    descricao_socio char(50)
);

create table servicos(
    id int auto_increment primary key,
    codigo_servico int unique not null,
    descricao varchar(50),
    mes_referencia date not null,
    valor_pago decimal(12,2) not null,
    id_socio int not null,
    constraint socios_fk_servicos
        foreign key(id_socio) references socios(id)
        on delete restrict 
        on update cascade
);

/*
Adicionando socios {
    insert into socios(nome, endereco, codigo_socio, descricao_socio)
    values 
        ('João Manoel', 'Barão do Rio Branco, 448', 1, 'Show'),
        ('Lucas da Silva', 'Barão do Rio Branco, 752', 2, 'Bacana'),
        ('Roberto Carlos', 'Vila das Flores, 56', 3, 'Chato');
}

Adicionando serviços {
    insert into servicos(codigo_servico, descricao, mes_referencia, valor_pago, id_socio)
    VALUES
        (30, 'Futebol', '2020-08-15', 200),
        (31, 'Volei', '2022-03-06', 800),
        (32, 'Handebol', '2020-02-18', 500),
        (33, 'Peteca', '2020-01-30', 700, 3);
}

- Listar os serviços onde o valor pago é maior que 500 {
    select * from servicos where valor_pago > 500;
}

- Listar os pedidos onde o mês de referência é janeiro de 2020{
    select * from servicos where month(mes_referencia) = 1;
}

- Listar os sócios que moram na rua que tem o nome Barão do Rio Branco {
    select * from socios where endereco like 'Barão do Rio Branco%';
}

*/