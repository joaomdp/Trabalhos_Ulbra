create table clientes(
    id int auto_increment primary key,
    nome varchar(100) not null,
    cpf char(11) unique,
    telefone char(11),
    endereco varchar(100) not null,
    cidade varchar(100) not null,
    estado char(2) not null
);

create table carros(
    id int auto_increment primary key,
    marca varchar(20) not null,
    modelo varchar(20) not null
);

create table locacoes(
    id int auto_increment primary key,
    data_locacao date not null,
    valor_locacao decimal(12.2),
    id_cliente int not null,
    id_carro int not null,

    constraint locacoes_fk_clientes
        foreign key locacoes(id_cliente) references clientes(id),
    constraint locacoes_fk_carros
        foreign key locacoes(id_carro) references carros(id)
    
    on UPDATE cascade 
  	on DELETE CASCADE
);

INSERT into clientes(nome,cpf,telefone,endereco,cidade,estado)
VALUES 	('Jeferson', '48906409087', '8334027678', 'Rua Tal', 'Osório', 'RS'),
		('Rafaela', '78945612301', '12358746014', 'Rua Aquela', 'Laguna', 'SC'),
        ('Jonas', '74185296302', '36987412054', 'Rua Tal', 'Osório', 'RS'),
        ('Luis', '12457896302', '78542136905', 'Rua Aonde', 'Rio de Janeiro', 'RJ');

INSERT into carros(marca, modelo)
VALUES 	('Fiat', 'Uno'),
		('volkswagen', 'Gol'),
        ('peugeot', '206'),
        ('Fiat', 'Palio');

INSERT into locacoes(data_locacao,valor_locacao, id_cliente, id_carro)
VALUES 	('2022-11-29',150, 3,3),
		('2022-06-24',300, 2,3),
        ('2021-11-15',300, 4,1),
        ('2021-06-04',275, 1,4);

-- Valor total de alugeuis de carros acima de 200
SELECT SUM(valor_locacao) AS total
FROM locacoes WHERE valor_locacao > 200;

-- Selecionar apenas o mês da locação do veiculo
SELECT c.nome, l.valor_locacao, MONTH(l.data_locacao) AS mês 
FROM locacoes l, clientes c
WHERE l.id_cliente=c.id;

-- Maior valor de locação 
SELECT max(valor_locacao) as maior_valor
FROM locacoes

-- Menor valor de locação 
SELECT MIN(valor_locacao) as menor_valor
FROM locacoes

-- Todos os carros alugados antes de 2022
SELECT c.marca, c.modelo, cl.nome, l.data_locacao
FROM carros c, clientes cl, locacoes l
WHERE l.id_cliente=cl.id and l.id_carro=c.id
GROUP BY c.marca, cl.nome
HAVING l.data_locacao<='2022-01-01'

-- Mostrar todos os carros que foram alugados e o valor
SELECT carros.marca, carros.modelo, locacoes.valor_locacao
FROM carros RIGHT join locacoes 
ON locacoes.id_carro=carros.id

-- Mostrar todos os carros, ate os que nao foram alugados
SELECT carros.marca, carros.modelo, locacoes.valor_locacao
FROM locacoes RIGHT join carros 
ON locacoes.id_carro=carros.id
