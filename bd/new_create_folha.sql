CREATE TABLE inss (
  id_inss INTEGER NOT NULL identity,
  cod_inss INTEGER NULL,
  dsc_inss VARCHAR(50) NULL,
  valor_inss FLOAT NULL,
  PRIMARY KEY(id_inss)
);

CREATE TABLE Empregador (
  id_Empregador INTEGER NOT NULL identity,
  dsc_empregador VARCHAR(45) NULL,
  cpf_empregador INTEGER NULL,
  cnpj_empregador INTEGER NULL,
  tel_empregador INTEGER NULL,
  cel_empregador INTEGER NULL,
  email_empregador VARCHAR(50) NULL,
  end_empregador VARCHAR(80) NULL,
  bairro_empregador VARCHAR NULL,
  cep_empregador INTEGER  NULL,
  uf_empregador CHAR NULL,
  cidade_empregador varchar (50) null,
  numero_empregador integer,
  PRIMARY KEY(id_Empregador)
);
CREATE TABLE Funcionario (
  id_funcionario INTEGER NOT NULL identity,
  id_empregador integer not null,
  dt_entrada_func DATE NULL,
  cpf_func INTEGER NULL,
  rg_func INTEGER NULL,
  tel_func INTEGER  NULL,
  cel_func INTEGER  NULL,
  email_func VARCHAR (50) NULL,
  end_func VARCHAR (80) NULL,
  bairro_func VARCHAR(50) NULL,
  cep_func integer NULL,
  cidade_func VARCHAR(80) NULL,
  uf_func CHAR(2)NULL,
  PRIMARY KEY(id_funcionario),
  CONSTRAINT fk_id_empregadot FOREIGN KEY(id_empregador)
  REFERENCES EMPREGADOR(id_empregador)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE UF (
  id_uf INTEGER NOT NULL identity,
  uf_uf CHAR NULL,
  dsc_uf VARCHAR NULL,
  PRIMARY KEY(id_uf)
);



CREATE TABLE faltas (
  id_faltas INTEGER  NOT NULL identity,
  Funcionario_id_funcionario INTEGER NOT NULL,
  motivo_falta VARCHAR (80)NULL,
  dt_falta DATE NULL,
  PRIMARY KEY(id_faltas),
  CONSTRAINT fk_faltas_id_func FOREIGN KEY(Funcionario_id_funcionario)
  REFERENCES FUNCIONARIO(id_funcionario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE licenca_medica (
  protocolo_licenca INTEGER NOT NULL,
  Empregador_id_Empregador INTEGER NOT NULL,
  Funcionario_id_funcionario INTEGER NOT NULL,
  dt_inicio_licenca DATE NULL,
  dt_fim_licenca DATE NULL,
  cpf_funcionario INTEGER NULL,
  PRIMARY KEY(protocolo_licenca),
  CONSTRAINT fk_licenca_id_func FOREIGN KEY(Funcionario_id_funcionario)
  REFERENCES Funcionario(id_funcionario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,  
  CONSTRAINT fk_licenca_empregador FOREIGN KEY(Empregador_id_Empregador)
   REFERENCES Empregador(id_Empregador)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE Contrato_trabalho (
  id_contrato INTEGER NOT NULL identity,
  Empregador_id_Empregador INTEGER NOT NULL,
  Funcionario_id_funcionario INTEGER NOT NULL,
  jornada_diaria INTEGER NULL,
  jornada_semanal INTEGER NULL,
  data_pagamento DATE NULL,
  vale_transporte CHAR NULL,
  valor_diario FLOAT NOT NULL,
  qtd_dias_trabalho INTEGER NULL,
  carteira_trabalho VARCHAR(20) NULL,
  serie VARCHAR(15) NULL,
  salario FLOAT NULL,
  orgao_emissor VARCHAR(20) NULL,
  PIS VARCHAR (30)NULL,
  PRIMARY KEY(id_contrato),
  CONSTRAINT fk_contrato_id_func FOREIGN KEY(Funcionario_id_funcionario)
    REFERENCES Funcionario(id_funcionario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
    CONSTRAINT fk_Contrato_id_emp FOREIGN KEY(Empregador_id_Empregador)
    REFERENCES Empregador(id_Empregador)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE hora_extra (
  qtd_hr_extra INTEGER NOT NULL identity,
  dt_hr_extra DATE,
  Empregador_id_Empregador INTEGER NOT NULL,
  Funcionario_id_funcionario INTEGER NOT NULL,
  cpf_func INTEGER NULL,
  qtd_hora_extra INTEGER NULL,
  PRIMARY KEY(qtd_hr_extra),
  CONSTRAINT fk_hr_extra_func FOREIGN KEY(Funcionario_id_funcionario)
    REFERENCES Funcionario(id_funcionario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  CONSTRAINT fk_hr_extra_emp
    FOREIGN KEY(Empregador_id_Empregador)
    REFERENCES Empregador(id_Empregador)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE ferias (
  id_ferias INTEGER NOT NULL identity,
  Contrato_trabalho_id_contrato INTEGER NOT NULL,
  Empregador_id_Empregador INTEGER NOT NULL,
  Funcionario_id_funcionario INTEGER NOT NULL,
  qtd_dias_ferias INTEGER NULL,
  dt_entrada_ferias DATE NULL,
  dt_retorno_ferias DATE NULL,
  PRIMARY KEY(id_ferias),
  CONSTRAINT fk_ferias_id_func FOREIGN KEY(Funcionario_id_funcionario)
    REFERENCES Funcionario(id_funcionario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,  
  CONSTRAINT fk_ferias_id_emp FOREIGN KEY(Empregador_id_Empregador)
    REFERENCES Empregador(id_Empregador)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,  
  CONSTRAINT fk_ferias_id_contrato
  FOREIGN KEY(Contrato_trabalho_id_contrato)
    REFERENCES Contrato_trabalho(id_contrato)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE recisao (
  id_recisao INTEGER NOT NULL identity,
  ferias_id_ferias INTEGER NOT NULL,
  Funcionario_id_funcionario INTEGER NOT NULL,
  Empregador_id_Empregador INTEGER NOT NULL,
  cpf_func INTEGER NULL,
  dt_entrada_recisao DATE NULL,
  dt_saida DATE NULL,
  motivo_saida VARCHAR(150) NULL,
  ultimo_salario FLOAT NULL,
  aviso_previo CHAR NULL,
  ferias_vencidas CHAR NULL,
  saldo_fgts FLOAT NULL,
  PRIMARY KEY(id_recisao),
  CONSTRAINT fk_recisao_id_emp FOREIGN KEY(Empregador_id_Empregador)
    REFERENCES Empregador(id_Empregador)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,  
  CONSTRAINT fk_recisao_id_func FOREIGN KEY(Funcionario_id_funcionario)
    REFERENCES Funcionario(id_funcionario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  CONSTRAINT fk_recisao_id_ferias FOREIGN KEY(ferias_id_ferias)
    REFERENCES ferias(id_ferias)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE recibo (
  id_recibo INTEGER NOT NULL identity,
  faltas_id_faltas INTEGER  NOT NULL,
  Contrato_trabalho_id_contrato INTEGER NOT NULL,
  hora_extra_dt_hr_extra INTEGER NOT NULL,
  hora_extra_qtd_hr_extra INTEGER NOT NULL,
  Empregador_id_Empregador INTEGER NOT NULL,
  Funcionario_id_funcionario INTEGER NOT NULL,
  inss_id_inss INTEGER NOT NULL,
  mes_referencia DATE NULL,
  cpf_funcionario INTEGER NULL,
  PRIMARY KEY(id_recibo),
  CONSTRAINT fk_recibo_id_inss FOREIGN KEY(inss_id_inss)
    REFERENCES inss(id_inss)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,  
  CONSTRAINT fk_recibo_id_func  FOREIGN KEY(Funcionario_id_funcionario)
    REFERENCES Funcionario(id_funcionario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,  
  CONSTRAINT fk_recibo_id_emp FOREIGN KEY(Empregador_id_Empregador)
    REFERENCES Empregador(id_Empregador)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION, 
  CONSTRAINT fk_recibo_id_hr_extra FOREIGN KEY(hora_extra_qtd_hr_extra)
    REFERENCES hora_extra(qtd_hr_extra)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  CONSTRAINT fk_recibo_id_contrato FOREIGN KEY(Contrato_trabalho_id_contrato)
    REFERENCES Contrato_trabalho(id_contrato)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,  
  CONSTRAINT fk_recibo_id_faltas FOREIGN KEY(faltas_id_faltas)
    REFERENCES faltas(id_faltas)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);


