create table categorias(
    id int auto_increment primary key,
    nome varchar(100)
);

create table produtos(
    id int auto_increment primary key,
    nome varchar(100) not null,
    preco decimal(12,2) not null,
    data_cad date not null,
    id_categoria int not null
    constraint produtos_fk_categorias
        foreign key(id_categoria) references categorias(id)
);

create table vendas(
    id int auto_increment primary key,
    data date not null,
    id_cliente int not null
);

/*
Categorias
id      nome
101     acessorios   
502     eletro
103     estofados

Produtos
id      nome        preco       data_cad        id_categoria
201     mochila     190,90      2022-10-01      101 
202     caneta      13,-90      2022-10-20      101  
203     celular     1002,90     2022-11-05      502
204     tv          1999,99     2022-09-02      502

Vendas
id       data_cad        id_categoria
1001     2022-05-10      102 
1002     2022-07-15      103  
1003     2022-10-17      104
1004     2022-10-31      502

Vendas_itens
id     id_venda     id_produto      quant       valor_unit
90     1001         201             1           188,00
91     1001         202             5           100,00
93     1003         204             1           1000,00
*/

--Inserir o atributo acessorios em categorias (nome)
insert into categorias(nome)
    values('acessorios');

--Atualizar o preço do produto 'caneta bic'
update produtos
set preco=9.90
where id=202;

--Deletar todos a coluna TV
delete from produtos
where id=204;

--Selecionar todos os produtos com o preco maior que 1000,00
select id, nome, preco 
from produtos
where preco>=1000;

--Na consulta anterior, crie uma nova coluna acrescentando 10% ao preço
select id, nome, preco, (preco*1.10) as novo_preco 
from produtos
where preco>=1000;

--Na consulta anterior, mostre quais os produtos acima de 1000 que foram cadastrados em novembro
select id, nome, preco, (preco*1.10) as novo_preco 
from produtos
where preco>=1000
and data_cad>='2022-11-1' 
and data_cad<='2022-11-30';

--Me lista a soma dos produtos cadastrados no mes de setembro e outubro
/*
    Agregação:
    max - maximo
    min - minimo    
    sum - soma
    count - numero de linhas retornadas por uma consulta
    avg - media
*/
select sum(preco) as soma
from produtos
where data_cad>='2022-09-01'
and data_cad<='2022-09-31';

--Mostrar na consulta o nome da categoria junto ao produto
select P.id, P.nome, C.nome, as categorias
from produtos P, categorias C
where P.id_categoria = C.id;

--Mostrar na consulta as vendas e os produtos e o cliente
select P.id, P.nome, VI.quant
from vendas V, vendas_itens VI, produtos P
where V.id = VI.id_venda
and P.id = VI.id_produto
and V.id_cliente=104

--Mostrar os produtos que começam com celular
P.Nome like 'celular%';

--Mostrar os produtos que terminam com celular
P.Nome like '%celular';

--Mostrar os produtos que tem celular
P.Nome like '%celular%';

--Produtos que foram vendidos no mes de outubro e o valor total de cada protudo
select p.id, p.nome, vi.quant, vi.valor_unit vi.quant*vi.valor_unit as valor_total
from produtos p, vendas_itens vi, vendas v
where v.id=vi.venda
and vi.id_produto=p.id


/*
    Salas:
        numero
        316
        317
        326
        327

    Alunos:
        id      sala        nome
        1       316         joao
        2       316         alice
        3       316         ana
        4       317         aa
        5       317         xx
        6       326         bb
        7       326         ccc
        8       326         dd
        9       326         ee
        10      327         bbb
*/

select sala count(id) as num
from Alunos
where sala=326
and sala=327
group by sala

--Qual o preço mais alto dos produtos por categoria
select c.nome as categoria, max(p.preco) as val_max
from categorias c, Produtos p
where c.id=p.id_categoria
group by c.nome;

--Order by
select from produtos
order by preco asc --  crescente 
order by preco desc --  decrecente
