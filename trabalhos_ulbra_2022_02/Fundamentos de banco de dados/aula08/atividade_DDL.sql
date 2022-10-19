create table fornecedores(
    id int auto_increment primary key,
    codigo int not null,
    nome varchar(500) not null
);

create table categorias(
    codigo int auto_increment primary key,
    nome varchar(500) not null
);

create table produtos(
    codigo int auto_increment primary key,
    descricao varchar(100) not null,
    data_cadastro date not null,
    valor_unitario float not null
);

create table categoria_produto(
    codigo_produto int not null,
    constraint produtos_fk_categoria_produto
        foreign key(codigo_produto) references produtos(codigo),
    codigo_categoria int not null,
    constraint categorias_fk_categoria_produto
        foreign key(codigo_categoria) references categorias(codigo)
    on delete cascade
    on update restrict 
);

create table pedem(
    quantidade int auto_increment primary key,
    valor_unitario float not null,
    data date not null,
    id_fornecedor int not null,
    constraint fornecedores_fk_pedem
        foreign key(id_fornecedor) references fornecedores(id),
    codigo_produto int not null,
    constraint produtos_fk_pedem
        foreign key(codigo_produto) references produtos(codigo)
);