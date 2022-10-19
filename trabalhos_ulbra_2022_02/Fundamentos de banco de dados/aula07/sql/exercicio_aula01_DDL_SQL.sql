    create table colaboradores(
        id int auto_increment primary key,
        numero_matricula int not null,
        nome varchar(100) not null,
        endereco_email varchar(100) not null,
        senha varchar(50) not null
    );

    create table projetos(
        id int auto_increment primary key,
        nome varchar(100) not null,
        descricao varchar(100),
        estimativa_duracao time not null,
        categoria varchar(100) not null, 
        id_colaborador int not null,
        constraint fk_colaboradores_projetos
            foreign key(id_colaborador) references colaboradores(id)
    );

    create table comentarios(
        id_projeto int not null,
        data date not null,
        hora time not null,
        constraint fk_projetos_comentarios
            foreign key(id_projeto) references projetos(id)
    );

    create table melhorias(
        departamento varchar(100) not null,
        resultados_esperados varchar(100) not null,
        id_projeto int not null,
        constraint fk_projetos_melhorias
            foreign key(id_projeto) references projetos(id)
    );

    create table sociais(
        publico_beneficiario varchar(100) not null,
        id_projeto int not null,
        constraint fk_projetos_sociais
            foreign key(id_projeto) references projetos(id)
    );