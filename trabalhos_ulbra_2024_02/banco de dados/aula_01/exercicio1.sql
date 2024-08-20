CREATE TABLE produto (
    id INT PRIMARY KEY,
    descricao VARCHAR(50),
    price NUMERIC, 
    nomeCategoria VARCHAR(20), 
    descricao_categoria VARCHAR(35)
);

CREATE TABLE cidade (
    id INT PRIMARY KEY,
    nome VARCHAR(150),
    uf VARCHAR(20)
);

CREATE TABLE filial (
    id INT PRIMARY KEY,
    nome VARCHAR(150),
    endereco VARCHAR(300),
    id_cidade INT,
    FOREIGN KEY (id_cidade) REFERENCES cidade(id)
);

CREATE TABLE empregado (
    id INT PRIMARY KEY,
    nome VARCHAR(150),
    endereco VARCHAR(300),  
    codcidade INT,
    carteira_trabalho INT,
    rg VARCHAR(9),
    cpf VARCHAR(11),
    salario NUMERIC,
    id_filial INT,
    FOREIGN KEY (codcidade) REFERENCES cidade(id),
    FOREIGN KEY (id_filial) REFERENCES filial(id)
);

CREATE TABLE vende (
    id_produto INT,
    id_filial INT,
    PRIMARY KEY (id_produto, id_filial),
    FOREIGN KEY (id_produto) REFERENCES produto(id),
    FOREIGN KEY (id_filial) REFERENCES filial(id)
);
