create table ulbra(
    id int auto_increment primary key
);

create table pesquisadores(
    id int auto_increment primary key,
    nome varchar(250) not null
);

create table artigos(
    id int auto_increment primary key,
    codigo_artigo int unique not null,
    titulo varchar(50) not null,
    pagina_inicial int not null,
    pagina_final int not null,
    codigo_periodico varchar(20) unique not null,
    titulo_periodico varchar(100) not null,
    editora varchar(50) not null
);

create table artigos_publicados(
    id int auto_increment primary key,
    data_publicacao date not null,
    id_pesquisador int not null,
    id_artigo int not null,
    constraint pesquisadores_fk_artigos_publicados
        foreign key(id_pesquisador) references pesquisadores(id)
        on delete restrict
        on update cascade,

    constraint artigos_fk_artigos_publicados
        foreign key(id_artigo) references artigos(id)
        on delete restrict
        on update cascade 
);

/*
Adiconando pesquisadores {
    INSERT into pesquisadores (nome)
    VALUES
    ('João'),
    ('Lucas'),
    ('Roberto');
}

Adicionando artigos{
    INSERT into artigos (codigo_artigo, titulo, pagina_inicial, pagina_final, codigo_periodico, titulo_periodico, editora)
    VALUES
    (1234, 'Branca de neve', 1, 56, '5342-000', 'Conto de fadas', 'Saraiva'),
    (3214, 'Rapunzel', 1, 65, '4122-000', 'Princesa', 'Panini'),
    (9875, 'Claiton rasta', 1, 36, '6744-000', 'Biografia', 'Qualquer uma');
}

Adicionando artigos_publicados{
    INSERT into artigos_publicados (data_publicacao, id_pesquisador, id_artigo)
    VALUES
    ('2022-10-27', 1, 1),
    ('2021-08-06', 1, 2),
    ('2021-05-21', 2, 3);
}

- listar o artigo com código 1234 {
    SELECT * from artigos where codigo_artigo = 1234
}

- listar os artigos da editora Saraiva {
    SELECT * from artigos where editora = "Saraiva"
}

- Listar os pesquisadores onde o nome inicia com João {
    SELECT * from pesquisadores where nome = "João"
}
*/