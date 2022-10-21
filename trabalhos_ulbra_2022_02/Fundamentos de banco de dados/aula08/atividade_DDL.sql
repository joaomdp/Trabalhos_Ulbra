create table categorias(
    id int auto_increment primary key,
    nome varchar(100) not null
);

create table produtos(
    id int auto_increment primary key,
    descricao varchar(200) not null,
    data_cadastro date not null,
    valor_unitario decimal(12,2) not null,
    id_categoria int not null,
    constraint categorias_fk_produtos
        foreign key(id_categoria) references categorias(id)
    on delete restrict
    on update cascade 
);

create table fornecedores(
    id int auto_increment primary key,
    codigo int not null,
    nome varchar(500) not null
);

create table pedidos(
    id int auto_increment primary key,
    id_fornecedor int not null,
    data_pedido date not null,
    constraint fornecedores_fk_pedidos
        foreign key(id_fornecedor) references fornecedores(id)
    on delete restrict
    on update cascade 
);

create table pedidos_itens(
    id_pedido int not null,
    id_produto int not null,
    quantidade decimal(8,3) not null,
    -- valor_total_item decimal(12,2) default 0,
    valor_unitario decimal(12,2) not null,
    constraint pedidos_fk_pedidos_itens
        foreign key(id_pedido) references pedidos(id)
        on delete restrict
        on update cascade,

    constraint produtos_fk_pedidos_itens
        foreign key(id_produto) references produtos(id)
        on delete restrict 
        on update cascade
);

