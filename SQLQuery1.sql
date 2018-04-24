
CREATE TABLE empresa(
	id_empresa bigint identity NOT NULL,
	nome_empresa VARCHAR(50),
	CONSTRAINT pk_is_usuario PRIMARY KEY (id_empresa)
);
CREATE table usuario
(
	id_usuario int identity unique not null,
	user_usuario VARCHAR(50) unique not null,
	senha_usuario VARCHAR(200) unique not null,
	email_usuario VARCHAR(50),
	perfil_usuario image,
	nivel_usuario int,
	salario_usuario numeric(18,2),
	id_empresa bigint,
	CONSTRAINT pk_id_usuario PRIMARY KEY(id_usuario),
	CONSTRAINT fk_id_empresa FOREIGN KEY (id_empresa) REFERENCES empresa (id_empresa)
);

CREATE table fornecedor
(
	id_fornecedor bigint identity unique  NOT NULL,
	cpf_fornecedor varchar(100),
	cnpj_fornecedor varchar(100),
	razao_social_fornecedor VARCHAR(100),
	fantasia_fornecedor VARCHAR(50),
	telefone_fornecedor bigint,
	site_fornecedor VARCHAR(50),
	celular_fornecedor bigint,
	email_fornecedor VARCHAR(50),
	cidade_fornecedor VARCHAR(50),
	rua_fornecedor VARCHAR(50),
	numero_fornecedor VARCHAR(50),
	complemento_fornecedor VARCHAR(50),
	nro_banco_fornecedor VARCHAR(50),
	ag_banco_fornecedor VARCHAR(50),
	conta_fornecedor VARCHAR(50),
	gerente_fornecedor VARCHAR(50),
	telefone_gerente_fornecedor bigint,
	celular_gerente_fornecedor bigint,
	obs_fornecedor VARCHAR(100),
	usuario_manutencao_fornecedor int,
	
	CONSTRAINT pk_id_fornecedor PRIMARY KEY (id_fornecedor),
	CONSTRAINT fk_usuario_manutencao_fornecedor FOREIGN KEY (usuario_manutencao_fornecedor) REFERENCES usuario (id_usuario)
);

CREATE TABLE documentos
(
	id_doc bigint identity unique not null,
	descricao_doc VARCHAR(50) not null,
	obs_doc VARCHAR(50),
	usuario_manutencao_documentos int,
	CONSTRAINT pk_id_doc PRIMARY KEY (id_doc),
	CONSTRAINT fk_usuario_manutencao_doc FOREIGN KEY (usuario_manutencao_documentos) REFERENCES usuario (id_usuario)
);


CREATE TABLE banco
(
	id_banco bigint identity unique not null,
	nome_banco VARCHAR(50) not null,
	nro_banco bigint not null,
	ag_banco VARCHAR(50) not null,
	conta_banco VARCHAR(50) not null,
	gerente_banco VARCHAR(50),
	telefone_gerente_banco bigint,
	celular_gerente_banco bigint,
	obs_banco VARCHAR(50),
	id_empresa bigint,
	usuario_manutencao_banco int,
	CONSTRAINT pk_id_banco PRIMARY KEY (id_banco),
	CONSTRAINT fk_usuario_manutencao_banco FOREIGN KEY (usuario_manutencao_banco) REFERENCES usuario (id_usuario),
	CONSTRAINT fk_empresa_banco FOREIGN KEY (id_empresa) REFERENCES empresa (id_empresa)
);

CREATE TABLE mov_lancamento
(
	id_lancamento bigint identity not null,
	favorecido VARCHAR(50) NOT NULL,
	data_lancamento timestamp,
	data_vencimento date,
	tipo_documento bigint,
	valor_do_titulo numeric(18,2),
	valor_pago numeric(18,2),
	acrecimo_valor numeric(18,2),
	descontos_valor numeric(18,2),
	saldo_a_pagar numeric(18,2),
	pago bit not null,
	data_pagamento datetime,
	CONSTRAINT fk_tipo_doc FOREIGN KEY (tipo_documento)  REFERENCES documentos (id_doc)


);
