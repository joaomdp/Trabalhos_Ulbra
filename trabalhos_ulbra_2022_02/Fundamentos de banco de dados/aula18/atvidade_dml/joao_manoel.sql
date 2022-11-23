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
    id_produtos int not null,
    id_fornecedor int not null,
    data_pedido date not null,

    constraint produtos_fk_pedidos
        foreign key(id_produtos) references produtos(id)
    on delete restrict
    on update cascade,

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

/*
--Inserindo Categorias
    insert into categorias(nome)
    value	('Eletronicos'),
            ('Estofados'),
            ('Esportes');
    
    SELECT * from categorias;

--Inserindo Produtos
    insert into produtos(descricao,data_cadastro,valor_unitario,id_categoria)
    value	('Celular','2022-04-15','1999',1),
            ('Bola de volei','2022-03-13','275',3),
            ('Sofá','2022-11-16','1899',2);
    
    SELECT * from produtos;

--Inserindo Fornecedores
    insert into fornecedores(codigo,nome)
    value	(100,'João'),
            (101,'Flávio'),
            (102,'Gustavo');
    
    SELECT * from fornecedores;

--Inserindo Pedidos
    insert into pedidos(id_produtos,id_fornecedor,data_pedido)
    value	(3,1,'2022-10-16'),
            (1,2,'2022-03-05'),
            (2,3,'2022-09-24');
    
    SELECT * from pedidos;

--Insrindo pedindos_itens
    insert into pedidos_itens(id_pedido,id_produto,quantidade,valor_unitario)
    value	(3,2,'14','275'),
            (2,1,'2','1999'),
            (1,3,'3','1899');
    
    SELECT * from pedidos_itens;

--Liste todos os produtos cadastrados e ordene por ordem alfabética de descrição.
    SELECT descricao
    FROM produtos
    order BY descricao 

--Lista os produtos que foram pedidos e o nome do fornecedor de cada pedido.
    SELECT p.data_pedido, p.id_produtos,pr.descricao, f.nome
    from pedidos p, fornecedores f, produtos pr
    WHERE p.id_fornecedor=f.id
    AND p.id_produtos=pr.id

--Mostre os produtos que já foram pedidos e o nome da categoria a que ele pertence.
    SELECT p.data_pedido, p.id_produtos,pr.descricao, c.nome
    from pedidos p, produtos pr, categorias c
    WHERE p.id_produtos=pr.id
    and pr.id_categoria=c.id

--Mostre o nome do fornecedor, a data do último pedido e a descrição do produto que ele pediu.
    SELECT f.nome, p.data_pedido, pr.descricao
    from fornecedores f, pedidos p, produtos pr
    WHERE p.id_produtos=pr.id
    and f.id=p.id_fornecedor
*/
